using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Automotive
{
    public partial class MainForm : KryptonForm
    {
        private string connectionString = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=AutomotiveDB;Integrated Security=True;";
        private int userId;
        private int idleTime;
        private string currentTab;
        public MainForm(int userId)
        {
            InitializeComponent();
            this.userId = userId;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            idleTime++;

            if (idleTime >= 1500)
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
            btn.StateCommon.Back.Color1 = Color.CornflowerBlue;
            btn.StateCommon.Back.Color2 = Color.CornflowerBlue;
            btn.OverrideDefault.Back.Color1 = Color.CornflowerBlue;
            btn.OverrideDefault.Back.Color2 = Color.CornflowerBlue;
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
            else if (pic == picStorage)
            {
                pic.Image = Properties.Resources.storage_box_White;
            }
            else if (pic == picCustomers)
            {
                pic.Image = Properties.Resources.people_White;
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
            else if (pic == picTransaction)
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
            else if (pic == picStorage)
            {
                pic.Image = Properties.Resources.storage_box;
            }
            else if (pic == picCustomers)
            {
                pic.Image = Properties.Resources.people;
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
            else if (pic == picTransaction)
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
            else if (currentTab == "Storage")
            {
                mouseLeaveRevertColor(btnStorage, picStorage);
            }
            else if (currentTab == "Customers")
            {
                mouseLeaveRevertColor(btnClients, picCustomers);
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

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            idleTime = 0;

            timer1.Tick += timer1_Tick;
            timer1.Start();

            this.MouseMove += new MouseEventHandler(UserActivity);
            this.KeyDown += new KeyEventHandler(UserActivity);
            this.MouseClick += new MouseEventHandler(UserActivity);
            LoadNameFromDatabase();

            mouseHoverChangeColor(btnDashboard, picHome);

            DashboardUC dashboardUC = new DashboardUC(userId);
            dashboardUC.Dock = DockStyle.Fill;
            UCHolder.Controls.Add(dashboardUC);

            currentTab = "Dashboard";
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

        private void btnHome_MouseEnter(object sender, EventArgs e)
        {
            if (currentTab == "Dashboard")
                return;
            else
                mouseHoverChangeColor(btnDashboard, picHome);
        }

        private void btnHome_MouseLeave_1(object sender, EventArgs e)
        {
            if (currentTab == "Dashboard")
                return;
            else
                mouseLeaveRevertColor(btnDashboard, picHome);
        }

        private void btnStorage_MouseEnter(object sender, EventArgs e)
        {
            if (currentTab == "Storage")
                return;
            else
                mouseHoverChangeColor(btnStorage, picStorage);
        }

        private void btnStorage_MouseLeave(object sender, EventArgs e)
        {
            if (currentTab == "Storage")
                return;
            else
                mouseLeaveRevertColor(btnStorage, picStorage);
        }

        private void btnCustomers_MouseEnter(object sender, EventArgs e)
        {
            if (currentTab == "Customers")
                return;
            else
                mouseHoverChangeColor(btnClients, picCustomers);
        }

        private void btnCustomers_MouseLeave(object sender, EventArgs e)
        {
            if (currentTab == "Customers")
                return;
            else
                mouseLeaveRevertColor(btnClients, picCustomers);
        }

        private void btnTransactionLogs_MouseEnter(object sender, EventArgs e)
        {
            if (currentTab == "Transaction Logs")
                return;
            else
                mouseHoverChangeColor(btnTransactionLogs, picTransaction);
        }

        private void btnTransactionLogs_MouseLeave(object sender, EventArgs e)
        {
            if (currentTab == "Transaction Logs")
                return;
            else
                mouseLeaveRevertColor(btnTransactionLogs, picTransaction);
        }

        private void btnReports_MouseEnter(object sender, EventArgs e)
        {
            if (currentTab == "Reports")
                return;
            else
                mouseHoverChangeColor(btnReports, picReports);
        }

        private void btnReports_MouseLeave(object sender, EventArgs e)
        {
            if (currentTab == "Reports")
                return;
            else
                mouseLeaveRevertColor(btnReports, picReports);
        }

        private void btnSettings_MouseEnter(object sender, EventArgs e)
        {
            if (currentTab == "Settings")
                return;
            else
                mouseHoverChangeColor(btnSettings, picSettings);
        }

        private void btnSettings_MouseLeave(object sender, EventArgs e)
        {
            if (currentTab == "Settings")
                return;
            else
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

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            if (currentTab == "Dashboard")
                return;
            else
            {
                revertToOriginalColor();
                currentTab = "Dashboard";
                mouseHoverChangeColor(btnDashboard, picHome);

                DashboardUC dashboardUC = new DashboardUC(userId);
                dashboardUC.Dock = DockStyle.Fill;
                UCHolder.Controls.Clear();
                UCHolder.Controls.Add(dashboardUC);
            }

        }

        private void btnStorage_Click(object sender, EventArgs e)
        {
            if (currentTab == "Storage")
                return;
            else
            {
                revertToOriginalColor();
                currentTab = "Storage";
                mouseHoverChangeColor(btnStorage, picStorage);

                StorageUC storageUC = new StorageUC(userId);
                storageUC.Dock = DockStyle.Fill;
                UCHolder.Controls.Clear();
                UCHolder.Controls.Add(storageUC);
            }
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            if (currentTab == "Customers")
                return;
            else
            {
                revertToOriginalColor();
                currentTab = "Customers";
                mouseHoverChangeColor(btnClients, picCustomers);

                ClientsUC clientTab = new ClientsUC(userId);
                clientTab.Dock = DockStyle.Fill;
                UCHolder.Controls.Clear();
                UCHolder.Controls.Add(clientTab);
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

                TransactionLogsUC transactionLogTab = new TransactionLogsUC(userId);
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

                ReportsUC reports = new ReportsUC();
                reports.Dock = DockStyle.Fill;
                UCHolder.Controls.Clear();
                UCHolder.Controls.Add(reports);
            }
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            if (currentTab == "Settings")
                return;
            else
            {
                revertToOriginalColor();
                currentTab = "Settings";
                mouseHoverChangeColor(btnSettings, picSettings);

                SettingsTabUC settingsTab = new SettingsTabUC(userId);
                settingsTab.Dock = DockStyle.Fill;
                UCHolder.Controls.Clear();
                UCHolder.Controls.Add(settingsTab);
            }
        }

        private void UCHolder_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
