using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

namespace Automotive
{
    public partial class SignUpRequest : KryptonForm
    {
        private String code;
        public SignUpRequest()
        {
            InitializeComponent();
            code = "12345";
        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
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

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (txtPass.Text.Trim() == code)
            {
                SignUp signUp = new SignUp();
                signUp.Show();
                this.Hide();
            }
            else
                lblInvalid.Text = "Invalid Code";
        }

        private void SignUpRequest_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void SignUpRequest_Load(object sender, EventArgs e)
        {
            this.AcceptButton = btnEnter;
        }
    }
}
