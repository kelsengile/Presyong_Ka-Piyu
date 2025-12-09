namespace Presyong_Ka_Piyu.Main.forms
{
    partial class ResetPassword
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtOtp = new System.Windows.Forms.TextBox();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();

            this.btnSendOtp = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();

            // Email
            this.txtEmail.Location = new System.Drawing.Point(20, 20);
            this.txtEmail.Size = new System.Drawing.Size(200, 23);
            this.txtEmail.Name = "txtEmail";

            // OTP
            this.txtOtp.Location = new System.Drawing.Point(20, 60);
            this.txtOtp.Size = new System.Drawing.Size(200, 23);
            this.txtOtp.Name = "txtOtp";

            // New Password
            this.txtNewPassword.Location = new System.Drawing.Point(20, 100);
            this.txtNewPassword.Size = new System.Drawing.Size(200, 23);
            this.txtNewPassword.PasswordChar = '*';
            this.txtNewPassword.Name = "txtNewPassword";

            // Confirm Password
            this.txtConfirmPassword.Location = new System.Drawing.Point(20, 140);
            this.txtConfirmPassword.Size = new System.Drawing.Size(200, 23);
            this.txtConfirmPassword.PasswordChar = '*';
            this.txtConfirmPassword.Name = "txtConfirmPassword";

            // Send OTP button
            this.btnSendOtp.Location = new System.Drawing.Point(20, 180);
            this.btnSendOtp.Size = new System.Drawing.Size(90, 25);
            this.btnSendOtp.Text = "Send OTP";
            this.btnSendOtp.Click += new System.EventHandler(this.btnSendOtp_Click);

            // Reset button
            this.btnReset.Location = new System.Drawing.Point(130, 180);
            this.btnReset.Size = new System.Drawing.Size(90, 25);
            this.btnReset.Text = "Reset";
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);

            // Back button
            this.btnBack.Location = new System.Drawing.Point(75, 220);
            this.btnBack.Size = new System.Drawing.Size(90, 25);
            this.btnBack.Text = "Back";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);

            // Form
            this.ClientSize = new System.Drawing.Size(250, 260);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtOtp);
            this.Controls.Add(this.txtNewPassword);
            this.Controls.Add(this.txtConfirmPassword);
            this.Controls.Add(this.btnSendOtp);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnBack);
            this.Name = "ResetPassword";
        }

        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtOtp;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.TextBox txtConfirmPassword;

        private System.Windows.Forms.Button btnSendOtp;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnBack;






        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>


        #endregion
    }
}