using Presyong_Ka_Piyu.Main.programs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Presyong_Ka_Piyu.Main.forms.PopUp_Forms
{
    public partial class ProductInfo : Form
    {
        private int productId;
        private string connectionString = "Data Source=C:\\Users\\conel\\Downloads\\Programs\\Projects\\Presyong_Ka-Piyu\\Main\\data\\Presyong_Ka-Piyu_Database.db";

        private TextBox txtName;
        private ComboBox cmbCategory;
        private TextBox txtDescription;
        private PictureBox picImage;
        private Button btnBrowse;
        private NumericUpDown numRating;
        private CheckBox chkFavorite;
        private ComboBox cmbStore;
        private NumericUpDown numPrice;
        private Button btnSave;
        private Button btnCancel;

        private string imagePath;

        public ProductInfo(int productId)
        {
            InitializeComponents();
            ThemeManager.ApplyTheme(this);

            this.productId = productId;
            
            LoadCategories();
            LoadStores();
            LoadProductData();
        }

        private void InitializeComponents()
        {
            this.Text = "Product Details";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Size = new Size(500, 600);

            txtName = new TextBox { Location = new Point(20, 20), Size = new Size(300, 23) };
            cmbCategory = new ComboBox { Location = new Point(20, 60), Size = new Size(300, 23), DropDownStyle = ComboBoxStyle.DropDownList };
            txtDescription = new TextBox { Location = new Point(20, 100), Size = new Size(300, 70), Multiline = true };
            picImage = new PictureBox { Location = new Point(20, 180), Size = new Size(150, 150), BorderStyle = BorderStyle.FixedSingle, SizeMode = PictureBoxSizeMode.Zoom };
            btnBrowse = new Button { Location = new Point(180, 180), Size = new Size(140, 30), Text = "Browse Image" };
            btnBrowse.Click += BtnBrowse_Click;
            numRating = new NumericUpDown { Location = new Point(20, 340), Minimum = 0, Maximum = 5, DecimalPlaces = 1 };
            chkFavorite = new CheckBox { Location = new Point(20, 380), Text = "Favorite" };
            cmbStore = new ComboBox { Location = new Point(20, 420), Size = new Size(300, 23), DropDownStyle = ComboBoxStyle.DropDownList };
            numPrice = new NumericUpDown { Location = new Point(20, 460), DecimalPlaces = 2, Minimum = 0, Maximum = 100000 };
            btnSave = new Button { Location = new Point(165, 500), Size = new Size(75, 30), Text = "Save" };
            btnSave.Click += BtnSave_Click;
            btnCancel = new Button { Location = new Point(245, 500), Size = new Size(75, 30), Text = "Cancel" };
            btnCancel.Click += (s, e) => this.Close();

            this.Controls.AddRange(new Control[] { txtName, cmbCategory, txtDescription, picImage, btnBrowse, numRating, chkFavorite, cmbStore, numPrice, btnSave, btnCancel });
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

        private void BtnBrowse_Click(object sender, EventArgs e)
        {
            using OpenFileDialog ofd = new OpenFileDialog { Filter = "Image Files|*.jpg;*.jpeg;*.png" };
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                imagePath = ofd.FileName;
                picImage.Image = Image.FromFile(imagePath);
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            using var conn = new SQLiteConnection(connectionString);
            conn.Open();
            using var tx = conn.BeginTransaction();
            try
            {
                // Update Product
                using (var cmd = new SQLiteCommand(@"
                    UPDATE Products SET 
                    Name=@Name, CategoryId=@CategoryId, Description=@Description, ImagePath=@ImagePath, Rating=@Rating, IsFavorite=@IsFavorite
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
                MessageBox.Show("Product updated successfully!");
                this.Close();
            }
            catch (Exception ex)
            {
                tx.Rollback();
                MessageBox.Show(ex.Message);
            }
        }
    }
}