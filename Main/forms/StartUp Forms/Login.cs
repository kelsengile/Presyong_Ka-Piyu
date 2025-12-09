using Presyong_Ka_Piyu.Main.forms;
using System.Data.SQLite;

namespace Presyong_Ka_Piyu
{
    public partial class Login : Form
    {
        private readonly string dbPath = @"Data Source=C:\Users\conel\Downloads\Programs\Projects\Presyong_Ka-Piyu\Main\data\Presyong_Ka-Piyu_Database.db";

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

                    string query = "SELECT PasswordHash FROM Users WHERE Username = @Username LIMIT 1";
                    using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Username", username);
                        using (SQLiteDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string storedHash = reader.GetString(0);

                                if (BCrypt.Net.BCrypt.Verify(password, storedHash))
                                {
                                    MessageBox.Show("Login Successful!");

                                    MainForm main = new MainForm();
                                    main.Show();
                                    this.Hide();
                                }
                                else
                                {
                                    MessageBox.Show("Incorrect password.");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Username not found.");
                            }
                        }
                    }

                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Login failed: " + ex.Message);
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
    }
}
