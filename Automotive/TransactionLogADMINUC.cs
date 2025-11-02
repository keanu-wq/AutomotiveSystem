using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.Design;
using System.Windows.Forms;

namespace Automotive
{
    public partial class TransactionLogADMINUC : UserControl
    {
        private string connectionString = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=AutomotiveDB;Integrated Security=True;";
        private int userId;
        public TransactionLogADMINUC(int userid)
        {
            InitializeComponent();
            this.userId = userid;

            txtSearchDetailsAdmin.KeyDown += TxtSearchDetailsAdmin_KeyDown;
        }

        private void TxtSearchDetailsAdmin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // prevents ding sound
                LoadTransactionLogsAdmin(txtSearchDetailsAdmin.Text.Trim());
            }
        }
        private void TransactionLogADMINUC_Load(object sender, EventArgs e)
        {
         LoadTransactionLogsAdmin();   
        }

        private void LoadTransactionLogsAdmin(string searchText = "")
        {
            string query = @"
                SELECT logID AS [Log ID],
                       actionType AS [Action Type],
                       status AS [Status],
                       dateRequested AS [Date Requested]
                FROM Transaction_Log
                WHERE 1=1";

            if (!string.IsNullOrEmpty(searchText))
            {
                query += @" AND (
                    CAST(logID AS VARCHAR) LIKE @search OR
                    actionType LIKE @search OR
                    status LIKE @search OR
                    CONVERT(VARCHAR, dateRequested, 120) LIKE @search
                )";
            }

            query += " ORDER BY dateRequested DESC";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    if (!string.IsNullOrEmpty(searchText))
                        cmd.Parameters.AddWithValue("@search", "%" + searchText + "%");

                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);

                    dgvTransactionLogAdmin.DataSource = dt;
                    dgvTransactionLogAdmin.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
            }
        }

        private void btnAdminSearch_Click(object sender, EventArgs e)
        {
            LoadTransactionLogsAdmin(txtSearchDetailsAdmin.Text.Trim());
        }

        private void btnViewInfoAdmin_Click(object sender, EventArgs e)
        {
            if (dgvTransactionLogAdmin.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a transaction to view.");
                return;
            }

            int selectedLogID = Convert.ToInt32(dgvTransactionLogAdmin.SelectedRows[0].Cells["Log ID"].Value);
            TransactionDetails detailsForm = new TransactionDetails(selectedLogID);
            detailsForm.ShowDialog();
        }

        
    }
}
