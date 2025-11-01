using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using ComponentFactory.Krypton.Toolkit;
using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace Automotive
{
    public partial class OTPForm : KryptonForm
    {
        private string connectionString = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=AutomotiveDB;Integrated Security=True;";
        private SignUp signUp;
        private string generatedOTP;
        int timeLeft = 60;
        public OTPForm(SignUp signUp)
        {
            InitializeComponent();
            this.signUp = signUp;
        }

        private void SendOtpEmail(string toEmail, string otp)
        {
            try
            {
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress("jdrodilas24@gmail.com");
                mail.To.Add(toEmail);
                mail.Subject = "Your OTP Code";
                mail.Body = $"Your One-Time Passcode is: {otp}";

                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                smtp.Credentials = new NetworkCredential("jdrodilas24@gmail.com", "tdji gbzp jtcr kvel");
                smtp.EnableSsl = true;

                smtp.Send(mail);

                MessageBox.Show("OTP has been sent to your email.");
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

        private void timer1_Tick_1(object sender, EventArgs e)
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

        private void OTPForm_Load(object sender, EventArgs e)
        {
            this.AcceptButton = btnEnter;

            btnResend.Enabled = false;
            StartCountdown();

            Random rand = new Random();
            generatedOTP = rand.Next(100000, 999999).ToString();

            SendOtpEmail(signUp._email, generatedOTP);
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            //If the inputted OTP is correct. Proceed to login
            if (txtCode.Text == generatedOTP)
            {
                // OTP is correct - just verify email and proceed
                MessageBox.Show("Email verified successfully!\n\nYour account is now ready to use.");
                this.Hide();
                new Login().Show();
            }
            else
            {
                lblInvalid.Text = "Invalid OTP. Please try again.";
            }
        }

        private void btnResend_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Random rand = new Random();
            generatedOTP = rand.Next(100000, 999999).ToString();

            SendOtpEmail(signUp._email, generatedOTP);

            MessageBox.Show("A new OTP has been sent to your email.");

            StartCountdown();
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
    }
}
