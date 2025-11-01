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
    public partial class TransactionLogsUC : UserControl
    {
        private string connectionString = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=AutomotiveDB;Integrated Security=True;";
        private int userId;

        public TransactionLogsUC(int userId)
        {
            InitializeComponent();
            this.userId = userId;
        }

        private void TransactionLogsUC_Load(object sender, EventArgs e)
        {
            LoadTransactionLogs();
        }

        //LOADS DATA
        private void LoadTransactionLogs(string searchText = "")
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
                query += " AND CAST(logID AS VARCHAR) LIKE @search";
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

                    dgvTransactionLog.DataSource = dt;
                    dgvTransactionLog.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
            }
        }


        //BUTTONS

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadTransactionLogs(txtSearchDetails.Text.Trim());
        }

        private void btnViewInformation_Click(object sender, EventArgs e)
        {
            if (dgvTransactionLog.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a transaction to view.");
                return;
            }

            int selectedLogID = Convert.ToInt32(dgvTransactionLog.SelectedRows[0].Cells["Log ID"].Value);
            TransactionDetails detailsForm = new TransactionDetails(selectedLogID);
            detailsForm.ShowDialog();
        }



        private void cbChoicesOfSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dgvTransactionLog_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
