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
            ThemeManager.ApplyTheme(this);

            this.storeId = storeId;

            LoadCategories();
            LoadStoreData();
            LoadLocations();

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

            if (dt.Rows.Count > 0)
                cmbLocation.SelectedIndex = 0;
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
                cmbLocation.SelectedValue = reader["LocationId"];
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
            MessageBox.Show("Store updated successfully!");
            this.Close();
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
    }
}