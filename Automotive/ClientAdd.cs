using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using Newtonsoft.Json;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Automotive
{
    public partial class ClientAdd : KryptonForm
    {
        private int userId;
        private int clientId = 0;
        private ClientsUC clientRef;
        private static readonly Random rnd = new Random();
        private string connectionString = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=AutomotiveDB;Integrated Security=True;";
        
        public ClientAdd(int userId)
        {
            InitializeComponent();
            this.userId = userId;
        }


        private int GenerateRandomId(int prefix, int digits)
        {
            int randomPart = rnd.Next(0, (int)Math.Pow(10, digits));
            return prefix * (int)Math.Pow(10, digits) + randomPart;
        }

        private int ValidateAmount(string amount)
        {
            if (!Regex.IsMatch(amount, @"^\d+$"))
                throw new ArithmeticException("Amount must contain only digits.");

            if (string.IsNullOrEmpty(amount))
                throw new ArgumentNullException("Please input an amount");

            return Convert.ToInt32(amount);
        }

        private int ValidateWarranty(string warranty)
        {
            if (!Regex.IsMatch(warranty, @"^\d+$"))
                throw new ArithmeticException("Warranty must contain only digits.");

            if (string.IsNullOrEmpty(warranty))
                throw new ArgumentNullException("Please input a warranty");

            return Convert.ToInt32(warranty);
        }
        // imrpotant
        private void addClient()
        {
            try
            {
                string name = txtName.Text.Trim();
                string vehicle = txtVehicle.Text.Trim();
                string model = txtModel.Text.Trim();
                string img = lblPhoto.Text;

                int clientID = GenerateRandomId(200, 4);
                int logId = GenerateRandomId(500, 4);

                clientId = clientID;

                string jsonData = JsonConvert.SerializeObject(new
                {
                    clientId,
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
                VALUES (@logID, 'Clients', @recordID, 'CREATE', @newData, @userID, 'Pending', GETDATE())";

                    using (SqlCommand cmd = new SqlCommand(insertLogQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@logID", logId);
                        cmd.Parameters.AddWithValue("@recordID", clientId);
                        cmd.Parameters.AddWithValue("@newData", jsonData);
                        cmd.Parameters.AddWithValue("@userID", userId);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Client request submitted for admin approval.");
            }
            catch (Exception ex)
            {
                lblInvalid1.Text = "Error: " + ex.Message;
            }
        }

        //important
        private void addClientHistory()
        {
            try
            {
                if (clientId == 0)
                {
                    lblInvalid2.Text = "Please create a client first.";
                    return;
                }

                string issue = txtIssue.Text.Trim();
                string repairBy = txtRepairedBy.Text.Trim();
                int amount = ValidateAmount(txtAmount.Text.Trim());
                int warranty = ValidateWarranty(txtWarranty.Text.Trim());
                string warrantyDuration = cbWarranty.SelectedItem?.ToString() ?? "";
                DateTime date = dtpDate.Value;

                int receiptId = GenerateRandomId(400, 4);
                int logId = GenerateRandomId(500, 4);

                string jsonData = JsonConvert.SerializeObject(new
                {
                    receiptID = receiptId,
                    clientID = clientId,
                    issue,
                    repairedBy = repairBy,
                    amount,
                    warranty = $"{warranty}{warrantyDuration}",
                    date = date.ToString("yyyy-MM-dd")
                });

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string insertLogQuery = @"
                INSERT INTO Transaction_Log
                (logID, tableName, recordID, actionType, newData, userID, status, dateRequested)
                VALUES (@logID, 'Client_History', @recordID, 'CREATE', @newData, @userID, 'Pending', GETDATE())";

                    using (SqlCommand cmd = new SqlCommand(insertLogQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@logID", logId);
                        cmd.Parameters.AddWithValue("@recordID", receiptId);
                        cmd.Parameters.AddWithValue("@newData", jsonData);
                        cmd.Parameters.AddWithValue("@userID", userId);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Client History request submitted for admin approval.");
            }
            catch (ArgumentNullException ex)
            {
                lblInvalid2.Text = ex.Message;
            }
            catch (Exception ex)
            {
                lblInvalid2.Text = "Unexpected error: " + ex.Message;
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            addClient();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            addClientHistory();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
            openFileDialog.Title = "Select a Photo for New Item";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                lblPhoto.Text = openFileDialog.FileName;
            }
        }
    }
}
