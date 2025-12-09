using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;
using BCrypt.Net;

namespace Presyong_Ka_Piyu
{
    public partial class Signup : Form
    {
        private readonly string dbPath = @"Data Source=C:\Users\conel\Downloads\Programs\Projects\Presyong_Ka-Piyu\Main\data\Presyong_Ka-Piyu_Database.db";

        public Signup()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (username == "" || password == "")
            {
                MessageBox.Show("Please enter a username and password.");
                return;
            }

            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(dbPath))
                {
                    conn.Open();

                    // Check if username already exists
                    string checkQuery = "SELECT COUNT(*) FROM Users WHERE Username = @Username";
                    using (SQLiteCommand checkCmd = new SQLiteCommand(checkQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@Username", username);
                        long count = (long)checkCmd.ExecuteScalar();

                        if (count > 0)
                        {
                            MessageBox.Show("Username already taken.");
                            return;
                        }
                    }

                    // Hash password using BCrypt
                    string hashedPassword = BCrypt.Net.BCrypt.HashPassword(password);

                    // Insert user into database
                    string insertQuery = @"
                        INSERT INTO Users (Username, PasswordHash)
                        VALUES (@Username, @PasswordHash)";

                    using (SQLiteCommand cmd = new SQLiteCommand(insertQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@Username", username);
                        cmd.Parameters.AddWithValue("@PasswordHash", hashedPassword);
                        cmd.ExecuteNonQuery();
                    }

                    conn.Close();
                }

                MessageBox.Show("Account created successfully!");

                // Go back to login form
                Login login = new Login();
                login.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Signup failed: " + ex.Message);
            }
        }

        // BACK BUTTON LOGIC
        private void btnBack_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void Signup_Load(object sender, EventArgs e)
        {

        }
    }
}
