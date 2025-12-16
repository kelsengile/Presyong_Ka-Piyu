using Presyong_Ka_Piyu.Main.forms.Main_Forms;
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
    public partial class ChangePassword : Form
    {
        private int LoggedInUserId;
        private string connectionString = @"Data Source=C:\Users\conel\Downloads\Programs\Projects\Presyong_Ka-Piyu\Main\data\Presyong_Ka-Piyu_Database.db";

        public ChangePassword(int userId)
        {
            InitializeComponent();
            ThemeManager.ApplyTheme(this);
            LoggedInUserId = userId;
        }

        private void btn_ChangePasswordButton_Click(object sender, EventArgs e)
        {
            string currentPassword = txt_CurrentPassword.Text.Trim();
            string newPassword = txt_NewPassword.Text.Trim();
            string confirmPassword = txt_ConfirmPassword.Text.Trim();

            if (string.IsNullOrEmpty(currentPassword) ||
                string.IsNullOrEmpty(newPassword) ||
                string.IsNullOrEmpty(confirmPassword))
            {
                CustomMessageBox.Show("Please fill in all fields.");
                return;
            }

            if (newPassword != confirmPassword)
            {
                CustomMessageBox.Show("New Password and Confirm Password do not match.");
                return;
            }

            try
            {
                using (var con = new SQLiteConnection(connectionString))
                {
                    con.Open();

                    // 1️⃣ Get current hashed password from database
                    string selectQuery = "SELECT PasswordHash FROM Users WHERE AccountId=@id";
                    string storedHash = null;

                    using (var cmd = new SQLiteCommand(selectQuery, con))
                    {
                        cmd.Parameters.AddWithValue("@id", LoggedInUserId);
                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                                storedHash = reader["PasswordHash"].ToString();
                        }
                    }

                    if (storedHash == null)
                    {
                        CustomMessageBox.Show("User not found.");
                        return;
                    }

                    // 2️⃣ Verify current password
                    if (!BCrypt.Net.BCrypt.Verify(currentPassword, storedHash))
                    {
                        CustomMessageBox.Show("Current password is incorrect.");
                        return;
                    }

                    // 3️⃣ Hash the new password
                    string newHashedPassword = BCrypt.Net.BCrypt.HashPassword(newPassword);

                    // 4️⃣ Update the database
                    string updateQuery = "UPDATE Users SET PasswordHash=@newHash WHERE AccountId=@id";
                    using (var cmd = new SQLiteCommand(updateQuery, con))
                    {
                        cmd.Parameters.AddWithValue("@newHash", newHashedPassword);
                        cmd.Parameters.AddWithValue("@id", LoggedInUserId);
                        cmd.ExecuteNonQuery();
                    }

                    CustomMessageBox.Show("Password changed successfully!");
                    this.Close();
                    changepassresetpassclose();
                    Login login = new Login();
                    login.Show();
                }
            }
            catch (Exception ex)
            {
                CustomMessageBox.Show("Error changing password: " + ex.Message);
            }
        }




        private void btn_ForgotPassword_Click(object sender, EventArgs e)
        {
            // Open the forgot/reset password form
            ResetPassword rp = new ResetPassword();
            rp.ShowDialog();
            this.Close();
            changepassresetpassclose();

        }

        private void changepassresetpassclose()
        {
            for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
            {
                Form frm = Application.OpenForms[i];

                if (frm is PopUp_Forms.Menu ||
                    frm is UserInfo ||
                    frm is Add ||
                    frm is StoreInfo ||
                    frm is ConfirmDelete ||
                    frm is DataBaseViewer ||
                    frm is ProductInfo ||
                    frm is Search ||
                    frm is ChangePassword
                    )
                {
                    frm.Close();
                }
            }
        }
    }
}