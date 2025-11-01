using Newtonsoft.Json.Linq;
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
    public partial class ApprovalsUC : UserControl
    {
        private int userId;
        private string connectionString = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=AutomotiveDB;Integrated Security=True;";
        public ApprovalsUC(int userId)
        {
            InitializeComponent();
            this.userId = userId;
        }

        private void ApprovalsUC_Load(object sender, EventArgs e)
        {
            LoadPendingRequests();
        }

        private void LoadPendingRequests()
        {
            dgvPending.Rows.Clear();

            string query = @"
                SELECT logID, tableName, recordID, actionType, newData, userID, dateRequested
                FROM Transaction_Log
                WHERE status = 'Pending'
                ORDER BY dateRequested DESC";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        dgvPending.Rows.Add(
                            reader["logID"],
                            reader["tableName"],
                            reader["actionType"],
                            reader["recordID"],
                            reader["userID"],
                            reader["dateRequested"]
                        );
                    }
                }
            }
        }

        private void dgvPending_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            int logId = Convert.ToInt32(dgvPending.Rows[e.RowIndex].Cells["colLogID"].Value);
            LoadLogDetails(logId);
        }

        private void LoadLogDetails(int logId)
        {
            string query = "SELECT newData FROM Transaction_Log WHERE logID = @logID";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@logID", logId);
                    string json = (string)cmd.ExecuteScalar();
                    txtDetails.Text = JToken.Parse(json).ToString(Newtonsoft.Json.Formatting.Indented);
                }
            }
        }

        private void btnApprove_Click(object sender, EventArgs e)
        {
            if (dgvPending.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a transaction to approve.");
                return;
            }

            int logId = Convert.ToInt32(dgvPending.SelectedRows[0].Cells["colLogID"].Value);
            string table = dgvPending.SelectedRows[0].Cells["colTableName"].Value.ToString();
            string action = dgvPending.SelectedRows[0].Cells["colActionType"].Value.ToString();

            ApproveTransaction(logId, table, action);
        }

        private void ApproveTransaction(int logId, string table, string action)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlTransaction tx = conn.BeginTransaction();

                try
                {
                    string jsonQuery = "SELECT newData FROM Transaction_Log WHERE logID = @logID";
                    string json = "";
                    using (SqlCommand cmd = new SqlCommand(jsonQuery, conn, tx))
                    {
                        cmd.Parameters.AddWithValue("@logID", logId);
                        json = (string)cmd.ExecuteScalar();
                    }

                    JObject data = JObject.Parse(json);

                    if (table == "Clients")
                    {
                        if (action == "CREATE")
                            ApproveClientCreate(conn, tx, data);
                        else if (action == "DELETE")
                            ApproveClientDelete(conn, tx, data);
                        else if (action == "EDIT")
                            ApproveClientEdit(conn, tx, data);
                    }
                    else if (table == "Client_History")
                    {
                        if (action == "CREATE")
                            ApproveHistoryCreate(conn, tx, data);
                        else if (action == "EDIT")
                            ApproveHistoryEdit(conn, tx, data);
                        else if (action == "DELETE")
                            ApproveHistoryDelete(conn, tx, data);
                    }

                    string updateStatus = "UPDATE Transaction_Log SET status = 'Approved' WHERE logID = @logID";
                    using (SqlCommand cmd = new SqlCommand(updateStatus, conn, tx))
                    {
                        cmd.Parameters.AddWithValue("@logID", logId);
                        cmd.ExecuteNonQuery();
                    }

                    tx.Commit();
                    MessageBox.Show($"Transaction {logId} approved successfully.");
                    LoadPendingRequests();
                }
                catch (Exception ex)
                {
                    tx.Rollback();
                    MessageBox.Show("Error approving transaction YES YES YES: " + ex.Message);
                }
            }
        }

        private void ApproveClientCreate(SqlConnection conn, SqlTransaction tx, JObject data)
        {
            string insert = @"
                INSERT INTO Clients (clientID, name, vehicle, model, vehiclePhoto)
                VALUES (@id, @name, @vehicle, @model, @photo)";

            using (SqlCommand cmd = new SqlCommand(insert, conn, tx))
            {
                cmd.Parameters.AddWithValue("@id", (int)data["clientID"]);
                cmd.Parameters.AddWithValue("@name", (string)data["name"]);
                cmd.Parameters.AddWithValue("@vehicle", (string)data["vehicle"]);
                cmd.Parameters.AddWithValue("@model", (string)data["model"]);
                cmd.Parameters.AddWithValue("@photo", (string)data["vehiclePhoto"]);
                cmd.ExecuteNonQuery();
            }
        }

        private void ApproveClientDelete(SqlConnection conn, SqlTransaction tx, JObject data)
        {
            string delete = "DELETE FROM Clients WHERE clientID = @id";
            using (SqlCommand cmd = new SqlCommand(delete, conn, tx))
            {
                cmd.Parameters.AddWithValue("@id", (int)data["clientID"]);
                cmd.ExecuteNonQuery();
            }
        }

        private void ApproveClientEdit(SqlConnection conn, SqlTransaction tx, JObject data)
        {
            List<string> updates = new List<string>();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.Transaction = tx;

            int clientId = Convert.ToInt32((string)data["clientID"]);

            if (data["name"] != null && data["name"].Type != JTokenType.Null)
            {
                updates.Add("name = @name");
                cmd.Parameters.AddWithValue("@name", (string)data["name"]);
            }

            if (data["vehicle"] != null && data["vehicle"].Type != JTokenType.Null)
            {
                updates.Add("vehicle = @vehicle");
                cmd.Parameters.AddWithValue("@vehicle", (string)data["vehicle"]);
            }

            if (data["model"] != null && data["model"].Type != JTokenType.Null)
            {
                updates.Add("model = @model");
                cmd.Parameters.AddWithValue("@model", (string)data["model"]);
            }

            if (data["vehiclePhoto"] != null && data["vehiclePhoto"].Type != JTokenType.Null)
            {
                updates.Add("vehiclePhoto = @photo");
                cmd.Parameters.AddWithValue("@photo", (string)data["vehiclePhoto"]);
            }

            if (updates.Count == 0)
                return;

            string sql = $"UPDATE Clients SET {string.Join(", ", updates)} WHERE clientID = @id";
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@id", clientId);

            int rows = cmd.ExecuteNonQuery();
        }

        private void ApproveHistoryCreate(SqlConnection conn, SqlTransaction tx, JObject data)
        {
            string insert = @"
                INSERT INTO Client_History (receiptID, clientID, issue, repairedBy, amount, warranty, date)
                VALUES (@receiptID, @clientID, @issue, @repairedBy, @amount, @warranty, @date)";

            using (SqlCommand cmd = new SqlCommand(insert, conn, tx))
            {
                cmd.Parameters.AddWithValue("@receiptID", (int)data["receiptID"]);
                cmd.Parameters.AddWithValue("@clientID", (int)data["clientID"]);
                cmd.Parameters.AddWithValue("@issue", (string)data["issue"]);
                cmd.Parameters.AddWithValue("@repairedBy", (string)data["repairedBy"]);
                cmd.Parameters.AddWithValue("@amount", (decimal)data["amount"]);
                cmd.Parameters.AddWithValue("@warranty", (string)data["warranty"]);
                cmd.Parameters.AddWithValue("@date", (DateTime)data["date"]);
                cmd.ExecuteNonQuery();
            }
        }

        private void ApproveHistoryEdit(SqlConnection conn, SqlTransaction tx, JObject data)
        {
            List<string> updates = new List<string>();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.Transaction = tx;

            int receiptID = Convert.ToInt32((string)data["receiptID"]);

            if (data["issue"] != null && data["issue"].Type != JTokenType.Null)
            {
                updates.Add("issue = @issue");
                cmd.Parameters.AddWithValue("@issue", (string)data["issue"]);
            }

            if (data["repairedBy"] != null && data["repairedBy"].Type != JTokenType.Null)
            {
                updates.Add("repairedBy = @repairedBy");
                cmd.Parameters.AddWithValue("@repairedBy", (string)data["repairedBy"]);
            }

            if (data["amount"] != null && data["amount"].Type != JTokenType.Null)
            {
                updates.Add("amount = @amount");
                cmd.Parameters.AddWithValue("@amount", Convert.ToDecimal((string)data["amount"]));
            }

            if (data["warranty"] != null && data["warranty"].Type != JTokenType.Null)
            {
                updates.Add("warranty = @warranty");
                cmd.Parameters.AddWithValue("@warranty", (string)data["warranty"]);
            }

            if (data["date"] != null && data["date"].Type != JTokenType.Null)
            {
                updates.Add("[date] = @date");
                cmd.Parameters.AddWithValue("@date", Convert.ToDateTime((string)data["date"]));
            }

            if (updates.Count == 0)
                return;

            string sql = $"UPDATE Client_History SET {string.Join(", ", updates)} WHERE receiptID = @id";
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@id", receiptID);

            int rows = cmd.ExecuteNonQuery();

            if (rows == 0)
            {
                throw new Exception("No matching record found to update in ClientHistory.");
            }
        }


        private void ApproveHistoryDelete(SqlConnection conn, SqlTransaction tx, JObject data)
        {
            string delete = "DELETE FROM Client_History WHERE receiptID = @id";
            using (SqlCommand cmd = new SqlCommand(delete, conn, tx))
            {
                cmd.Parameters.AddWithValue("@id", (int)data["receiptID"]);
                cmd.ExecuteNonQuery();
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dgvPending.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a transaction to reject.");
                return;
            }

            int logId = Convert.ToInt32(dgvPending.SelectedRows[0].Cells["colLogID"].Value);

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string update = "UPDATE Transaction_Log SET status = 'Rejected' WHERE logID = @logID";
                using (SqlCommand cmd = new SqlCommand(update, conn))
                {
                    cmd.Parameters.AddWithValue("@logID", logId);
                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Transaction rejected.");
            LoadPendingRequests();
        }
    }
}
