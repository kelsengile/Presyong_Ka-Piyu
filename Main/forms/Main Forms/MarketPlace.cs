using Presyong_Ka_Piyu.Main.forms.PopUp_Forms;
using Presyong_Ka_Piyu.Main.programs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Presyong_Ka_Piyu.Main.forms.Main_Forms
{
    public partial class MarketPlace : Form
    {

        private int locationId;
        private string connectionString = @"Data Source=C:\Users\conel\Downloads\Programs\Projects\Presyong_Ka-Piyu\Main\data\Presyong_Ka-Piyu_Database.db";

        public MarketPlace(int locationId, string locationName)
        {
            InitializeComponent();
            ThemeManager.ApplyTheme(this);
            this.locationId = locationId;
            lblLocation.Text = $"MarketPlace: {locationName}";
            LoadStores();
        }

        private void LoadStores()
        {
            flpStores.Controls.Clear();

            using var conn = new SQLiteConnection(connectionString);
            conn.Open();
            using var cmd = new SQLiteCommand(
    @"SELECT Id, Name, Description, ImagePath, Rating, IsFavorite 
      FROM Stores 
      WHERE LocationId = @LocationId", conn);
            cmd.Parameters.AddWithValue("@LocationId", locationId);
            using var reader = cmd.ExecuteReader();

            if (!reader.HasRows)
            {
                Label lblNoStores = new Label
                {
                    Text = "No stores available in this location.",
                    AutoSize = true,
                    Font = new Font("Segoe UI", 12, FontStyle.Italic),
                    ForeColor = Color.Gray,
                    Margin = new Padding(10)
                };
                flpStores.Controls.Add(lblNoStores);
                return;
            }

            while (reader.Read())
            {
                int storeId = Convert.ToInt32(reader["Id"]);
                string name = reader["Name"].ToString();
                string desc = reader["Description"].ToString();
                string imagePath = reader["ImagePath"].ToString();
                decimal rating = Convert.ToDecimal(reader["Rating"]);
                bool isFavorite = Convert.ToInt32(reader["IsFavorite"]) == 1;


                flpStores.Controls.Add(CreateStoreBox(storeId, name, desc, imagePath, rating, isFavorite));
            }
        }

        private Control CreateStoreBox(int storeId, string name, string description, string imagePath, decimal rating, bool isFavorite)
        {
            Panel panel = new Panel
            {
                Size = new Size(220, 250),
                Margin = new Padding(10),
                BackColor = isFavorite ? Color.FromArgb(255, 250, 230) : Color.White,
                BorderStyle = BorderStyle.FixedSingle,
                Cursor = Cursors.Hand
            };



            PictureBox pic = new PictureBox
            {
                Size = new Size(200, 150),
                Location = new Point(10, 10),
                SizeMode = PictureBoxSizeMode.Zoom,
                Image = File.Exists(imagePath) ? Image.FromFile(imagePath) : null,
                BackColor = Color.LightGray
            };

            Label lblName = new Label
            {
                Text = name,
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                Location = new Point(10, 170),
                AutoSize = false,
                Size = new Size(200, 20)
            };

            Label lblDesc = new Label
            {
                Text = description,
                Font = new Font("Segoe UI", 9),
                Location = new Point(10, 190),
                Size = new Size(200, 40),
                AutoEllipsis = true
            };

            Label lblRating = new Label
            {
                Text = $"Rating: {rating:0.0}",
                Font = new Font("Segoe UI", 9),
                Location = new Point(10, 230),
                AutoSize = true
            };

            Label lblFavorite = new Label
            {
                Text = isFavorite ? "⭐ Favorite" : "",
                Font = new Font("Segoe UI", 9, FontStyle.Bold),
                ForeColor = isFavorite ? Color.Goldenrod : Color.Gray,
                Location = new Point(110, 230),
                AutoSize = true
            };

            panel.Controls.Add(pic);
            panel.Controls.Add(lblName);
            panel.Controls.Add(lblDesc);
            panel.Controls.Add(lblRating);
            panel.Controls.Add(lblFavorite);

            panel.Click += (s, e) => OpenStoreInfo(storeId);
            foreach (Control c in panel.Controls) c.Click += (s, e) => OpenStoreInfo(storeId);

            return panel;
        }

        private void OpenStoreInfo(int storeId)
        {
            new StoreInfo(storeId).ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblLocation_Click(object sender, EventArgs e)
        {

        }
    }
}
