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
    public partial class StoreInfo : Form
    {

        private int storeId;
        private string connectionString = "Data Source=C:\\Users\\conel\\Downloads\\Programs\\Projects\\Presyong_Ka-Piyu\\Main\\data\\Presyong_Ka-Piyu_Database.db";
        private string imagePath;

        public StoreInfo(int storeId)
        {
            InitializeComponent();
           

            this.storeId = storeId;

            LoadCategories();

            LoadLocations();

            LoadStoreData();
            
            LoadProductsForStore(storeId);
            ThemeManager.ApplyTheme(this);

        }

        private void LoadCategories()
        {
            using var conn = new SQLiteConnection(connectionString);
            conn.Open();
            using var cmd = new SQLiteCommand("SELECT Id, CategoryName FROM Categories WHERE CategoryType='Store'", conn);
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            cmbCategory.DataSource = dt;
            cmbCategory.DisplayMember = "CategoryName";
            cmbCategory.ValueMember = "Id";
        }

        private void LoadLocations()
        {
            using var conn = new SQLiteConnection(connectionString);
            conn.Open();

            using var cmd = new SQLiteCommand("SELECT Id, LocationName FROM Locations ORDER BY Id", conn);
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());

            cmbLocation.DataSource = dt;
            cmbLocation.DisplayMember = "LocationName"; // what user sees
            cmbLocation.ValueMember = "Id";             // stored in Stores.LocationId
                                                        // IMPORTANT: do NOT force-select index 0
            cmbLocation.SelectedIndex = -1;
        }

        private void LoadStoreData()
        {
            using var conn = new SQLiteConnection(connectionString);
            conn.Open();
            using var cmd = new SQLiteCommand("SELECT * FROM Stores WHERE Id=@Id", conn);
            cmd.Parameters.AddWithValue("@Id", storeId);
            using var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                txtName.Text = reader["Name"].ToString();
                cmbLocation.SelectedValue = Convert.ToInt32(reader["LocationId"]);
                txtContact.Text = reader["Contact"].ToString();
                txtDescription.Text = reader["Description"].ToString();
                cmbCategory.SelectedValue = reader["CategoryId"];
                numRating.Value = Convert.ToDecimal(reader["Rating"]);
                chkFavorite.Checked = Convert.ToBoolean(reader["IsFavorite"]);
                imagePath = reader["ImagePath"].ToString();
                if (File.Exists(imagePath)) picImage.Image = Image.FromFile(imagePath);
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
            using var cmd = new SQLiteCommand(@"
                UPDATE Stores SET 
                Name=@Name, LocationID=@LocationID, Contact=@Contact, Description=@Description,
                CategoryId=@CategoryId, Rating=@Rating, ImagePath=@ImagePath, IsFavorite=@IsFavorite
                WHERE Id=@Id", conn);

            cmd.Parameters.AddWithValue("@Name", txtName.Text);
            cmd.Parameters.AddWithValue("@LocationID", cmbLocation.SelectedValue);
            cmd.Parameters.AddWithValue("@Contact", txtContact.Text);
            cmd.Parameters.AddWithValue("@Description", txtDescription.Text);
            cmd.Parameters.AddWithValue("@CategoryId", cmbCategory.SelectedValue);
            cmd.Parameters.AddWithValue("@Rating", numRating.Value);
            cmd.Parameters.AddWithValue("@ImagePath", imagePath);
            cmd.Parameters.AddWithValue("@IsFavorite", chkFavorite.Checked ? 1 : 0);
            cmd.Parameters.AddWithValue("@Id", storeId);

            cmd.ExecuteNonQuery();
            CustomMessageBox.Show("Store updated successfully!");
            this.Close();
        }

        private void LoadProductsForStore(int storeId)
        {
            flpStoreProducts.Controls.Clear();

            using var conn = new SQLiteConnection(connectionString);
            conn.Open();

            string sql = @"
    SELECT 
        P.Id,
        P.Name,
        P.Description,
        P.Rating,
        C.CategoryName,
        PR.Price,
        P.IsFavorite
    FROM Prices PR
    INNER JOIN Products P ON PR.ProductId = P.Id
    INNER JOIN Categories C ON P.CategoryId = C.Id
    WHERE PR.StoreId = @StoreId
    ORDER BY P.Name
";

            using var cmd = new SQLiteCommand(sql, conn);
            cmd.Parameters.AddWithValue("@StoreId", storeId);

            using var reader = cmd.ExecuteReader();

            if (!reader.HasRows)
            {
                flpStoreProducts.Controls.Add(CreateInfoLabel("No products available for this store."));
                return;
            }

            // Header row
            flpStoreProducts.Controls.Add(CreateTableHeader());

            while (reader.Read())
            {
                int productId = Convert.ToInt32(reader["Id"]);

                string name = reader["Name"].ToString();
                string category = reader["CategoryName"].ToString();
                string description = reader["Description"]?.ToString() ?? "";
                string rating = reader["Rating"].ToString();
                string price = $"₱{reader["Price"]}";
                string favorite = Convert.ToBoolean(reader["IsFavorite"]) ? "Yes" : "No";

                flpStoreProducts.Controls.Add(
                    CreateProductRow(
                        name,
                        category,
                        description,
                        rating,
                        price,
                        favorite,
                        () => OpenProduct(productId)
                    )
                );
            }
        }

        private Control CreateTableHeader()
        {
            Panel header = new Panel
            {
                Width = 800,
                Height = 35,
                BackColor = SystemColors.GradientActiveCaption,
                Margin = new Padding(0, 0, 0, 5)
            };

            header.Controls.Add(CreateHeaderLabel("Name", 150));
            header.Controls.Add(CreateHeaderLabel("Category", 120, 150));
            header.Controls.Add(CreateHeaderLabel("Description", 250, 270));
            header.Controls.Add(CreateHeaderLabel("Rating", 80, 530));
            header.Controls.Add(CreateHeaderLabel("Price", 80, 620));
            header.Controls.Add(CreateHeaderLabel("Favorite", 80, 700));

            return header;
        }

        private Label CreateHeaderLabel(string text, int width, int left = 0)
        {
            return new Label
            {
                Text = text,
                Width = width,
                Left = left,
                Dock = DockStyle.None,
                TextAlign = ContentAlignment.MiddleLeft,
                Font = new Font("Segoe UI", 9, FontStyle.Bold)
            };
        }

        private Control CreateProductRow(
    string name,
    string category,
    string description,
    string rating,
    string price,
    string favorite,
    Action onClick)
        {
            Panel row = new Panel
            {
                Width = 800,
                Height = 45,
                BackColor = Color.White,
                Cursor = Cursors.Hand,
                Margin = new Padding(0, 0, 0, 3)
            };

            row.Controls.Add(CreateCell(name, 150));
            row.Controls.Add(CreateCell(category, 120, 150));
            row.Controls.Add(CreateCell(description, 250, 270));
            row.Controls.Add(CreateCell(rating, 80, 530));
            row.Controls.Add(CreateCell(price, 80, 620));
            row.Controls.Add(CreateCell(favorite, 80, 700));

            row.Click += (s, e) => onClick();
            foreach (Control c in row.Controls)
                c.Click += (s, e) => onClick();

            return row;
        }

        private Label CreateCell(string text, int width, int left = 0)
        {
            return new Label
            {
                Text = text,
                Width = width,
                Left = left,
                Dock = DockStyle.None,
                TextAlign = ContentAlignment.MiddleLeft,
                AutoEllipsis = true
            };
        }

        private Control CreateInfoLabel(string text)
        {
            return new Label
            {
                Text = text,
                AutoSize = true,
                Font = new Font("Segoe UI", 10, FontStyle.Italic),
                Margin = new Padding(10)
            };
        }

        private void OpenProduct(int productId)
        {
            new ProductInfo(productId).ShowDialog();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chkFavorite_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtLocation_TextChanged(object sender, EventArgs e)
        {

        }

        private void picImage_Click(object sender, EventArgs e)
        {

        }

        private void numRating_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void flpStoreProducts_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(
        "Are you sure you want to delete this store and all its products?",
        "Confirm Delete",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Warning
    );

            if (result != DialogResult.Yes)
                return;

            using var conn = new SQLiteConnection(connectionString);
            conn.Open();
            using var tx = conn.BeginTransaction();

            try
            {
                // 1️⃣ Delete all product prices associated with this store
                using (var cmd = new SQLiteCommand("DELETE FROM Prices WHERE StoreId = @StoreId;", conn, tx))
                {
                    cmd.Parameters.AddWithValue("@StoreId", storeId);
                    cmd.ExecuteNonQuery();
                }

                // 2️⃣ Optionally delete the products themselves if they belong only to this store
                // (Skip this if products are shared across stores via Prices table)
                // using (var cmd = new SQLiteCommand("DELETE FROM Products WHERE Id IN (SELECT ProductId FROM Prices WHERE StoreId = @StoreId);", conn, tx))
                // {
                //     cmd.Parameters.AddWithValue("@StoreId", storeId);
                //     cmd.ExecuteNonQuery();
                // }

                // 3️⃣ Delete the store
                using (var cmd = new SQLiteCommand("DELETE FROM Stores WHERE Id = @StoreId;", conn, tx))
                {
                    cmd.Parameters.AddWithValue("@StoreId", storeId);
                    cmd.ExecuteNonQuery();
                }

                tx.Commit();
                CustomMessageBox.Show("Store and its related data have been deleted successfully.");
                this.Close(); // close the StoreInfo form
            }
            catch (Exception ex)
            {
                tx.Rollback();
                CustomMessageBox.Show("Error deleting store: " + ex.Message);
            }
        }
    }
}
