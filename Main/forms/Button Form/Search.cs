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


    public partial class Search : Form
    {
        private readonly string connectionString = "Data Source=C:\\Users\\conel\\Downloads\\Programs\\Projects\\Presyong_Ka-Piyu\\Main\\data\\Presyong_Ka-Piyu_Database.db";

        public Search()
        {
            InitializeComponent();
            ThemeManager.ApplyTheme(this);
        }

        private void Search_Load(object sender, EventArgs e)
        {
            LoadDefaultView();
        }

        // =========================
        // SEARCH HANDLER
        // =========================
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text))
                LoadDefaultView();
            else
                LoadSearchResults(txtSearch.Text.Trim());
        }

        // =========================
        // DEFAULT VIEW
        // =========================
        private void LoadDefaultView()
        {
            flpResults.Controls.Clear();

            LoadSection("Favorites: ", true, false);
            LoadSection("Suggestions: ", false, false);
            LoadSection("General: ", false, true);
        }

        // =========================
        // SEARCH RESULTS VIEW
        // =========================
        private void LoadSearchResults(string keyword)
        {
            flpResults.Controls.Clear();
            flpResults.Controls.Add(CreateHeader("Results: "));

            bool hasResults = false;

            hasResults |= LoadShops(keyword, null, false);
            hasResults |= LoadProducts(keyword, null, false);

            if (!hasResults)
            {
                flpResults.Controls.Add(CreateInfoLabel("No results found."));
            }
        }

        // =========================
        // SECTION LOADER
        // =========================
        private void LoadSection(string title, bool favoritesOnly, bool general)
        {
            flpResults.Controls.Add(CreateHeader(title));

            LoadShops(null, favoritesOnly, general, 3);
            LoadProducts(null, favoritesOnly, general, 3);
        }

        // =========================
        // SHOPS
        // =========================
        private bool LoadShops(string keyword, bool? favoritesOnly, bool general, int limit = 0)
        {
            bool hasData = false;

            using var conn = new SQLiteConnection(connectionString);
            conn.Open();

            string sql = "SELECT Id, Name, LocationID FROM Stores WHERE 1=1 ";

            if (!string.IsNullOrEmpty(keyword))
                sql += "AND Name LIKE @Keyword ";

            if (favoritesOnly == true)
                sql += "AND IsFavorite = 1 ";

            if (favoritesOnly == false && !general)
                sql += "AND IsFavorite = 0 ";

            sql += "ORDER BY Name ";
            if (limit > 0) sql += $"LIMIT {limit};";

            using var cmd = new SQLiteCommand(sql, conn);
            if (!string.IsNullOrEmpty(keyword))
                cmd.Parameters.AddWithValue("@Keyword", $"%{keyword}%");

            using var reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                flpResults.Controls.Add(CreateSubHeader("Shops: "));

                while (reader.Read())
                {
                    int id = Convert.ToInt32(reader["Id"]); // capture the value in a local variable
                    string name = reader["Name"].ToString();
                    string location = reader["LocationID"].ToString();

                    flpResults.Controls.Add(CreateItem(
                        name,
                        location,
                        () => OpenStore(id) // use the captured id
                    ));
                }
            }

            return hasData;
        }

        // =========================
        // PRODUCTS
        // =========================
        private bool LoadProducts(string keyword, bool? favoritesOnly, bool general, int limit = 0)
        {
            bool hasData = false;

            using var conn = new SQLiteConnection(connectionString);
            conn.Open();

            string sql = @"
                SELECT P.Id, P.Name, PR.Price
                FROM Products P
                LEFT JOIN Prices PR ON PR.ProductId = P.Id
                WHERE 1=1 ";

            if (!string.IsNullOrEmpty(keyword))
                sql += "AND P.Name LIKE @Keyword ";

            if (favoritesOnly == true)
                sql += "AND P.IsFavorite = 1 ";

            if (favoritesOnly == false && !general)
                sql += "AND P.IsFavorite = 0 ";

            sql += "ORDER BY P.Name ";
            if (limit > 0) sql += $"LIMIT {limit};";

            using var cmd = new SQLiteCommand(sql, conn);
            if (!string.IsNullOrEmpty(keyword))
                cmd.Parameters.AddWithValue("@Keyword", $"%{keyword}%");

            using var reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                flpResults.Controls.Add(CreateSubHeader("Products: "));

                while (reader.Read())
                {
                    hasData = true;

                    int id = Convert.ToInt32(reader["Id"]);
                    string name = reader["Name"].ToString();
                    string price = $"₱{reader["Price"]}";

                    flpResults.Controls.Add(CreateItem(
                        name,
                        price,
                        () => OpenProduct(id)
                    ));
                }
            }

            return hasData;
        }

        // =========================
        // UI HELPERS
        // =========================
        private Control CreateHeader(string text)
        {
            return new Label
            {
                Text = text,
                Font = new Font("Segoe UI", 12, FontStyle.Bold),
                AutoSize = true,
                Margin = new Padding(5, 15, 5, 5)
            };
        }

        private Control CreateSubHeader(string text)
        {
            return new Label
            {
                Text = text,
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                AutoSize = true,
                Margin = new Padding(15, 5, 5, 5)
            };
        }

        private Control CreateItem(string left, string right, Action onClick)
        {
            Panel panel = new Panel
            {
                Width = 460,
                Height = 35,
                Cursor = Cursors.Hand,
                Margin = new Padding(25, 2, 5, 2)
            };

            Label lbl = new Label
            {
                Text = $"{left} | {right}",
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleLeft
            };

            panel.Controls.Add(lbl);
            panel.Click += (s, e) => onClick();
            lbl.Click += (s, e) => onClick();

            return panel;
        }

        private Control CreateInfoLabel(string text)
        {
            return new Label
            {
                Text = text,
                Font = new Font("Segoe UI", 10, FontStyle.Italic),
                AutoSize = true,
                Margin = new Padding(20)
            };
        }

        // =========================
        // NAVIGATION STUBS
        // =========================

        private void OpenStore(int storeId)
        {
            new StoreInfo(storeId).ShowDialog();
        }

        private void OpenProduct(int productId)
        {
            new ProductInfo(productId).ShowDialog();

        }

    }
}