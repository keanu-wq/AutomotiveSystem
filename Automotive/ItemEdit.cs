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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Automotive
{
    public partial class ItemEdit : KryptonForm
    {
        private string itemID;
        private int userId;
        private StorageUC storageRef;
        private static readonly Random rnd = new Random();
        private string connectionString = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=AutomotiveDB;Integrated Security=True;";
        public ItemEdit(int userId, string itemID, StorageUC storageRef)
        {
            InitializeComponent();
            this.itemID = itemID;
            this.userId = userId;
            this.storageRef = storageRef;
        }

        private string ValidateName(string name)
        {
            if (Regex.IsMatch(name, @"^[0-9]+$"))
                throw new StringFormatException("Name Cannot Contain Numbers");

            if (Regex.IsMatch(name, @"[!@#$%^&*(),.?""':{}|<>_\-+=\\/\[\]~`]"))
                throw new NoSpecialCharacterAndWhiteSpacesException("Name Cannot Contain Special Characters");

            return name;
        }

        private int ValidatePrice(string priceText)
        {
            if (!Regex.IsMatch(priceText, @"^\d+$") && !string.IsNullOrEmpty(priceText))
                throw new ArithmeticException("Price must contain only digits.");

            return Convert.ToInt32(priceText);
        }

        private int ValidateStock(string stockText)
        {
            if (!Regex.IsMatch(stockText, @"^\d+$") && !string.IsNullOrEmpty(stockText))
                throw new ArithmeticException("Stock must contain only digits.");

            return Convert.ToInt32(stockText);
        }

        public void setData(string id, string name, double price, int stock, string img)
        {
            lblName.Text = name;
            lblID.Text = id;
            lblPrice.Text = "P " + price.ToString("N0");
            lblStock.Text = stock.ToString();

            lblPrice.ForeColor = Color.Green;
            lblStock.ForeColor = stock <= 5 ? Color.Red : Color.Green;

            if (!string.IsNullOrWhiteSpace(img) && File.Exists(img))
            {
                picItem.Image = Image.FromFile(img);
            }
            
            this.Invalidate();
        }

        private void ItemEdit_Load(object sender, EventArgs e)
        {
            string query = "SELECT itemID, itemName, price, stock, itemImage " +
                "FROM Items " +
                "WHERE itemID = @itemID";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@itemID", itemID);

                    try
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string id = reader["itemID"].ToString();
                                string name = reader["itemName"].ToString();
                                double price = Convert.ToDouble(reader["price"]);
                                int stock = Convert.ToInt32(reader["stock"]);
                                string img = reader["itemImage"].ToString();

                                setData(id, name, price, stock, img);
                            }
                            else
                            {
                                MessageBox.Show("Item not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                this.Close();
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Please select an Item");
                    }
                }
            }
        }

        private int GenerateRandomId(int prefix, int digits)
        {
            int randomPart = rnd.Next(0, (int)Math.Pow(10, digits));
            return prefix * (int)Math.Pow(10, digits) + randomPart;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                string newName = null;
                int? newPrice = null;
                int? newStock = null;
                string newImage = null;

                if (!string.IsNullOrWhiteSpace(txtName.Text))
                    newName = ValidateName(txtName.Text.Trim());

                if (!string.IsNullOrWhiteSpace(txtPrice.Text))
                    newPrice = ValidatePrice(txtPrice.Text.Trim());

                if (!string.IsNullOrWhiteSpace(txtStock.Text))
                    newStock = ValidateStock(txtStock.Text.Trim());

                if (!string.IsNullOrWhiteSpace(lblPhoto.Text))
                    newImage = lblPhoto.Text.Trim();

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    using (SqlTransaction transaction = conn.BeginTransaction())
                    {
                        try
                        {
                            string selectQuery = "SELECT itemName, price, stock, itemImage FROM Items WHERE itemID = @id";
                            string insertLogQuery = @"
                                                    INSERT INTO transaction_logs (logID, editedID, type, category, dataChanged, oldValue, newValue, userId, date)
                                                    VALUES (@logID, @editedID, @type, @category, @dataChanged, @oldValue, @newValue, @userId, @date)";

                            string currentName = "";
                            double currentPrice = 0;
                            int currentStock = 0;
                            string currentImage = "";

                            using (SqlCommand cmd = new SqlCommand(selectQuery, conn, transaction))
                            {
                                cmd.Parameters.AddWithValue("@id", itemID);
                                using (SqlDataReader reader = cmd.ExecuteReader())
                                {
                                    if (reader.Read())
                                    {
                                        currentName = reader["itemName"].ToString();
                                        currentPrice = Convert.ToDouble(reader["price"]);
                                        currentStock = Convert.ToInt32(reader["stock"]);
                                        currentImage = reader["itemImage"].ToString();
                                    }
                                }
                            }

                            List<string> updateParts = new List<string>();
                            SqlCommand updateCmd = new SqlCommand();
                            updateCmd.Connection = conn;
                            updateCmd.Transaction = transaction;
                            List<string> changedFields = new List<string>();

                            if (newName != null)
                            {
                                updateParts.Add("itemName = @name");
                                updateCmd.Parameters.AddWithValue("@name", newName);
                                changedFields.Add("Name");
                            }

                            if (newPrice.HasValue)
                            {
                                updateParts.Add("price = @price");
                                updateCmd.Parameters.AddWithValue("@price", newPrice.Value);
                                changedFields.Add("Price");
                            }

                            if (newStock.HasValue)
                            {
                                updateParts.Add("stock = @stock");
                                updateCmd.Parameters.AddWithValue("@stock", newStock.Value);
                                changedFields.Add("Stock");
                            }

                            if (newImage != null)
                            {
                                updateParts.Add("itemImage = @image");
                                updateCmd.Parameters.AddWithValue("@image", newImage);
                                changedFields.Add("Photo");
                            }

                            if (updateParts.Count == 0)
                            {
                                MessageBox.Show("No fields to update");
                                return;
                            }

                            updateCmd.CommandText = "UPDATE Items SET " + string.Join(", ", updateParts) + " WHERE itemID = @id";
                            updateCmd.Parameters.AddWithValue("@id", itemID);
                            updateCmd.ExecuteNonQuery();

                            foreach (string field in changedFields)
                            {
                                int logId = GenerateRandomId(500, 4);

                                string oldValue = "";
                                string newValue = "";

                                switch (field)
                                {
                                    case "Name":
                                        oldValue = currentName;
                                        newValue = newName;
                                        break;

                                    case "Price":
                                        oldValue = currentPrice.ToString();
                                        newValue = newPrice.HasValue ? newPrice.Value.ToString() : "";
                                        break;

                                    case "Stock":
                                        oldValue = currentStock.ToString();
                                        newValue = newStock.HasValue ? newStock.Value.ToString() : "";
                                        break;

                                    case "Photo":
                                        oldValue = currentImage;
                                        newValue = newImage ?? "";
                                        break;
                                }

                                using (SqlCommand logCmd = new SqlCommand(insertLogQuery, conn, transaction))
                                {
                                    logCmd.Parameters.AddWithValue("@logID", logId);
                                    logCmd.Parameters.AddWithValue("@editedID", itemID);
                                    logCmd.Parameters.AddWithValue("@type", "Edit");
                                    logCmd.Parameters.AddWithValue("@category", "Storage");
                                    logCmd.Parameters.AddWithValue("@dataChanged", field);
                                    logCmd.Parameters.AddWithValue("@oldValue", oldValue);
                                    logCmd.Parameters.AddWithValue("@newValue", newValue);
                                    logCmd.Parameters.AddWithValue("@userId", userId);
                                    logCmd.Parameters.AddWithValue("@date", DateTime.Now);

                                    logCmd.ExecuteNonQuery();
                                }
                            }

                            transaction.Commit();

                            MessageBox.Show("Item successfully updated!");
                            this.Close();
                            storageRef.LoadItems();
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            MessageBox.Show("Error updating item: " + ex.Message);
                        }
                    }
                }
            }
            catch (StringFormatException ex)
            {
                lblInvalid.Text = ex.Message;
            }
            catch (ArithmeticException ex)
            {
                lblInvalid.Text = ex.Message;
            }
            catch (NoSpecialCharacterAndWhiteSpacesException ex)
            {
                lblInvalid.Text = ex.Message;
            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show("No fields to update");
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
            openFileDialog.Title = "Select a New Photo";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                lblPhoto.Text = openFileDialog.FileName;
            }
        }
    }
}
