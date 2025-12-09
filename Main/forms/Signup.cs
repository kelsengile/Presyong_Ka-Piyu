using BCrypt.Net;
using Presyong_Ka_Piyu.Main.forms;
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

namespace Presyong_Ka_Piyu
{
    public partial class Signup : Form
    {
        public static string PendingUsername;
        public static string PendingPassword;
        public static string PendingEmail;

        public Signup()
        {
            InitializeComponent();
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            string confirmPassword = txtConfirmPassword.Text.Trim();
            string email = txtEmail.Text.Trim();

            if (username == "" || password == "" || confirmPassword == "" || email == "")
            {
                MessageBox.Show("Please fill all fields.");
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match.");
                return;
            }

            // Save temporarily
            PendingUsername = username;
            PendingPassword = password;
            PendingEmail = email;

            // Open OTP window
            SendOtp otpForm = new SendOtp();
            otpForm.Show();
            this.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
