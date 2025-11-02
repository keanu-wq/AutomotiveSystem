using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Automotive
{
    public partial class AccountsAdminUC : UserControl
    {
        private string connectionString = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=AutomotiveDB;Integrated Security=True;";
        private int userId;


        public AccountsAdminUC(int UserId)
        {
            InitializeComponent();
            this.userId = UserId;
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {

        }


        // btnDeleteUser
        private void kryptonButton1_Click(object sender, EventArgs e) // btnDeleteUser
        {

        }
    }
}
