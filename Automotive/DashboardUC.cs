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
    public partial class DashboardUC : UserControl
    {
        private int userId;
        private string connectionString = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=AutomotiveDB;Integrated Security=True;";
        public DashboardUC(int userId)
        {
            InitializeComponent();
            this.userId = userId;
            this.AutoScroll = true;
        }

        private void DashboardUC_Load(object sender, EventArgs e)
        {
            LoadDashBoardData();
        }

        public void LoadDashBoardData()
        {
            loadLowStock();
            loadClientInfoPending();
            LoadClientHistoryPending();
        }



        private void loadLowStock()
        {
            string query = @"
                            SELECT itemID as 'ID', itemName as 'Name', stock as 'Stock(s)'
                            FROM Items
                            WHERE stock <= 5";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    SqlDataAdapter sda = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);

                    dgvLowStock.DataSource = dt;
                    dgvLowStock.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void loadClientInfoPending()
        {
            string query = @"
                SELECT 
                    t.logID AS 'Log ID',
                    t.actionType AS 'Action Type',
                    t.recordID as 'Record ID',
                    t.dateRequested AS 'Date Requested'
                FROM Transaction_Log t
                INNER JOIN Accounts a ON t.UserID = a.id
                WHERE t.tableName = 'Clients' AND t.Status = 'Pending'
                ORDER BY t.dateRequested DESC";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        

                        SqlDataAdapter sda = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);

                        dgvClientInfo.DataSource = dt;
                        dgvClientInfo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        dgvClientHistory.ReadOnly = true;
                        dgvClientHistory.ClearSelection();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void LoadClientHistoryPending()
        {
            string query = @"
                SELECT 
                    t.logID AS 'Log ID',
                    t.actionType AS 'Action Type',
                    t.recordID AS 'Record ID',
                    t.dateRequested AS 'Date Requested'
                FROM Transaction_Log t
                INNER JOIN Accounts a ON t.userID = a.id
                WHERE t.tableName = 'Client_History' AND t.status = 'Pending'
                ORDER BY t.dateRequested DESC";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        SqlDataAdapter sda = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);

                        dgvClientHistory.DataSource = dt;
                        dgvClientHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }


        

        private void dgvLowStock_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvClientInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvClientHistory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
