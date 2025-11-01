using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Automotive
{
    public partial class ResetPassword : KryptonForm
    {
        private string connectionString = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=AutomotiveDB;Integrated Security=True;";
        private String _pass;
        private int userId;
        public ResetPassword(int userId)
        {
            InitializeComponent();
            this.userId = userId;
        }

        private string ValidatePass(string pass)
        {
            if (Regex.IsMatch(pass, @"\s"))
                throw new NoSpecialCharacterAndWhiteSpacesException("Password cannot contain whitespace.");

            if (!Regex.IsMatch(pass, @"^[a-zA-Z0-9!@#$%^&*(),.?""':{}|<>_\-+=\\/\[\]~`]+$"))
                throw new StringFormatException("Password contains invalid characters.");

            if (!Regex.IsMatch(pass, @"[A-Z]"))
                throw new StringFormatException("Password must contain at least one uppercase letter.");

            if (!Regex.IsMatch(pass, @"[a-z]"))
                throw new StringFormatException("Password must contain at least one lowercase letter.");

            if (!Regex.IsMatch(pass, @"[0-9]"))
                throw new StringFormatException("Password must contain at least one digit.");

            if (!Regex.IsMatch(pass, @"[!@#$%^&*(),.?""':{}|<>_\-+=\\/\[\]~`]"))
                throw new StringFormatException("Password must contain at least one special character.");

            if (string.IsNullOrEmpty(pass))
                throw new ArgumentNullException("Please input your Password");

            if (pass.Length < 8)
                throw new ArgumentException("Password must be atleast 8 Characters");

            return pass;
        }

        private void passStrength(string pass)
        {
            int score = 0;

            if (Regex.IsMatch(pass, @"[a-z]") && Regex.IsMatch(pass, @"[A-Z]"))
                score++;

            if (Regex.IsMatch(pass, @"[0-9]"))
                score++;

            if (Regex.IsMatch(pass, @"[!@#$%^&*(),.?""':{}|<>_\-+=\\/\[\]~`]"))
                score++;

            if (pass.Length >= 8)
                score++;

            barWeak.StateCommon.Color1 = Color.Silver;
            barMedium.StateCommon.Color1 = Color.Silver;
            barStrong.StateCommon.Color1 = Color.Silver;

            lblStrength.Text = "None";
            lblStrength.ForeColor = Color.Silver;

            if (score <= 1) // Weak
            {
                barWeak.StateCommon.Color1 = Color.Red;
                lblStrength.ForeColor = Color.Red;
                lblStrength.Text = "Weak";
            }
            else if (score == 2 || score == 3) // Medium
            {
                barWeak.StateCommon.Color1 = Color.Yellow;
                barMedium.StateCommon.Color1 = Color.Yellow;
                lblStrength.ForeColor = Color.Orange;
                lblStrength.Text = "Medium";
            }
            else if (score >= 4) // Strong
            {
                barWeak.StateCommon.Color1 = Color.Green;
                barMedium.StateCommon.Color1 = Color.Green;
                barStrong.StateCommon.Color1 = Color.Green;
                lblStrength.ForeColor = Color.Green;
                lblStrength.Text = "Strong";
            }
        }

        private void CheckPasswordHistory(int userId, string newPassword)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = "SELECT password FROM Passwords WHERE id = @UserId";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@UserId", userId);

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string oldPassword = reader["password"].ToString();
                    if (oldPassword == newPassword)
                    {
                        throw new PasswordReuseException("You cannot use your past passwords");
                    }
                }
            }
        }

        private void passChecking(string pass)
        {
            if (!string.IsNullOrEmpty(pass))
            {
                if (!Regex.IsMatch(pass, @"\s"))
                    lblGuide4.ForeColor = Color.Green;
                else
                    lblGuide4.ForeColor = Color.Brown;

                if (!Regex.IsMatch(pass, @"[a-z]"))
                    lblGuide1.ForeColor = Color.Brown;
                else
                {
                    if (Regex.IsMatch(pass, @"[A-Z]"))
                        lblGuide1.ForeColor = Color.Green;
                    else
                        lblGuide1.ForeColor = Color.Brown;
                }

                if (!Regex.IsMatch(pass, @"[0-9]"))
                    lblGuide2.ForeColor = Color.Brown;
                else
                    lblGuide2.ForeColor = Color.Green;

                if (!Regex.IsMatch(pass, @"[!@#$%^&*(),.?""':{}|<>_\-+=\\/\[\]~`]"))
                    lblGuide3.ForeColor = Color.Brown;
                else
                    lblGuide3.ForeColor = Color.Green;

                if (pass.Length >= 8)
                    lblGuide5.ForeColor = Color.Green;
                else
                    lblGuide5.ForeColor = Color.Brown;
            }
            else
            {
                lblGuide1.ForeColor = Color.Brown;
                lblGuide2.ForeColor = Color.Brown;
                lblGuide3.ForeColor = Color.Brown;
                lblGuide4.ForeColor = Color.Brown;
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

        private void txtPass_TextChanged(object sender, EventArgs e)
        {
            passChecking(txtPass.Text);
            passStrength(txtPass.Text);
        }

        private void ResetPassword_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                _pass = ValidatePass(txtPass.Text);

                CheckPasswordHistory(userId, _pass);

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string updateQuery = @"UPDATE Accounts 
                                           SET password = @Password, attempts = 0, status = 'active'
                                           WHERE id = @UserId";

                    SqlCommand cmd = new SqlCommand(updateQuery, conn);
                    cmd.Parameters.AddWithValue("@Password", _pass);
                    cmd.Parameters.AddWithValue("@UserId", userId);

                    cmd.ExecuteNonQuery();

                    string insertHistory = "INSERT INTO Passwords (id, password) " +
                                            "VALUES (@UserId, @Password)";

                    SqlCommand historyCmd = new SqlCommand(insertHistory, conn);
                    historyCmd.Parameters.AddWithValue("@UserId", userId);
                    historyCmd.Parameters.AddWithValue("@Password", _pass);
                    historyCmd.ExecuteNonQuery();
                }

                MessageBox.Show("Password updated successfully! Your account is now unlocked.",
                                "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Hide();
                new Login().Show();
            }
            catch (PasswordReuseException ex)
            {
                lblInvalid.Text = ex.Message;
            }
            catch (NoSpecialCharacterAndWhiteSpacesException ex)
            {
                lblInvalid.Text = ex.Message;
            }
            catch (StringFormatException ex)
            {
                lblInvalid.Text = ex.Message;
            }
            catch (ArgumentNullException ex)
            {
                lblInvalid.Text = ex.Message;
            }
            catch (InvalidEmailException ex)
            {
                lblInvalid.Text = ex.Message;
            }
            catch (ArgumentException ex)
            {
                lblInvalid.Text = ex.Message;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unexpected error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ResetPassword_Load(object sender, EventArgs e)
        {
            this.AcceptButton = btnConfirm;
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
                ((TextBox)sender).ContextMenu = new ContextMenu();
            }
        }
    }
}
public class StringFormatException : Exception
{
    public StringFormatException(string input) : base(input) { }
}
public class NoSpecialCharacterAndWhiteSpacesException : Exception
{
    public NoSpecialCharacterAndWhiteSpacesException(string input) : base(input) { }
}
public class InvalidEmailException : Exception
{
    public InvalidEmailException(string input) : base(input) { }
}

public class PasswordReuseException : Exception
{
    public PasswordReuseException(string message) : base(message) { }
}
