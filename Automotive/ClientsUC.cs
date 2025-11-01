using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Automotive
{
    public partial class ClientsUC : UserControl
    {
        private readonly string connectionString =
            @"Data Source=localhost\SQLEXPRESS;Initial Catalog=AutomotiveDB;Integrated Security=True;";

        private int userId;
        private string selectedClientId;
        private static readonly Random rnd = new Random();
        private ClientCardUC selectedCard;

        public ClientsUC(int userId)
        {
            InitializeComponent();
            this.userId = userId;
        }

        private void ClientsUC_Load(object sender, EventArgs e)
        {
            LoadItems();
        }

        public void LoadItems()
        {
            flowLayoutPanel1.Controls.Clear();

            string query = @"
                SELECT 
                    c.clientID,
                    c.name,
                    c.vehicle,
                    (
                        SELECT MIN([date]) 
                        FROM Client_History ch 
                        WHERE ch.clientID = c.clientID
                    ) AS clientSince,
                    c.vehiclePhoto
                FROM Clients c
                ORDER BY c.name ASC";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string id = reader["clientID"].ToString();
                    string name = reader["name"].ToString();
                    string vehicle = reader["vehicle"].ToString();
                    string date = reader["clientSince"]?.ToString() ?? "N/A";
                    string img = reader["vehiclePhoto"].ToString();

                    ClientCardUC card = new ClientCardUC();
                    card.setData(id, name, vehicle, date, img);
                    card.OnClientSelected += Card_OnClientSelected;
                    flowLayoutPanel1.Controls.Add(card);
                }

                reader.Close();
            }
        }

        private void Card_OnClientSelected(ClientCardUC clickedCard, string id)
        {
            if (selectedCard != null && selectedCard != clickedCard)
                selectedCard.SetSelected(false);

            clickedCard.SetSelected(true);
            selectedCard = clickedCard;
            selectedClientId = id;
        }

        private int GenerateRandomId(int prefix, int digits)
        {
            int randomPart = rnd.Next(0, (int)Math.Pow(10, digits));
            return prefix * (int)Math.Pow(10, digits) + randomPart;
        }

        //add client
        private void btnAdd_Click(object sender, EventArgs e)
        {
            ClientAdd clientAdd = new ClientAdd(userId);
            clientAdd.ShowDialog();
        }

        //edit client
        private void btnEdit_Click_1(object sender, EventArgs e)
        {
            if (selectedCard == null)
            {
                MessageBox.Show("Please select a client to edit.");
                return;
            }

            EditClient edit = new EditClient(userId, selectedClientId);
            edit.ShowDialog();
        }

        //remove client
        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (selectedCard == null)
            {
                MessageBox.Show("Please select a client to remove.");
                return;
            }

            DialogResult confirm = MessageBox.Show(
                "Are you sure you want to request deletion of this client?",
                "Confirm Deletion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirm == DialogResult.No)
                return;

            int logID = GenerateRandomId(500, 4);

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string jsonData = JsonConvert.SerializeObject(new
                    {
                        clientID = selectedClientId
                    });

                    string insertLogQuery = @"
                        INSERT INTO Transaction_Log
                        (logID, tableName, recordID, actionType, newData, userID, status, dateRequested)
                        VALUES (@logID, 'Clients', @recordID, 'DELETE', @newData, @userID, 'Pending', GETDATE())";

                    using (SqlCommand cmd = new SqlCommand(insertLogQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@logID", logID);
                        cmd.Parameters.AddWithValue("@recordID", selectedClientId);
                        cmd.Parameters.AddWithValue("@newData", jsonData);
                        cmd.Parameters.AddWithValue("@userID", userId);
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Client deletion request submitted for admin approval.");
                    LoadItems();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting client: " + ex.Message);
            }
        }
    }
}
