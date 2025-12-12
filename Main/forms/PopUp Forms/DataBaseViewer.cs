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
    public partial class DataBaseViewer : Form
    {
        // Path to your existing database file
        private static string dbPath = @"C:\Users\conel\Downloads\Programs\Projects\Presyong_Ka-Piyu\Main\data\Presyong_Ka-Piyu_Database.db";

        public DataBaseViewer()
        {
            InitializeComponent();
            LoadTableNames();
            ThemeManager.ApplyTheme(this);

        }

        // 1. Load all tables into ComboBox
        private void LoadTableNames()
        {
            string query = "SELECT name FROM sqlite_master WHERE type='table' ORDER BY name;";

            using (SQLiteConnection conn = new SQLiteConnection($"Data Source={dbPath};Version=3;"))
            {
                conn.Open();
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        comboTables.Items.Add(reader.GetString(0));
                    }
                }
            }
        }

        // 2. Load selected table into DataGridView
        private void btnLoadTable_Click(object sender, EventArgs e)
        {
            if (comboTables.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a table.");
                return;
            }

            string tableName = comboTables.SelectedItem.ToString();
            LoadTableData(tableName);
        }

        // 3. Load table content
        private void LoadTableData(string tableName)
        {
            string query = $"SELECT * FROM {tableName};";

            using (SQLiteConnection conn = new SQLiteConnection($"Data Source={dbPath};Version=3;"))
            {
                conn.Open();
                using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, conn))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    gridView.DataSource = dt;
                }
            }
        }
    }
}