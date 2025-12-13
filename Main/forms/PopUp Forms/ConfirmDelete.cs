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
    public partial class ConfirmDelete : Form
    {
        // Path to your existing database file
        private static string dbPath = @"C:\Users\acer nitro v15\source\repos\Presyong_Ka-Piyu\Project moto ITEC 102\Main\data\Presyong_Ka-Piyu_Database.db";

        public ConfirmDelete()
        {
            InitializeComponent();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                DeleteAllData();
                CustomMessageBox.Show("All database data has been deleted. The application will now restart.");

                Application.Restart();
            }
            catch (Exception ex)
            {
                CustomMessageBox.Show("Error deleting data:\n" + ex.Message);
            }
        }

        private void DeleteAllData()
        {
            using (SQLiteConnection conn = new SQLiteConnection($"Data Source={dbPath};Version=3"))
            {
                conn.Open();

                string disableFK = "PRAGMA foreign_keys = OFF;";
                string enableFK = "PRAGMA foreign_keys = ON;";

                SQLiteCommand cmd = new SQLiteCommand(disableFK, conn);
                cmd.ExecuteNonQuery();

                string[] tables = { "Items", "Categories", "Stores", "Prices", "Users" };

                foreach (string table in tables)
                {
                    string deleteQuery = $"DELETE FROM {table};";
                    SQLiteCommand delCmd = new SQLiteCommand(deleteQuery, conn);
                    delCmd.ExecuteNonQuery();
                }

                SQLiteCommand cmd2 = new SQLiteCommand(enableFK, conn);
                cmd2.ExecuteNonQuery();
            }
        }
    }
}

    