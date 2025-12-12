using Presyong_Ka_Piyu.Main.programs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Windows.Forms;

namespace Presyong_Ka_Piyu.Main.forms.PopUp_Forms
{
    public partial class ChangeEmailOTP : Form
    {
        private string generatedOtp;
        private int userId;
        private string newEmail;
        private readonly string dbPath = @"Data Source=C:\Users\conel\Downloads\Programs\Projects\Presyong_Ka-Piyu\Main\data\Presyong_Ka-Piyu_Database.db";

        public ChangeEmailOTP(int userId, string newEmail)
        {
            InitializeComponent();
            ThemeManager.ApplyTheme(this);

            this.userId = userId;
            this.newEmail = newEmail;

            SendOtpToEmail();
        }

        private void SendOtpToEmail()
        {
            generatedOtp = new Random().Next(100000, 999999).ToString();

            try
            {
                string senderEmail = "presyongkapiyu@gmail.com";
                string senderPassword = "apof xxjk awdr xivt";

                MailMessage mail = new MailMessage();
                mail.From = new MailAddress(senderEmail);
                mail.To.Add(newEmail);
                mail.Subject = "Your OTP Code";
                mail.Body = "Your OTP is: " + generatedOtp;

                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                smtp.Credentials = new NetworkCredential(senderEmail, senderPassword);
                smtp.EnableSsl = true;

                smtp.Send(mail);
                CustomMessageBox.Show("OTP sent to " + newEmail);
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

            // Update email in database
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(dbPath))
                {
                    conn.Open();
                    string query = "UPDATE Users SET Email=@Email WHERE AccountId=@id";
                    using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Email", newEmail);
                        cmd.Parameters.AddWithValue("@id", userId);
                        cmd.ExecuteNonQuery();
                    }
                }

                CustomMessageBox.Show("Email updated successfully!");
                this.Close();
            }
            catch (Exception ex)
            {
                CustomMessageBox.Show("Error updating email: " + ex.Message);
            }
        }

        private void btnResend_Click(object sender, EventArgs e)
        {
            SendOtpToEmail();
        }

        private void ChangeEmailOTP_Load(object sender, EventArgs e)
        {

        }

        private void OTPverlabel_Click(object sender, EventArgs e)
        {

        }
    }
}
