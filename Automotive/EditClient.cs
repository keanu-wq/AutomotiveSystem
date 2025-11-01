using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using ComponentFactory.Krypton.Toolkit;
using Newtonsoft.Json;

namespace Automotive
{
    public partial class EditClient : KryptonForm
    {
        private string clientId;
        private int userId;
        private static readonly Random rnd = new Random();
        private string connectionString = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=AutomotiveDB;Integrated Security=True;";

        public EditClient(int userId, string clientID)
        {
            InitializeComponent();
            this.userId = userId;
            this.clientId = clientID;
            
        }

        private void LoadInfo()
        {
            string infoQuery = "SELECT clientID, name, vehicle, model, vehiclePhoto FROM Clients WHERE clientID = @clientID";

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

        private int GenerateRandomId(int prefix, int digits)
        {
            int randomPart = rnd.Next(0, (int)Math.Pow(10, digits));
            return prefix * (int)Math.Pow(10, digits) + randomPart;
        }

        private void editClient()
        {
            try
            {
                string name = string.IsNullOrWhiteSpace(txtName.Text) ? null : txtName.Text.Trim();
                string vehicle = string.IsNullOrWhiteSpace(txtVehicle.Text) ? null : txtVehicle.Text.Trim();
                string model = string.IsNullOrWhiteSpace(txtModel.Text) ? null : txtModel.Text.Trim();
                string img = string.IsNullOrWhiteSpace(lblVehiclePhoto.Text) ? null : lblVehiclePhoto.Text;

                int clientID = Convert.ToInt32(clientId);
                int logId = GenerateRandomId(500, 4);

                string jsonData = JsonConvert.SerializeObject(new
                {
                    clientID = clientID,
                    name,
                    vehicle,
                    model,
                    vehiclePhoto = img
                });

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string insertLogQuery = @"
                                            INSERT INTO Transaction_Log
                                            (logID, tableName, recordID, actionType, newData, userID, status, dateRequested)
                                            VALUES (@logID, 'Clients', @recordID, 'EDIT', @newData, @userID, 'Pending', GETDATE())";

                    using (SqlCommand cmd = new SqlCommand(insertLogQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@logID", logId);
                        cmd.Parameters.AddWithValue("@recordID", clientID);
                        cmd.Parameters.AddWithValue("@newData", jsonData);
                        cmd.Parameters.AddWithValue("@userID", userId);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Client edit request submitted for admin approval.");
            }
            catch (Exception ex)
            {
                lblInvalid1.Text = "Error: " + ex.Message;
            }
        }

        private void EditClient_Load(object sender, EventArgs e)
        {
            LoadInfo();
            LoadHistory();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
            openFileDialog.Title = "Select a Photo for New Item";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                lblVehiclePhoto.Text = openFileDialog.FileName;
            }
        }

        private void btnEditConfirm_Click(object sender, EventArgs e)
        {
            editClient();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (clientId.Equals("0"))
                return;

            EditClientAddHistory add = new EditClientAddHistory(userId, Convert.ToInt32(clientId));
            add.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvClientHistory.CurrentRow == null)
            {
                MessageBox.Show("Please select a record to edit");
                return;
            }

            try
            {
                int receiptID = Convert.ToInt32(dgvClientHistory.CurrentRow.Cells["Receipt ID"].Value);

                EditClientEditHistory editForm = new EditClientEditHistory(userId, receiptID, Convert.ToInt32(clientId));
                editForm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving receipt ID: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
