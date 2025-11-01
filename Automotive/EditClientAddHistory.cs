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
    public partial class EditClientAddHistory : KryptonForm
    {
        private int userId;
        private int clientId;
        private static readonly Random rnd = new Random();
        private string connectionString = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=AutomotiveDB;Integrated Security=True;";
        public EditClientAddHistory(int userId, int clientId)
        {
            InitializeComponent();
            this.userId = userId;
            this.clientId = clientId;
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

        private int GenerateRandomId(int prefix, int digits)
        {
            int randomPart = rnd.Next(0, (int)Math.Pow(10, digits));
            return prefix * (int)Math.Pow(10, digits) + randomPart;
        }


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

        private void btnEditConfirm_Click(object sender, EventArgs e)
        {
            addClientHistory();
        }
    }
}
