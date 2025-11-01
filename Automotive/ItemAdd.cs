using ComponentFactory.Krypton.Toolkit;
using Newtonsoft.Json;
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
using System.Xml.Linq;

namespace Automotive
{
    public partial class ItemAdd : KryptonForm
    {
        private int userId;
        private StorageUC storageRef;
        private static readonly Random rnd = new Random();
        private string connectionString = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=AutomotiveDB;Integrated Security=True;";
        public ItemAdd(int userId, StorageUC storageRef)
        {
            InitializeComponent();
            this.userId = userId;
            this.storageRef = storageRef;
        }

        private string ValidateName(string name)
        {
            if (Regex.IsMatch(name, @"^[0-9]+$"))
                throw new StringFormatException("Name Cannot Contain Numbers");

            if (Regex.IsMatch(name, @"[!@#$%^&*(),.?""':{}|<>_\-+=\\/\[\]~`]"))
                throw new NoSpecialCharacterAndWhiteSpacesException("Name Cannot Contain Special Characters");

            if (string.IsNullOrEmpty(name))
                throw new ArgumentNullException("Please input a name");

            return name;
        }

        private int ValidatePrice(string priceText)
        {
            if (!Regex.IsMatch(priceText, @"^\d+$"))
                throw new ArithmeticException("Price must contain only digits.");

            if (string.IsNullOrEmpty(priceText))
                throw new ArgumentNullException("Please input a price");

            return Convert.ToInt32(priceText);
        }

        private int ValidateStock(string stockText)
        {
            if (!Regex.IsMatch(stockText, @"^\d+$"))
                throw new ArithmeticException("Stock must contain only digits.");

            if (string.IsNullOrEmpty(stockText))
                throw new ArgumentNullException("Please input stock");

            return Convert.ToInt32(stockText);
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
                string name = ValidateName(txtName.Text);
                decimal price = ValidatePrice(txtPrice.Text);
                int stock = ValidateStock(txtStock.Text);
                string img = lblPhoto.Text;

                int itemId = GenerateRandomId(100, 4);
                int logId = GenerateRandomId(500, 4);

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    using (SqlTransaction transaction = conn.BeginTransaction())
                    {
                        try
                        {
                            // ✅ 1. Insert directly into Items
                            string insertItemQuery = @"
                        INSERT INTO Items (itemID, itemName, price, stock, itemImage)
                        VALUES (@id, @name, @price, @stock, @img)";

                            using (SqlCommand cmd = new SqlCommand(insertItemQuery, conn, transaction))
                            {
                                cmd.Parameters.AddWithValue("@id", itemId);
                                cmd.Parameters.AddWithValue("@name", name);
                                cmd.Parameters.AddWithValue("@price", price);
                                cmd.Parameters.AddWithValue("@stock", stock);
                                cmd.Parameters.AddWithValue("@img", img);
                                cmd.ExecuteNonQuery();
                            }

                            // ✅ 2. Serialize data for logging
                            string jsonData = JsonConvert.SerializeObject(new
                            {
                                itemID = itemId,
                                itemName = name,
                                price = price,
                                stock = stock,
                                itemImage = img
                            });

                            // ✅ 3. Insert Transaction Log (no approval)
                            string insertLogQuery = @"
                        INSERT INTO Transaction_Log 
                        (logID, tableName, recordID, actionType, newData, userID, status, dateRequested)
                        VALUES (@logID, 'Items', @recordID, 'CREATE', @newData, @userID, 'Approved', GETDATE())";

                            using (SqlCommand cmd = new SqlCommand(insertLogQuery, conn, transaction))
                            {
                                cmd.Parameters.AddWithValue("@logID", logId);
                                cmd.Parameters.AddWithValue("@recordID", itemId);
                                cmd.Parameters.AddWithValue("@newData", jsonData);
                                cmd.Parameters.AddWithValue("@userID", userId);
                                cmd.ExecuteNonQuery();
                            }

                            transaction.Commit();

                            MessageBox.Show("Item successfully added!");
                            this.Close();
                            storageRef.LoadItems(); // refresh item list
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            lblInvalid.Text = "Error: " + ex.Message;
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
            catch (ArgumentNullException ex)
            {
                lblInvalid.Text = ex.Message;
            }
            catch (Exception ex)
            {
                lblInvalid.Text = "Unexpected error: " + ex.Message;
            }
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
