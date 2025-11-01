using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Automotive
{
    public partial class _2_StepVerification : KryptonForm
    {
        private string connectionString = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=AutomotiveDB;Integrated Security=True;";
        private int userId;
        private string email;
        private string generatedOTP;
        int timeLeft = 60;
        public _2_StepVerification(int userId, string email)
        {
            InitializeComponent();
            this.userId = userId;
            this.email = email;
        }

        private void SendOtpEmail(string toEmail, string otp)
        {
            try
            {
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress("jdrodilas24@gmail.com");
                mail.To.Add(toEmail);
                mail.Subject = "2-Step Verification";
                mail.Body = $"Your Verification Passcode is: {otp}";

                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                smtp.Credentials = new NetworkCredential("jdrodilas24@gmail.com", "tdji gbzp jtcr kvel");
                smtp.EnableSsl = true;

                smtp.Send(mail);

                lblInvalid.Text = "Verification Code has been sent to your email.";
                lblInvalid.ForeColor = Color.Green;
            }
            catch (Exception ex)
            {
                lblInvalid.Text = "There is a problem sending code, Please try again.";
                lblInvalid.ForeColor = Color.Red;
            }
        }

        private void StartCountdown()
        {
            timeLeft = 60;
            lblTimer.Text = timeLeft.ToString() + "s";
            btnResend.Enabled = false;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                if (timeLeft > 0)
                {
                    timeLeft--;
                    if (lblTimer != null)
                        lblTimer.Text = timeLeft.ToString() + "s";
                }
                else
                {
                    timer1.Stop();
                    if (lblTimer != null)
                        lblTimer.Text = "00s";
                    if (btnResend != null)
                        btnResend.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                timer1.Stop();
                MessageBox.Show("Timer error: " + ex.Message,
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void _2_StepVerification_Load(object sender, EventArgs e)
        {
            this.AcceptButton = btnEnter;

            btnResend.Enabled = false;
            StartCountdown();

            Random rand = new Random();
            generatedOTP = rand.Next(100000, 999999).ToString();

            SendOtpEmail(email, generatedOTP);
        }

        private void btnShowPass_Click(object sender, EventArgs e)
        {
            if (txtCode.PasswordChar == '*')
            {
                txtCode.PasswordChar = '\0';
                btnShowPass.Image = Properties.Resources.hide;
            }
            else
            {
                txtCode.PasswordChar = '*';
                btnShowPass.Image = Properties.Resources.show;
            }
        }

        private void btnResend_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Random rand = new Random();
            generatedOTP = rand.Next(100000, 999999).ToString();

            SendOtpEmail(email, generatedOTP);

            lblInvalid.Text = "A new Verification Code has been sent to your email.";
            lblInvalid.ForeColor = Color.Green;

            StartCountdown();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (txtCode.Text == generatedOTP)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();

                        string query = "SELECT role FROM Accounts WHERE id = @userId";
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@userId", userId);

                            object result = cmd.ExecuteScalar();

                            if (result != null)
                            {
                                string role = result.ToString();

                                this.Hide();

                                if (role.Equals("SalesRep", StringComparison.OrdinalIgnoreCase))
                                {
                                    MainForm mainForm = new MainForm(userId);
                                    mainForm.Show();
                                }
                                else if (role.Equals("Admin", StringComparison.OrdinalIgnoreCase))
                                {
                                    Main_Admin adminForm = new Main_Admin(userId);
                                    adminForm.Show();
                                }
                                else
                                {
                                    MessageBox.Show("Unknown role detected. Please contact system administrator");
                                    this.Show();
                                }
                            }
                            else
                            {
                                MessageBox.Show("User not found in the Accounts table");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error verifying user role: " + ex.Message);
                }
            }
            else
            {
                lblInvalid.Text = "Invalid Code. Please try again.";
                lblInvalid.ForeColor = Color.Red;
            }
        }

        private void removeVerifyCB_CheckedChanged(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string updateQuery;

                if (removeVerifyCB.Checked)
                {
                    updateQuery = "UPDATE Accounts SET removeVerificationDate = GETDATE() WHERE id = @Id";
                }
                else
                {
                    updateQuery = "UPDATE Accounts SET removeVerificationDate = NULL WHERE id = @Id";
                }

                SqlCommand cmd = new SqlCommand(updateQuery, conn);
                cmd.Parameters.AddWithValue("@Id", userId);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
