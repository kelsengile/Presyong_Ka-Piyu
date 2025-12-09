using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System;
using System.Data.SQLite;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;
using BCrypt.Net;

namespace Presyong_Ka_Piyu.Main.forms
{
    public partial class ResetPassword : Form
    {
        private string generatedOtp;
        private readonly string dbPath = @"Data Source=C:\Users\conel\Downloads\Programs\Projects\Presyong_Ka-Piyu\Main\data\Presyong_Ka-Piyu_Database.db";

        public ResetPassword()
        {
            InitializeComponent();
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var a = new MailAddress(email);
                return a.Address == email;
            }
            catch { return false; }
        }

        // SEND OTP
        private void btnSendOtp_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();

            if (email == "" || !IsValidEmail(email))
            {
                CustomMessageBox.Show("Please enter a valid email.");
                return;
            }

            // Generate OTP
            generatedOtp = new Random().Next(100000, 999999).ToString();

            try
            {
                string senderEmail = "presyongkapiyu@gmail.com";
                string senderPassword = "apof xxjk awdr xivt";

                MailMessage mail = new MailMessage();
                mail.From = new MailAddress(senderEmail);
                mail.To.Add(email);
                mail.Subject = "Your Password Reset OTP";
                mail.Body = $"Your OTP is: {generatedOtp}";

                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                smtp.Credentials = new NetworkCredential(senderEmail, senderPassword);
                smtp.EnableSsl = true;

                smtp.Send(mail);
                CustomMessageBox.Show("OTP sent to your email.");
            }
            catch (Exception ex)
            {
                CustomMessageBox.Show("Failed to send OTP: " + ex.Message);
            }
        }

        // RESET PASSWORD
        private void btnReset_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string otp = txtOtp.Text.Trim();
            string newPass = txtNewPassword.Text.Trim();
            string confirmPass = txtConfirmPassword.Text.Trim();

            if (email == "" || otp == "" || newPass == "" || confirmPass == "")
            {
                CustomMessageBox.Show("All fields are required.");
                return;
            }

            if (otp != generatedOtp)
            {
                CustomMessageBox.Show("Invalid OTP.");
                return;
            }

            if (newPass != confirmPass)
            {
                CustomMessageBox.Show("Passwords do not match.");
                return;
            }

            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(dbPath))
                {
                    conn.Open();

                    // Check if email exists
                    string checkQuery = "SELECT COUNT(*) FROM Users WHERE Email = @Email";
                    using (SQLiteCommand checkCmd = new SQLiteCommand(checkQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@Email", email);
                        long count = (long)checkCmd.ExecuteScalar();

                        if (count == 0)
                        {
                            CustomMessageBox.Show("Email not found.");
                            return;
                        }
                    }

                    // Hash new password
                    string hashedPass = BCrypt.Net.BCrypt.HashPassword(newPass);

                    // Update password
                    string updateQuery = "UPDATE Users SET PasswordHash = @Pass WHERE Email = @Email";

                    using (SQLiteCommand cmd = new SQLiteCommand(updateQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@Pass", hashedPass);
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.ExecuteNonQuery();
                    }

                    conn.Close();
                }

                CustomMessageBox.Show("Password reset successfully!");
                Login login = new Login();
                login.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                CustomMessageBox.Show("Error resetting password: " + ex.Message);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void txtConfirmPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNewPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}