using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;
using BCrypt.Net;

namespace Presyong_Ka_Piyu.Main.forms
{
    public partial class SendOtp : Form
    {
        private string generatedOtp;
        private readonly string dbPath = @"Data Source=C:\Users\conel\Downloads\Programs\Projects\Presyong_Ka-Piyu\Main\data\Presyong_Ka-Piyu_Database.db";

        public SendOtp()
        {
            InitializeComponent();
            SendOTPToEmail();
        }

        private void SendOTPToEmail()
        {
            generatedOtp = new Random().Next(100000, 999999).ToString();

            try
            {
                string senderEmail = "presyongkapiyu@gmail.com";
                string senderPassword = "apof xxjk awdr xivt";

                MailMessage mail = new MailMessage();
                mail.From = new MailAddress(senderEmail);
                mail.To.Add(Signup.PendingEmail);
                mail.Subject = "Your OTP Code";
                mail.Body = "Your OTP is: " + generatedOtp;

                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                smtp.Credentials = new NetworkCredential(senderEmail, senderPassword);
                smtp.EnableSsl = true;

                smtp.Send(mail);
                CustomMessageBox.Show("OTP sent!");
            }
            catch (Exception ex)
            {
                CustomMessageBox.Show("Failed to send OTP: " + ex.Message);
            }
        }

        private void btnVerify_Click(object sender, EventArgs e)
        {
            if (txtOtp.Text.Trim() != generatedOtp)
            {
                CustomMessageBox.Show("Invalid OTP.");
                return;
            }

            // Save new user
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(dbPath))
                {
                    conn.Open();

                    string hashedPassword = BCrypt.Net.BCrypt.HashPassword(Signup.PendingPassword);

                    string query = @"
                    INSERT INTO Users (Username, PasswordHash, Email)
                    VALUES (@u, @p, @e)";

                    using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@u", Signup.PendingUsername);
                        cmd.Parameters.AddWithValue("@p", hashedPassword);
                        cmd.Parameters.AddWithValue("@e", Signup.PendingEmail);
                        cmd.ExecuteNonQuery();
                    }

                    conn.Close();
                }

                CustomMessageBox.Show("Account created successfully!");
                Login login = new Login();
                login.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                CustomMessageBox.Show("Error creating account: " + ex.Message);
            }
        }

        private void btnResend_Click(object sender, EventArgs e)
        {
            SendOTPToEmail();
        }
    }
}
