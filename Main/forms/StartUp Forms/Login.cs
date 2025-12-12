using Microsoft.VisualBasic.ApplicationServices;
using Presyong_Ka_Piyu.Main.forms;
using Presyong_Ka_Piyu.Main.forms.Main_Forms;
using Presyong_Ka_Piyu.Main.programs;
using System.Data.SQLite;

namespace Presyong_Ka_Piyu
{


    public partial class Login : Form
    {
        private readonly string dbPath = @"Data Source=C:\Users\conel\Downloads\Programs\Projects\Presyong_Ka-Piyu\Main\data\Presyong_Ka-Piyu_Database.db";
        private object? result;
        // tote

        public Login()
        {
            
            InitializeComponent();
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (username == "" || password == "")
            {
                MessageBox.Show("Please enter both username and password.");
                return;
            }

            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(dbPath))
                {
                    conn.Open();

                    string query = "SELECT AccountId, PasswordHash FROM Users WHERE Username = @Username LIMIT 1";
                    using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Username", username);
                        using (SQLiteDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                int loggedInId = reader.GetInt32(0);
                                string storedHash = reader.GetString(1);

                                if (BCrypt.Net.BCrypt.Verify(password, storedHash))
                                {
                                    CustomMessageBox.Show("Log in successful!");

                                    var form = new UserInfo(loggedInId);

                                    Session.LoggedInUserId = loggedInId;
                                    

                                    Map main = new Map();
                                    main.Show();
                                    this.Hide();
                                }
                                else
                                {
                                    CustomMessageBox.Show("Incorrect password.");
                                }
                            }
                            else
                            {
                                CustomMessageBox.Show("Username not found.");
                            }
                        }
                    }

                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                CustomMessageBox.Show("Login failed: " + ex.Message);
            }
        }

        // SIGNUP BUTTON LOGIC
        private void btnSignup_Click(object sender, EventArgs e)
        {
            Signup signupForm = new Signup();
            signupForm.Show();

            this.Hide();
        }

        private void btnForgot_Click(object sender, EventArgs e)
        {
            ResetPassword rp = new ResetPassword();
            rp.Show();
            this.Hide();

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public static class Session
        {
            public static int LoggedInUserId;
        }
    }
}
