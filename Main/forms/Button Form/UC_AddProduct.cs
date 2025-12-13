using Presyong_Ka_Piyu.Main.programs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Presyong_Ka_Piyu.Main.forms.Button_Form
{
    public partial class UC_AddProduct : UserControl
    {
        private readonly string connectionString = "Data Source=C:\\Users\\conel\\Downloads\\Programs\\Projects\\Presyong_Ka-Piyu\\Main\\data\\Presyong_Ka-Piyu_Database.db";
        private string imagePath = "";


        public UC_AddProduct()
        {
            InitializeComponent();
            

            LoadCategories();
            LoadStores();
        }

        private void LoadCategories()
        {
            using var conn = new SQLiteConnection(connectionString);
            conn.Open();

            using var cmd = new SQLiteCommand(
                "SELECT Id, CategoryName FROM Categories WHERE CategoryType='Product'", conn);

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

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog
            {
                Filter = "Image Files|*.jpg;*.jpeg;*.png"
            };

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                imagePath = ofd.FileName;

                using var fs = new FileStream(imagePath, FileMode.Open, FileAccess.Read);
                picImage.Image = Image.FromStream(fs);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                CustomMessageBox.Show("Product name is required.");
                return;
            }

            using var conn = new SQLiteConnection(connectionString);
            conn.Open();
            using var tx = conn.BeginTransaction();

            try
            {
                long productId;

                using (var cmd = new SQLiteCommand(@"
                    INSERT INTO Products
(Name, CategoryId, Description, ImagePath, Rating, IsFavorite)
                    VALUES
(@Name, @CategoryId, @Description, @ImagePath, @Rating, @IsFavorite);", conn))
                {
                    cmd.Parameters.AddWithValue("@Name", txtName.Text);
                    cmd.Parameters.AddWithValue("@CategoryId", cmbCategory.SelectedValue);
                    cmd.Parameters.AddWithValue("@Description", txtDescription.Text);
                    cmd.Parameters.AddWithValue("@ImagePath", imagePath);
                    cmd.Parameters.AddWithValue("@Rating", numRating.Value);
                    cmd.Parameters.AddWithValue("@IsFavorite", chkFavorite.Checked ? 1 : 0);

                    productId = (long)cmd.ExecuteScalar();
                }

                using (var cmd = new SQLiteCommand(@"
                    INSERT INTO Prices (ProductId, StoreId, Price)
                    VALUES (@ProductId, @StoreId, @Price);", conn))
                {
                    cmd.Parameters.AddWithValue("@ProductId", productId);
                    cmd.Parameters.AddWithValue("@StoreId", cmbStore.SelectedValue);
                    cmd.Parameters.AddWithValue("@Price", numPrice.Value);
                    cmd.ExecuteNonQuery();
                }

                tx.Commit();
                CustomMessageBox.Show("Product saved successfully.");
                Add add = new Add();
                add.Close();
            }
            catch (Exception ex)
            {
                tx.Rollback();
                CustomMessageBox.Show(ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Add add = new Add();
            add.Close();
        }

        private void numPrice_ValueChanged(object sender, EventArgs e)
        {

        }

        private void UC_AddProduct_Load(object sender, EventArgs e)
        {

        }
    }
}