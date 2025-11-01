using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Automotive
{
    public partial class Login : KryptonForm
    {
        private string connectionString = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=AutomotiveDB;Integrated Security=True;";
        private int userId;
        private string email;
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string pass = txtPass.Text;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string input = txtEmail.Text.Trim();
                if (string.IsNullOrEmpty(input)) return;

                var history = Properties.Settings.Default.EmailHistory
                              ?? new System.Collections.Specialized.StringCollection();

                if (!history.Contains(input))
                {
                    history.Add(input);
                    Properties.Settings.Default.EmailHistory = history;
                    Properties.Settings.Default.Save();
                }

                conn.Open();

                string checkUserQuery = "SELECT id, password, attempts, status, role FROM Accounts WHERE email = @Email";
                SqlCommand checkUserCmd = new SqlCommand(checkUserQuery, conn);
                checkUserCmd.Parameters.AddWithValue("@Email", email);

                SqlDataReader reader = checkUserCmd.ExecuteReader();

                if (reader.Read())
                {
                    userId = Convert.ToInt32(reader["id"]);
                    string correctPass = reader["password"].ToString();
                    int attempts = Convert.ToInt32(reader["attempts"]);
                    string status = reader["status"].ToString();
                    string role = reader["role"].ToString();
                    reader.Close();

                    if (status == "locked")
                    {
                        lblInvalid.Text = "Your account is locked. Click FORGOT PASSWORD to reset your password";
                        return;
                    }

                    if (correctPass == pass)
                    {
                        if (rememberMeCB.Checked)
                        {
                            Properties.Settings.Default.RememberMe = true;
                            Properties.Settings.Default.RememberedUserId = userId;
                            Properties.Settings.Default.Save();
                        }
                        else
                        {
                            Properties.Settings.Default.RememberMe = false;
                            Properties.Settings.Default.RememberedUserId = -1;
                            Properties.Settings.Default.Save();
                        }

                        string resetQuery = "UPDATE Accounts SET attempts = 0 WHERE id = @Id";
                        SqlCommand resetCmd = new SqlCommand(resetQuery, conn);
                        resetCmd.Parameters.AddWithValue("@Id", userId);
                        resetCmd.ExecuteNonQuery();

                        string dateQuery = "SELECT removeVerificationDate FROM Accounts WHERE id = @Id";
                        SqlCommand dateCmd = new SqlCommand(dateQuery, conn);
                        dateCmd.Parameters.AddWithValue("@Id", userId);

                        object dateObj = dateCmd.ExecuteScalar();
                        DateTime? lastVerifiedDate = dateObj != DBNull.Value ? Convert.ToDateTime(dateObj) : (DateTime?)null;

                        bool needs2FA = true;
                        if (lastVerifiedDate.HasValue)
                        {
                            if ((DateTime.Now - lastVerifiedDate.Value).TotalDays <= 30)
                                needs2FA = false;
                        }

                        if (role == "SalesRep")
                        {
                            if (needs2FA)
                            {
                                _2_StepVerification verifyForm = new _2_StepVerification(userId, email);
                                this.Hide();
                                verifyForm.Show();
                            }
                            else
                            {
                                MainForm main = new MainForm(userId);
                                MessageBox.Show("YESSSS");
                                this.Hide();
                                main.Show();
                            }
                        }
                        else if (role == "Admin")
                        {
                            if (needs2FA)
                            {
                                _2_StepVerification verifyForm = new _2_StepVerification(userId, email);
                                this.Hide();
                                verifyForm.Show();
                            }
                            else
                            {
                                Main_Admin main = new Main_Admin(userId);
                                this.Hide();
                                main.Show();
                            }
                        }

                    }
                    else
                    {
                        attempts++;

                        if (attempts >= 3)
                        {
                            string lockQuery = "UPDATE Accounts SET status = 'locked', attempts = @Attempts WHERE id = @Id";
                            SqlCommand lockCmd = new SqlCommand(lockQuery, conn);
                            lockCmd.Parameters.AddWithValue("@Attempts", attempts);
                            lockCmd.Parameters.AddWithValue("@Id", userId);
                            lockCmd.ExecuteNonQuery();

                            lblInvalid.Text = "Account locked due to 3 failed attempts";
                        }
                        else
                        {
                            string updateQuery = "UPDATE Accounts SET attempts = @Attempts WHERE id = @Id";
                            SqlCommand updateCmd = new SqlCommand(updateQuery, conn);
                            updateCmd.Parameters.AddWithValue("@Attempts", attempts);
                            updateCmd.Parameters.AddWithValue("@Id", userId);
                            updateCmd.ExecuteNonQuery();

                            lblInvalid.Text = $"Invalid password {3 - attempts} attempts left";
                        }
                    }
                }
                else
                {
                    lblInvalid.Text = "Invalid Email";
                }
            }
        }

        private void btnShowPass_Click(object sender, EventArgs e)
        {
            if (txtPass.PasswordChar == '*')
            {
                txtPass.PasswordChar = '\0';
                btnShowPass.Image = Properties.Resources.hide;
            }
            else
            {
                txtPass.PasswordChar = '*';
                btnShowPass.Image = Properties.Resources.show;
            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            SignUpRequest signUpRequest = new SignUpRequest();
            this.Hide();
            signUpRequest.Show();
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit(); 
        }

        private void btnForgot_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            ForgotPasswordOTP forgotPasswordOTP = new ForgotPasswordOTP(txtEmail.Text);
            forgotPasswordOTP.Show();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.AcceptButton = btnLogin;

            txtEmail.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtEmail.AutoCompleteSource = AutoCompleteSource.CustomSource;

            var history = Properties.Settings.Default.EmailHistory;
            if (history != null)
            {
                txtEmail.AutoCompleteCustomSource.AddRange(history.Cast<string>().ToArray());
            }

            if (Properties.Settings.Default.RememberMe && Properties.Settings.Default.RememberedUserId != -1)
            {
                rememberMeCB.Checked = true;

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT email FROM Accounts WHERE id = @Id";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Id", Properties.Settings.Default.RememberedUserId);
                        object result = cmd.ExecuteScalar();
                        if (result != null)
                        {
                            txtEmail.Text = result.ToString();
                        }
                    }
                }
            }
        }


        private void rememberMeCB_CheckedChanged(object sender, EventArgs e)
        {
            if (rememberMeCB.Checked)
            {
                Properties.Settings.Default.RememberMe = true;
                Properties.Settings.Default.RememberedUserId = userId;
                Properties.Settings.Default.RememberedEmail = email;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.RememberMe = false;
                Properties.Settings.Default.RememberedUserId = 0;
                Properties.Settings.Default.RememberedEmail = string.Empty;
                Properties.Settings.Default.Save();
            }
        }

        private void txtPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && (e.KeyCode == Keys.C || e.KeyCode == Keys.V || e.KeyCode == Keys.X))
            {
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }

        private void txtPass_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                txtPass.ContextMenu = new ContextMenu();
            }
        }
    }
}