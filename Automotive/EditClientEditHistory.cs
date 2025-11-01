using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using Newtonsoft.Json;

namespace Automotive
{
    public partial class EditClientEditHistory : KryptonForm
    {
        private int userId;
        private int receiptID;
        private int clientId;
        private static readonly Random rnd = new Random();
        private string connectionString = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=AutomotiveDB;Integrated Security=True;";
        public EditClientEditHistory(int userId, int receiptID, int clientId)
        {
            InitializeComponent();
            this.userId = userId;
            this.receiptID = receiptID;
            this.clientId = clientId;
        }

        private void LoadHistory()
        {
            string query = @"
            SELECT Issue, RepairedBy, Amount, Warranty, Date
            FROM Client_History
            WHERE ReceiptID = @ReceiptID";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ReceiptID", receiptID);

                    conn.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            lblIssue.Text = reader["Issue"].ToString();
                            lblRepairedBy.Text = reader["RepairedBy"].ToString();
                            lblAmount.Text = reader["Amount"].ToString();
                            lblWarranty.Text = reader["Warranty"].ToString();
                            lblDate.Text = Convert.ToDateTime(reader["Date"]).ToString("yyyy-MM-dd");
                        }
                        else
                        {
                            MessageBox.Show("No record found for this receipt ID.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading history: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int? ValidateAmount(string amount)
        {
            if (string.IsNullOrWhiteSpace(amount))
                return null;

            if (!Regex.IsMatch(amount, @"^\d+$"))
                throw new ArithmeticException("Amount must contain only digits.");

            return Convert.ToInt32(amount);
        }

        private int? ValidateWarranty(string warranty)
        {
            if (string.IsNullOrWhiteSpace(warranty))
                return null;

            if (!Regex.IsMatch(warranty, @"^\d+$"))
                throw new ArithmeticException("Warranty must contain only digits.");

            return Convert.ToInt32(warranty);
        }

        private int GenerateRandomId(int prefix, int digits)
        {
            int randomPart = rnd.Next(0, (int)Math.Pow(10, digits));
            return prefix * (int)Math.Pow(10, digits) + randomPart;
        }

        private void addClientHistory()
        {
            try
            {
                string issue = string.IsNullOrWhiteSpace(txtIssue.Text) ? null : txtIssue.Text.Trim();
                string repairBy = string.IsNullOrWhiteSpace(txtRepairedBy.Text) ? null : txtRepairedBy.Text.Trim();
                int? amount = ValidateAmount(txtAmount.Text);
                int? warranty = ValidateWarranty(txtWarranty.Text.Trim());
                string warrantyDuration = string.IsNullOrWhiteSpace(cbWarranty.Text) ? null : cbWarranty.SelectedItem?.ToString();
                DateTime date = dtpDate.Value;

                string warrantyCombined = null;
                if (warranty.HasValue || !string.IsNullOrWhiteSpace(warrantyDuration))
                {
                    warrantyCombined = $"{warranty}{warrantyDuration}";
                }

                int receiptId = receiptID;
                int logId = GenerateRandomId(500, 4);

                string jsonData = JsonConvert.SerializeObject(new
                {
                    receiptID = receiptId,
                    clientID = clientId,
                    issue,
                    repairBy,
                    amount,
                    warranty = warrantyCombined,
                    date = date.ToString("yyyy-MM-dd")
                },
                new JsonSerializerSettings
                {
                    NullValueHandling = NullValueHandling.Ignore
                });

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string insertLogQuery = @"
                                            INSERT INTO Transaction_Log
                                            (logID, tableName, recordID, actionType, newData, userID, status, dateRequested)
                                            VALUES (@logID, 'Client_History', @recordID, 'EDIT', @newData, @userID, 'Pending', GETDATE())";

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

        private void EditClientEditHistory_Load(object sender, EventArgs e)
        {
            LoadHistory();
        }

        private void btnEditConfirm_Click(object sender, EventArgs e)
        {
            addClientHistory();
        }
    }
}
