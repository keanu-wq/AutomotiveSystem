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
using ComponentFactory.Krypton.Toolkit;

namespace Automotive
{
    public partial class SignUp : KryptonForm
    {
        private string connectionString = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=AutomotiveDB;Integrated Security=True;";
        public String _name;
        public String _email;
        public String _pass;
        public SignUp()
        {
            InitializeComponent();
        }

        private string ValidateName(string name)
        {
            if (!Regex.IsMatch(name, @"^[a-zA-Z\s]+$"))
                throw new StringFormatException("Name Cannot Contain Numbers or Special Characters");

            if (string.IsNullOrEmpty(name))
                throw new ArgumentNullException("Please input your name");

            return name;
        }

        private string ValidateEmail(string email)
        {

            if (string.IsNullOrEmpty(email))
                throw new ArgumentNullException("Please input your Username");

            if (!Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
                throw new InvalidEmailException("Invalid email address");

            return email;
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

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login().Show();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            try
            {
                _name = ValidateName(txtName.Text);
                _email = ValidateEmail(txtEmail.Text);
                _pass = ValidatePass(txtPass.Text);

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // If email already exists in the database
                    string checkEmailQuery = "SELECT COUNT(*) FROM Accounts WHERE email = @Email";

                    SqlCommand checkCmd = new SqlCommand(checkEmailQuery, conn);
                    checkCmd.Parameters.AddWithValue("@Email", _email);
                    int emailCount = (int)checkCmd.ExecuteScalar();

                    if (emailCount > 0)
                    {
                        lblInvalid.Text = "Email already exists. Please use a different email or login.";
                        return;
                    }

                    //If not existing, insert the data into the database.
                    string insertQuery = @"INSERT INTO Accounts (name, email, password, attempts, status, role) 
                                   VALUES (@Name, @Email, @Password, @Attempts, @Status, @Role)";

                    SqlCommand insertCmd = new SqlCommand(insertQuery, conn);
                    insertCmd.Parameters.AddWithValue("@Name", _name);
                    insertCmd.Parameters.AddWithValue("@Email", _email);
                    insertCmd.Parameters.AddWithValue("@Password", _pass); 
                    insertCmd.Parameters.AddWithValue("@Attempts", 0); 
                    insertCmd.Parameters.AddWithValue("@Status", "active"); 
                    insertCmd.Parameters.AddWithValue("@Role", "SalesRep"); 

                    int rowsAffected = insertCmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Sign Up successful!\n \nYou will receive a Verification Code on your Email");
                        this.Hide();
                        new OTPForm(this).Show();
                    }
                    else
                    {
                        lblInvalid.Text = "Sign up failed. Please try again.";
                    }
                }
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627) // Unique constraint violation
                {
                    lblInvalid.Text = "Email already exists. Please use a different email.";
                }
                else
                {
                    lblInvalid.Text = "Database error: " + ex.Message;
                }
            }
            catch (NoSpecialCharacterAndWhiteSpacesException nsc)
            {
                lblInvalid.Text = nsc.Message;
            }
            catch (StringFormatException sfe)
            {
                lblInvalid.Text = sfe.Message;
            }
            catch (ArgumentNullException ane)
            {
                lblInvalid.Text = ane.Message;
            }
            catch (InvalidEmailException iee)
            {
                lblInvalid.Text = iee.Message;
            }
            catch (ArgumentException ae)
            {
                lblInvalid.Text = ae.Message;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unexpected error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void SignUp_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {
            passChecking(txtPass.Text);
            passStrength(txtPass.Text);
        }

        private void SignUp_Load(object sender, EventArgs e)
        {
            this.AcceptButton = btnSignUp;
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
}
