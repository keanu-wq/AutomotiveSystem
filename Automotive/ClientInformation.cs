using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Automotive
{
    public partial class ClientInformation : KryptonForm
    {
        private string clientId;
        private string connectionString = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=AutomotiveDB;Integrated Security=True;";
        public ClientInformation(string clientId)
        {
            InitializeComponent();
            this.clientId = clientId;
        }

        private void LoadInfo()
        {
            string infoQuery = "SELECT clientID, name, vehicle, model, vehiclePhoto FROM Clients WHERE clientID = @clientID";
            string historyQuery = @"SELECT 
                                    MIN([date]) AS OldestDate, 
                                    MAX([date]) AS LatestDate
                                    FROM Client_History 
                                    WHERE clientID = @clientID";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand(infoQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@clientID", clientId);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                lblID.Text = reader["clientID"].ToString();
                                lblName.Text = reader["name"].ToString();
                                lblVehicle.Text = reader["vehicle"].ToString();
                                lblModel.Text = reader["model"].ToString();

                                if (reader["vehiclePhoto"] != DBNull.Value)
                                {
                                    string imgPath = reader["vehiclePhoto"].ToString();
                                    if (File.Exists(imgPath))
                                    {
                                        picVehicle.Image = Image.FromFile(imgPath);
                                    }
                                    else
                                    {
                                        picVehicle.Image = null;
                                    }
                                }
                                else
                                {
                                    picVehicle.Image = null;
                                }
                            }
                            else
                            {
                                MessageBox.Show("Client not found.");
                                return;
                            }
                        }
                    }

                    using (SqlCommand cmdHistory = new SqlCommand(historyQuery, conn))
                    {
                        cmdHistory.Parameters.AddWithValue("@clientID", clientId);

                        using (SqlDataReader reader = cmdHistory.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                if (reader["OldestDate"] != DBNull.Value)
                                    lblClientSince.Text = Convert.ToDateTime(reader["OldestDate"]).ToString("yyyy-MM-dd");
                                else
                                    lblClientSince.Text = "N/A";

                                if (reader["LatestDate"] != DBNull.Value)
                                    lblLatest.Text = Convert.ToDateTime(reader["LatestDate"]).ToString("yyyy-MM-dd");
                                else
                                    lblLatest.Text = "N/A";
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading client information: " + ex.Message);
            }
        }

        private void LoadHistory()
        {
            string query = @"SELECT receiptID as 'Receipt ID', issue as Issue, repairedBy as 'Repaired By', amount as Amount, warranty as Warranty, [date] as Date
                     FROM Client_History
                     WHERE clientID = @clientID
                     ORDER BY [date] DESC";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@clientID", clientId);

                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            DataTable historyTable = new DataTable();
                            adapter.Fill(historyTable);

                            dgvClientHistory.DataSource = historyTable;
                        }
                    }
                }

                dgvClientHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvClientHistory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvClientHistory.ReadOnly = true;
                dgvClientHistory.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading client history: " + ex.Message);
            }
        }

        private void ClientInformation_Load(object sender, EventArgs e)
        {
            LoadInfo();
            LoadHistory();
        }
    }
}
