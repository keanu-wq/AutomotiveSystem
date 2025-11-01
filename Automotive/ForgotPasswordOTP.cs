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
    public partial class ForgotPasswordOTP : KryptonForm
    {
        private string connectionString = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=AutomotiveDB;Integrated Security=True;";
        private string generatedOTP;
        int timeLeft = 60;
        private bool isOtpPhase = false;
        private int userId;
        private string emailText;
        public ForgotPasswordOTP(string emailText)
        {
            InitializeComponent();
            this.emailText = emailText;
        }

        private void SendOtpEmail(string toEmail, string otp)
        {
            try
            {
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress("jdrodilas24@gmail.com");
                mail.To.Add(toEmail);
                mail.Subject = "Change Password Code";
                mail.Body = $"Your Change Password One-Time Passcode is: {otp}";

                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                smtp.Credentials = new NetworkCredential("jdrodilas24@gmail.com", "tdji gbzp jtcr kvel");
                smtp.EnableSsl = true;

                smtp.Send(mail);

                MessageBox.Show("OTP has been sent to your email.");
                lblInvalid.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error sending email: " + ex.Message);
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

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (!isOtpPhase)
            {
                string email = txtCode.Text;

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string checkUserQuery = "SELECT id FROM Accounts WHERE email = @Email";
                    SqlCommand checkUserCmd = new SqlCommand(checkUserQuery, conn);
                    checkUserCmd.Parameters.AddWithValue("@Email", email);

                    SqlDataReader reader = checkUserCmd.ExecuteReader();

                    if (reader.Read())
                    {
                        userId = Convert.ToInt32(reader["id"]);
                        isOtpPhase = true;

                        label2.Text = "Code";
                        txtCode.Clear();
                        txtCode.PasswordChar = '*';

                        btnShowPass.Visible = true;
                        lblResend.Visible = true;
                        lblTimer.Visible = true;
                        btnResend.Visible = true;

                        btnEnter.Text = "Enter";

                        btnResend.Enabled = false;
                        StartCountdown();

                        Random rand = new Random(userId);
                        generatedOTP = rand.Next(100000, 999999).ToString();

                        SendOtpEmail(email, generatedOTP);
                    }
                    else
                    {
                        lblInvalid.Text = "Invalid Email";
                    }
                }
            }
            else
            {
                string enteredOtp = txtCode.Text;

                if (enteredOtp == generatedOTP)
                {
                    MessageBox.Show("OTP Verified! You may now change your password.");

                    this.Hide();
                    new ResetPassword(userId).Show();
                }
                else
                {
                    lblInvalid.Text = "Invalid Code";
                }
            }
        }

        private void btnResend_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (isOtpPhase)
            {
                Random rand = new Random();
                generatedOTP = rand.Next(100000, 999999).ToString();
                SendOtpEmail(txtCode.Text, generatedOTP);
                StartCountdown();
            }
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

        private void btnBack_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void ForgotPasswordOTP_Load(object sender, EventArgs e)
        {
            this.AcceptButton = btnEnter;

            txtCode.Text = emailText;
        }
    }
}
