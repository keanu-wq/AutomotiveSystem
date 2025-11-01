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

namespace Automotive
{
    public partial class SettingsTabAccountUC : UserControl
    {
        private int _userId;
        private string _newPass;
        private string _oldPass;
        private string connectionString = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=AutomotiveDB;Integrated Security=True;";
        public SettingsTabAccountUC(int userId)
        {
            InitializeComponent();
            _userId = userId;
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

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                _oldPass = txtOldPass.Text;
                _newPass = ValidatePass(txtNewPass.Text);

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string checkQuery = "SELECT COUNT(*) FROM Accounts WHERE id = @id AND password = @oldPass";
                    using (SqlCommand checkCmd = new SqlCommand(checkQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@id", _userId);
                        checkCmd.Parameters.AddWithValue("@oldPass", _oldPass);

                        int count = (int)checkCmd.ExecuteScalar();
                        if (count == 0)
                        {
                            lblInvalid.Text = "Old password is incorrect";
                            return;
                        }
                    }

                    if (_oldPass == _newPass)
                    {
                        throw new PasswordReuseException("New password cannot be the same as the old password.");
                    }

                    string historyQuery = "SELECT password FROM Passwords WHERE id = @id";
                    using (SqlCommand historyCmd = new SqlCommand(historyQuery, conn))
                    {
                        historyCmd.Parameters.AddWithValue("@id", _userId);
                        using (SqlDataReader reader = historyCmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string oldPassword = reader["password"].ToString();
                                if (oldPassword == _newPass)
                                {
                                    throw new PasswordReuseException("You cannot reuse an old password. Please choose a new one.");
                                }
                            }
                        }
                    }

                    string updateQuery = "UPDATE Accounts SET password = @newPass WHERE id = @id";
                    using (SqlCommand updateCmd = new SqlCommand(updateQuery, conn))
                    {
                        updateCmd.Parameters.AddWithValue("@newPass", _newPass);
                        updateCmd.Parameters.AddWithValue("@id", _userId);
                        updateCmd.ExecuteNonQuery();
                    }

                    string insertHistory = "INSERT INTO Passwords (id, password) VALUES (@id, @newPass)";
                    using (SqlCommand insertCmd = new SqlCommand(insertHistory, conn))
                    {
                        insertCmd.Parameters.AddWithValue("@id", _userId);
                        insertCmd.Parameters.AddWithValue("@newPass", _newPass);
                        insertCmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Password updated successfully!",
                                "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("Unexpected error: " + ex.Message, "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnShowOldPass_Click(object sender, EventArgs e)
        {
            if (txtOldPass.PasswordChar == '*')
            {
                txtOldPass.PasswordChar = '\0';
                btnShowOldPass.Image = Properties.Resources.hide;
            }
            else
            {
                txtOldPass.PasswordChar = '*';
                btnShowOldPass.Image = Properties.Resources.show;
            }
        }

        private void btnShowNewPass_Click(object sender, EventArgs e)
        {
            if (txtNewPass.PasswordChar == '*')
            {
                txtNewPass.PasswordChar = '\0';
                btnShowNewPass.Image = Properties.Resources.hide;
            }
            else
            {
                txtNewPass.PasswordChar = '*';
                btnShowNewPass.Image = Properties.Resources.show;
            }
        }

        private void txtNewPass_TextChanged(object sender, EventArgs e)
        {
            passChecking(txtNewPass.Text);
            passStrength(txtNewPass.Text);
        }

        private void txtOldPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && (e.KeyCode == Keys.C || e.KeyCode == Keys.V || e.KeyCode == Keys.X))
            {
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }

        private void txtNewPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && (e.KeyCode == Keys.C || e.KeyCode == Keys.V || e.KeyCode == Keys.X))
            {
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }

        private void txtOldPass_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ((TextBox)sender).ContextMenu = new ContextMenu();
            }
        }

        private void txtNewPass_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ((TextBox)sender).ContextMenu = new ContextMenu();
            }
        }
    }
}
