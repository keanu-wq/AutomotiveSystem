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

namespace Automotive
{
    public partial class Main_Admin : KryptonForm
    {
        private string connectionString = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=AutomotiveDB;Integrated Security=True;";
        private int userId;
        private int idleTime;
        private string currentTab;
        public Main_Admin(int userId)
        {
            InitializeComponent();
            this.userId = userId;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            idleTime++;

            if (idleTime >= 300)
            {
                timer1.Stop();

                MessageBox.Show
                (
                    "You have been logged out due to inactivity.",
                    "Session Timeout",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                this.Hide();
                Login login = new Login();
                login.Show();
            }
        }
        private void LoadNameFromDatabase()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = "SELECT name FROM Accounts WHERE id = @id";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", userId);

                        object result = cmd.ExecuteScalar();

                        if (result != null)
                        {
                            lblName.Text = result.ToString();
                        }
                        else
                        {
                            lblName.Text = "User not found";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading name: " + ex.Message);
            }
        }

       
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            idleTime++;

            if (idleTime >= 300)
            {
                timer1.Stop();

                MessageBox.Show
                (
                    "You have been logged out due to inactivity.",
                    "Session Timeout",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                this.Hide();
                Login login = new Login();
                login.Show();
            }
        }
       

        private void mouseHoverChangeColor(KryptonButton btn, PictureBox pic)
        {
            btn.StateCommon.Back.Color1 = Color.Black;
            btn.StateCommon.Back.Color2 = Color.Black;
            btn.OverrideDefault.Back.Color1 = Color.Black;
            btn.OverrideDefault.Back.Color2 = Color.Black;
            btn.StateCommon.Content.ShortText.Color1 = Color.White;
            btn.StateCommon.Content.ShortText.Color2 = Color.White;
            btn.OverrideDefault.Content.ShortText.Color1 = Color.White;
            btn.OverrideDefault.Content.ShortText.Color2 = Color.White;
            btn.Invalidate();

            if (pic.Parent != btn)
            {
                Point relativePoint = this.PointToClient(pic.PointToScreen(Point.Empty));
                relativePoint = btn.PointToClient(this.PointToScreen(pic.Location));

                pic.Parent = btn;
                pic.Location = relativePoint;
            }

            if (pic == picHome)
            {
                pic.Image = Properties.Resources.home_White;
            }
            else if (pic == picApproval)
            {
                pic.Image = Properties.Resources.approval_white;
            }
            else if (pic == picAccounts)
            {
                pic.Image = Properties.Resources.account_white;
            }
            else if (pic == picSettings)
            {
                pic.Image = Properties.Resources.settings_white;
            }
            else if (pic == picLogout)
            {
                pic.Image = Properties.Resources.power_white;
            }
            else if (pic == picTransaction)
            {
                pic.Image = Properties.Resources.transactionlog_white;
            }
            else if (pic == picReports)
            {
                pic.Image = Properties.Resources.report_white;
            }
        }

         private void mouseLeaveRevertColor(KryptonButton btn, PictureBox pic)
        {
            btn.StateCommon.Back.Color1 = Color.White;
            btn.StateCommon.Back.Color2 = Color.White;
            btn.OverrideDefault.Back.Color1 = Color.White;
            btn.OverrideDefault.Back.Color2 = Color.White;
            btn.StateCommon.Content.ShortText.Color1 = Color.FromArgb(82, 82, 82);
            btn.StateCommon.Content.ShortText.Color2 = Color.FromArgb(82, 82, 82);
            btn.OverrideDefault.Content.ShortText.Color1 = Color.FromArgb(82, 82, 82);
            btn.OverrideDefault.Content.ShortText.Color2 = Color.FromArgb(82, 82, 82);
            btn.Invalidate();

            if (pic == picHome)
            {
                pic.Image = Properties.Resources.home;
            }
            else if (pic == picApproval)
            {
                pic.Image = Properties.Resources.approval;
            }
            else if (pic == picAccounts)
            {
                pic.Image = Properties.Resources.account;
            }
            else if (pic == picSettings)
            {
                pic.Image = Properties.Resources.settings;
            }
            else if (pic == picLogout)
            {
                pic.Image = Properties.Resources.power;
            }
            else if (pic == picTransaction)
            {
                pic.Image = Properties.Resources.transactionlog;
            }
            else if (pic == picReports)
            {
                pic.Image = Properties.Resources.report;
            }
        }

        private void revertToOriginalColor()
        {
            if (currentTab == "Dashboard")
            {
                mouseLeaveRevertColor(btnDashboard, picHome);
            }
            else if (currentTab == "Approvals")
            {
                mouseLeaveRevertColor(btnApprovals, picApproval);
            }
            else if (currentTab == "Accounts")
            {
                mouseLeaveRevertColor(btnAccounts, picAccounts);
            }
            else if (currentTab == "Transaction Logs")
            {
                mouseLeaveRevertColor(btnTransactionLogs, picTransaction);
            }
            else if (currentTab == "Reports")
            {
                mouseLeaveRevertColor(btnReports, picReports);
            }
            else if (currentTab == "Settings")
            {
                mouseLeaveRevertColor(btnSettings, picSettings);
            }
        }

        private void UserActivity(object sender, EventArgs e)
        {
            idleTime = 0;
        }

