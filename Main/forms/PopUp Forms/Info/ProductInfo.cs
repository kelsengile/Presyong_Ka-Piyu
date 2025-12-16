using Presyong_Ka_Piyu.Main.programs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Presyong_Ka_Piyu.Main.forms.PopUp_Forms
{
    public partial class ProductInfo : Form
    {
        private int productId;
        private string connectionString = "Data Source=C:\\Users\\acer nitro v15\\source\\repos\\Presyong_Ka-Piyu\\Design\\Main\\data\\Presyong_Ka-Piyu_Database.db";
        private string imagePath;

        public ProductInfo(int productId)
        {
            InitializeComponent();
            ThemeManager.ApplyTheme(this);

            this.productId = productId;

            LoadCategories();
            LoadStores();
            LoadProductData();
        }

        private void LoadCategories()
        {
            using var conn = new SQLiteConnection(connectionString);
            conn.Open();
            using var cmd = new SQLiteCommand("SELECT Id, CategoryName FROM Categories WHERE CategoryType='Product'", conn);
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            cmbCategory.DataSource = dt;
            cmbCategory.DisplayMember = "CategoryName";
            cmbCategory.ValueMember = "Id";
        }

        private void LoadStores()
        {
            using var conn = new SQLiteConnection(connectionString);
            conn.Open();
            using var cmd = new SQLiteCommand("SELECT Id, Name FROM Stores", conn);
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            cmbStore.DataSource = dt;
            cmbStore.DisplayMember = "Name";
            cmbStore.ValueMember = "Id";
        }

        private void LoadProductData()
        {
            using var conn = new SQLiteConnection(connectionString);
            conn.Open();
            using var cmd = new SQLiteCommand(@"
                SELECT P.Name, P.CategoryId, P.Description, P.ImagePath, P.Rating, P.IsFavorite, PR.StoreId, PR.Price
                FROM Products P
                LEFT JOIN Prices PR ON PR.ProductId = P.Id
                WHERE P.Id=@Id
                LIMIT 1;", conn);
            cmd.Parameters.AddWithValue("@Id", productId);

            using var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                txtName.Text = reader["Name"].ToString();
                cmbCategory.SelectedValue = reader["CategoryId"];
                txtDescription.Text = reader["Description"].ToString();
                imagePath = reader["ImagePath"].ToString();
                if (File.Exists(imagePath)) picImage.Image = Image.FromFile(imagePath);
                numRating.Value = Convert.ToDecimal(reader["Rating"]);
                chkFavorite.Checked = Convert.ToBoolean(reader["IsFavorite"]);
                cmbStore.SelectedValue = reader["StoreId"];
                numPrice.Value = Convert.ToDecimal(reader["Price"]);
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using OpenFileDialog ofd = new OpenFileDialog { Filter = "Image Files|*.jpg;*.jpeg;*.png" };
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                imagePath = ofd.FileName;
                picImage.Image = Image.FromFile(imagePath);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using var conn = new SQLiteConnection(connectionString);
            conn.Open();
            using var tx = conn.BeginTransaction();
            try
            {
                // Update Product
                using (var cmd = new SQLiteCommand(@"
                    UPDATE Products SET 
                        Name=@Name, CategoryId=@CategoryId, Description=@Description, 
                        ImagePath=@ImagePath, Rating=@Rating, IsFavorite=@IsFavorite
                    WHERE Id=@Id;", conn, tx))
                {
                    cmd.Parameters.AddWithValue("@Name", txtName.Text);
                    cmd.Parameters.AddWithValue("@CategoryId", cmbCategory.SelectedValue);
                    cmd.Parameters.AddWithValue("@Description", txtDescription.Text);
                    cmd.Parameters.AddWithValue("@ImagePath", imagePath);
                    cmd.Parameters.AddWithValue("@Rating", numRating.Value);
                    cmd.Parameters.AddWithValue("@IsFavorite", chkFavorite.Checked ? 1 : 0);
                    cmd.Parameters.AddWithValue("@Id", productId);
                    cmd.ExecuteNonQuery();
                }

                // Update Price
                using (var cmd = new SQLiteCommand(@"
                    UPDATE Prices SET StoreId=@StoreId, Price=@Price
                    WHERE ProductId=@Id;", conn, tx))
                {
                    cmd.Parameters.AddWithValue("@StoreId", cmbStore.SelectedValue);
                    cmd.Parameters.AddWithValue("@Price", numPrice.Value);
                    cmd.Parameters.AddWithValue("@Id", productId);
                    cmd.ExecuteNonQuery();
                }

                tx.Commit();
                CustomMessageBox.Show("Product updated successfully!");
                this.Close();
            }
            catch (Exception ex)
            {
                tx.Rollback();
                CustomMessageBox.Show(ex.Message);
            }
        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(
        "Are you sure you want to delete this product and all related data?",
        "Confirm Delete",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Warning
    );

            if (result == DialogResult.Yes)
            {
                using var conn = new SQLiteConnection(connectionString);
                conn.Open();
                using var tx = conn.BeginTransaction();
                try
                {
                    // 1. Delete from Prices table
                    using (var cmd = new SQLiteCommand("DELETE FROM Prices WHERE ProductId=@ProductId", conn, tx))
                    {
                        cmd.Parameters.AddWithValue("@ProductId", productId);
                        cmd.ExecuteNonQuery();
                    }

                    

                    // 2. Delete from Products table
                    using (var cmd = new SQLiteCommand("DELETE FROM Products WHERE Id=@ProductId", conn, tx))
                    {
                        cmd.Parameters.AddWithValue("@ProductId", productId);
                        cmd.ExecuteNonQuery();
                    }

                    tx.Commit();
                    CustomMessageBox.Show("Product deleted successfully.");
                    this.Close();
                }
                catch (Exception ex)
                {
                    tx.Rollback();
                    CustomMessageBox.Show("Error deleting product: " + ex.Message);
                }
            }
        }
    }
}