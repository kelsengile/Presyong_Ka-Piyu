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
    public partial class UC_AddStore : UserControl
    {
        private readonly string connectionString = "Data Source=C:\\Users\\acer nitro v15\\source\\repos\\Presyong_Ka-Piyu\\Design\\Main\\data\\Presyong_Ka-Piyu_Database.db";
        private string imagePath = "";

        public UC_AddStore()
        {
            InitializeComponent();
            LoadLocations();
            LoadCategories();
        }

        // Developer-defined locations
        private void LoadLocations()
        {
            cmbLocation.DataSource = null; // clear previous items

            using var conn = new SQLiteConnection(connectionString);
            conn.Open();

            using var cmd = new SQLiteCommand("SELECT Id, LocationName FROM Locations ORDER BY Id", conn);
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());

            cmbLocation.DataSource = dt;
            cmbLocation.DisplayMember = "LocationName"; // what the user sees
            cmbLocation.ValueMember = "Id";             // the Id used for foreign key in Stores table

            if (dt.Rows.Count > 0)
                cmbLocation.SelectedIndex = 0; // select first location by default
        }

        private void LoadCategories()
        {
            using var conn = new SQLiteConnection(connectionString);
            conn.Open();

            using var cmd = new SQLiteCommand(
                "SELECT Id, CategoryName FROM Categories WHERE CategoryType='Store'", conn);

            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());

            cmbCategory.DataSource = dt;
            cmbCategory.DisplayMember = "CategoryName";
            cmbCategory.ValueMember = "Id";
            cmbCategory.SelectedIndex = -1; // No default selection
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using OpenFileDialog ofd = new OpenFileDialog
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
                CustomMessageBox.Show("Store name is required.");
                return;
            }

            using var conn = new SQLiteConnection(connectionString);
            conn.Open();

            try
            {
                using var cmd = new SQLiteCommand(@"
                    INSERT INTO Stores
                    (Name, LocationID, Contact, ImagePath, Description, Rating, CategoryId, IsFavorite)
                    VALUES
                    (@Name, @LocationID, @Contact, @ImagePath, @Description, @Rating, @CategoryId, @IsFavorite);", conn);

                cmd.Parameters.AddWithValue("@Name", txtName.Text);
                cmd.Parameters.AddWithValue("@LocationID", cmbLocation.SelectedValue);
                cmd.Parameters.AddWithValue("@Contact", txtContact.Text);
                cmd.Parameters.AddWithValue("@ImagePath", imagePath);
                cmd.Parameters.AddWithValue("@Description", txtDescription.Text);
                cmd.Parameters.AddWithValue("@Rating", numRating.Value);
                cmd.Parameters.AddWithValue("@CategoryId", cmbCategory.SelectedValue);
                cmd.Parameters.AddWithValue("@IsFavorite", chkFavorite.Checked ? 1 : 0);

                cmd.ExecuteNonQuery();

                CustomMessageBox.Show("Store added successfully!");
                var addForm = this.FindForm() as Add;
                addForm?.RestartAddForm();
            }
            catch (Exception ex)
            {
                CustomMessageBox.Show(ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            var addForm = this.FindForm() as Add;
            addForm?.RestartAddForm();
        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