        private void Main_Admin_Load(object sender, EventArgs e)
        {
            idleTime = 0;

            timer1.Tick += timer1_Tick;
            timer1.Start();

            this.MouseMove += new MouseEventHandler(UserActivity);
            this.KeyDown += new KeyEventHandler(UserActivity);
            this.MouseClick += new MouseEventHandler(UserActivity);

            LoadNameFromDatabase();

            // Default tab
            currentTab = "Dashboard";
            mouseHoverChangeColor(btnDashboard, picHome);

            // Load default UC
            DashBoardAdminUC dashboard = new DashBoardAdminUC(userId);
            dashboard.Dock = DockStyle.Fill;
            UCHolder.Controls.Add(dashboard);
        }

        private void btnDashboard_MouseEnter(object sender, EventArgs e)
        {
            mouseHoverChangeColor(btnDashboard, picHome);
        }

        private void btnDashboard_MouseLeave(object sender, EventArgs e)
        {
            mouseLeaveRevertColor(btnDashboard, picHome);
        }

        private void btnApprovals_MouseEnter(object sender, EventArgs e)
        {
            mouseHoverChangeColor(btnApprovals, picApproval);
        }

        private void btnApprovals_MouseLeave(object sender, EventArgs e)
        {
            mouseLeaveRevertColor(btnApprovals, picApproval);
        }

        private void btnTransactionLogs_MouseEnter(object sender, EventArgs e)
        {
            mouseHoverChangeColor(btnTransactionLogs, picTransaction);
        }

        private void btnTransactionLogs_MouseLeave(object sender, EventArgs e)
        {
            mouseLeaveRevertColor(btnTransactionLogs, picTransaction);
        }

        private void btnReports_MouseEnter(object sender, EventArgs e)
        {
            mouseHoverChangeColor(btnReports, picReports);
        }

        private void btnReports_MouseLeave(object sender, EventArgs e)
        {
            mouseLeaveRevertColor(btnReports, picReports);
        }

        private void btnAccounts_MouseEnter(object sender, EventArgs e)
        {
            mouseHoverChangeColor(btnAccounts, picAccounts);
        }

        private void btnAccounts_MouseLeave(object sender, EventArgs e)
        {
            mouseLeaveRevertColor(btnAccounts, picAccounts);
        }

        private void btnSettings_MouseEnter(object sender, EventArgs e)
        {
            mouseHoverChangeColor(btnSettings, picSettings);
        }

        private void btnSettings_MouseLeave(object sender, EventArgs e)
        {
            mouseLeaveRevertColor(btnSettings, picSettings);
        }

        private void btnLogout_MouseEnter(object sender, EventArgs e)
        {
            mouseHoverChangeColor(btnLogout, picLogout);
        }

        private void btnLogout_MouseLeave(object sender, EventArgs e)
        {
            mouseLeaveRevertColor(btnLogout, picLogout);
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            if (currentTab == "Dashboard") return;

            revertToOriginalColor();
            currentTab = "Dashboard";
            mouseHoverChangeColor(btnDashboard, picHome);

            DashBoardAdminUC dashBoardAdminUC = new DashBoardAdminUC(userId);
            dashBoardAdminUC.Dock = DockStyle.Fill;
            UCHolder.Controls.Clear();
            UCHolder.Controls.Add(dashBoardAdminUC);
        }

        private void btnApprovals_Click(object sender, EventArgs e)
        {
            if (currentTab == "Approvals")
                return;
            else
            {
                revertToOriginalColor();
                currentTab = "Approvals";
                mouseHoverChangeColor(btnApprovals, picApproval);

                ApprovalsUC approvalUC = new ApprovalsUC(userId);
                approvalUC.Dock = DockStyle.Fill;
                UCHolder.Controls.Clear();
                UCHolder.Controls.Add(approvalUC);
            }
        }


        private void btnTransactionLogs_Click(object sender, EventArgs e)
        {
            if (currentTab == "Transaction Logs")
                return;
            else
            {
                revertToOriginalColor();
                currentTab = "Transaction Logs";
                mouseHoverChangeColor(btnTransactionLogs, picTransaction);

                TransactionLogADMINUC transactionLogTab = new TransactionLogADMINUC(userId);
                transactionLogTab.Dock = DockStyle.Fill;
                UCHolder.Controls.Clear();
                UCHolder.Controls.Add(transactionLogTab);
            }
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            if (currentTab == "Reports")
                return;
            else
            {
                revertToOriginalColor();
                currentTab = "Reports";
                mouseHoverChangeColor(btnReports, picReports);

                ReportsAdminUC transactionLogTab = new ReportsAdminUC(userId);
                transactionLogTab.Dock = DockStyle.Fill;
                UCHolder.Controls.Clear();
                UCHolder.Controls.Add(transactionLogTab);
            }
        }
        private void btnAccounts_Click(object sender, EventArgs e)
        {
            if (currentTab == "Accounts")
                return;
            else
            {
                revertToOriginalColor();
                currentTab = "Accounts";
                mouseHoverChangeColor(btnAccounts, picAccounts);

                AccountsAdminUC accountsTab = new AccountsAdminUC(userId);
                accountsTab.Dock = DockStyle.Fill;
                UCHolder.Controls.Clear();
                UCHolder.Controls.Add(accountsTab);
            }
        }



        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show
            (
                "Are you sure you want to log out?",
                "Logout Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                Properties.Settings.Default.RememberMe = false;
                Properties.Settings.Default.RememberedUserId = -1;
                Properties.Settings.Default.Save();

                this.Hide();
                new Login().Show();
            }
        }

        private void Main_Admin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();  
        }

        
    }
}
