using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using System.IO;

namespace Automotive
{
    public partial class TransactionDetails : Form
    {
        private string connectionString = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=AutomotiveDB;Integrated Security=True;";
        private int userId;
        public TransactionDetails(int userId)
        {
            InitializeComponent();
            this.userId = userId;

            this.Load += new System.EventHandler(this.TransactionDetails_Load);

            
        }

        private void TransactionDetails_Load(object sender, EventArgs e)
        {
            LoadTransactionDetails();
        }

        private void LoadTransactionDetails()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(this.connectionString))
                {
                    conn.Open();

                    string query = "SELECT * FROM Transaction_Log WHERE logID = @logID";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@logID", userId);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (!reader.Read())
                            {
                                MessageBox.Show("No transaction found for this Log ID.", "Not found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return;
                            }

                            // Basic transaction info
                            lblID.Text = reader["logID"]?.ToString() ?? "";
                            lblActionType.Text = reader["actionType"]?.ToString() ?? "";
                            lblDateRequested.Text = reader["dateRequested"] != DBNull.Value
                                ? Convert.ToDateTime(reader["dateRequested"]).ToString("yyyy-MM-dd HH:mm")
                                : "";

                            // Clear picture first
                            pbTransactionImage.Image = null;

                            string oldDataJson = FixJsonFormat(reader["oldData"]?.ToString());
                            string newDataJson = FixJsonFormat(reader["newData"]?.ToString());

                            // --- OLD DATA ---
                            DisplayTransactionData(oldDataJson, true);

                            // --- NEW DATA ---
                            DisplayTransactionData(newDataJson, false);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading transaction details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private string FixJsonFormat(string json)
        {
            if (string.IsNullOrEmpty(json)) return json;
            json = json.Trim();

            // If already valid JSON, skip
            if (json.StartsWith("{") && json.Contains("\"")) return json;

            // Add quotes around keys
            json = System.Text.RegularExpressions.Regex.Replace(
                json,
                @"(?<={|,)(\s*)([A-Za-z0-9_]+)(\s*):",
                "\"$2\":"
            );

            return json;
        }

        // Helper: Display either old or new data
        private void DisplayTransactionData(string jsonData, bool isOld)
        {
            Label lblIDField = isOld ? lblOldLogID : lblNewLogID;
            Label lblNameField = isOld ? lblOldActionType : lblNewActionType;
            Label lblStatusField = isOld ? lblOldStatus : lblNewStatus;
            Label lblDateField = isOld ? lblOldDateRequested : lblNewDateRequested;

            if (string.IsNullOrEmpty(jsonData) || jsonData == "N/A")
            {
                lblIDField.Text = lblNameField.Text = lblStatusField.Text = lblDateField.Text = "N/A";
                return;
            }

            try
            {
                JObject data = JObject.Parse(jsonData);

                // ITEM
                if (data.ContainsKey("itemID"))
                {
                    lblIDField.Text = data["itemID"]?.ToString() ?? "";
                    lblNameField.Text = data["itemName"]?.ToString() ?? "";
                    lblStatusField.Text = data["price"]?.ToString() ?? "";
                    lblDateField.Text = data["stock"]?.ToString() ?? "";

                    string imgPath = data["itemImage"]?.ToString();
                    LoadImageSafe(imgPath);
                }
                // CLIENT
                else if (data.ContainsKey("clientID") && data.ContainsKey("vehicle"))
                {
                    lblIDField.Text = data["clientID"]?.ToString() ?? "";
                    lblNameField.Text = data["name"]?.ToString() ?? "";
                    lblStatusField.Text = data["vehicle"]?.ToString() ?? "";
                    lblDateField.Text = data["model"]?.ToString() ?? "";

                    string imgPath = data["vehiclePhoto"]?.ToString();
                    LoadImageSafe(imgPath);
                }
                // CLIENT HISTORY / RECEIPT
                else if (data.ContainsKey("receiptID"))
                {
                    lblIDField.Text = data["receiptID"]?.ToString() ?? "";
                    lblNameField.Text = data["issue"]?.ToString() ?? "";
                    lblStatusField.Text = data["amount"]?.ToString() ?? "";
                    lblDateField.Text = data["warranty"]?.ToString() ?? "";
                    // No image for receipt
                }
                else
                {
                    lblIDField.Text = lblNameField.Text = lblStatusField.Text = lblDateField.Text = "Unknown format";
                }
            }
            catch
            {
                lblIDField.Text = lblNameField.Text = lblStatusField.Text = lblDateField.Text = "Invalid JSON";
            }
        }
        // This is just a helper example in case your newData contains an image path
        private void LoadImageSafe(string imgPath)
        {
            if (!string.IsNullOrEmpty(imgPath) && File.Exists(imgPath))
                pbTransactionImage.Image = Image.FromFile(imgPath);
            else
                pbTransactionImage.Image = null;
        }
    }
}
