using System;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Automotive
{
    public partial class StorageUC : UserControl
    {
        private string connectionString = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=AutomotiveDB;Integrated Security=True;";
        private int userId;
        private string selectedItemId;
        private static readonly Random rnd = new Random();
        private ItemCardUC selectedCard;

        public StorageUC(int userId)
        {
            InitializeComponent();
            this.userId = userId;
        }

        public void LoadItems()
        {
            flowLayoutPanel1.Controls.Clear();

            string query = "SELECT itemID, itemName, price, stock, itemImage FROM Items";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string id = reader["itemID"].ToString();
                    string name = reader["itemName"].ToString();
                    double price = Convert.ToDouble(reader["price"]);
                    int stock = Convert.ToInt32(reader["stock"]);
                    string img = reader["itemImage"].ToString();

                    ItemCardUC card = new ItemCardUC();
                    card.setData(id, name, price, stock, img);

                    card.OnItemSelected += Card_OnItemSelected;

                    flowLayoutPanel1.Controls.Add(card);
                }
                reader.Close();
            }
        }

        private int GenerateRandomId(int prefix, int digits)
        {
            int randomPart = rnd.Next(0, (int)Math.Pow(10, digits));
            return prefix * (int)Math.Pow(10, digits) + randomPart;
        }

        private void Card_OnItemSelected(ItemCardUC clickedCard, string id)
        {
            if (selectedCard != null && selectedCard != clickedCard)
                selectedCard.SetSelected(false);

            clickedCard.SetSelected(true);
            selectedCard = clickedCard;

            selectedItemId = id;
        }

        private void StorageUC_Load(object sender, EventArgs e)
        {
            LoadItems();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ItemAdd add = new ItemAdd(userId, this);
            add.ShowDialog();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (selectedCard == null)
                return;

            int logID = GenerateRandomId(500, 4);

            DialogResult confirm = MessageBox.Show(
                "Are you sure you want to delete this item?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirm == DialogResult.No)
                return;

            string deleteQuery = "DELETE FROM Items WHERE itemID = @id";
            string insertLogQuery = @"
                                    INSERT INTO transaction_logs (logID, editedID, type, category, dataChanged, userId, date)
                                    VALUES (@logID, @editedID, @type, @category, @dataChanged, @userId, @date)";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                using (SqlTransaction transaction = conn.BeginTransaction())
                {
                    try
                    {
                        using (SqlCommand deleteCmd = new SqlCommand(deleteQuery, conn, transaction))
                        {
                            deleteCmd.Parameters.AddWithValue("@id", selectedItemId);
                            deleteCmd.ExecuteNonQuery();
                        }

                        using (SqlCommand logCmd = new SqlCommand(insertLogQuery, conn, transaction))
                        {
                            logCmd.Parameters.AddWithValue("@logID", logID);
                            logCmd.Parameters.AddWithValue("@editedID", selectedItemId);
                            logCmd.Parameters.AddWithValue("@type", "Remove");
                            logCmd.Parameters.AddWithValue("@category", "Storage");
                            logCmd.Parameters.AddWithValue("@dataChanged", "Remove Item");
                            logCmd.Parameters.AddWithValue("@userId", userId);
                            logCmd.Parameters.AddWithValue("@date", DateTime.Now.Date);

                            logCmd.ExecuteNonQuery();
                        }

                        transaction.Commit();

                        MessageBox.Show("Item successfully deleted!");
                        LoadItems();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show("Error deleting item: " + ex.Message);
                    }
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (selectedItemId == null)
                MessageBox.Show("Please select an item");
            else
            {
                ItemEdit edit = new ItemEdit(userId, selectedItemId, this);
                edit.ShowDialog();
            } 
        }
    }
}
