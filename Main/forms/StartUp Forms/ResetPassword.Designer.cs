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
            txtEmail = new TextBox();
            txtOtp = new TextBox();
            txtNewPassword = new TextBox();
            txtConfirmPassword = new TextBox();
            btnSendOtp = new Button();
            btnReset = new Button();
            btnBack = new Button();
            SuspendLayout();
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(65, 86);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(200, 23);
            txtEmail.TabIndex = 0;
            // 
            // txtOtp
            // 
            txtOtp.Location = new Point(65, 171);
            txtOtp.Name = "txtOtp";
            txtOtp.Size = new Size(200, 23);
            txtOtp.TabIndex = 1;
            // 
            // txtNewPassword
            // 
            txtNewPassword.Location = new Point(65, 211);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.PasswordChar = '*';
            txtNewPassword.Size = new Size(200, 23);
            txtNewPassword.TabIndex = 2;
            txtNewPassword.TextChanged += txtNewPassword_TextChanged;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(65, 253);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.PasswordChar = '*';
            txtConfirmPassword.Size = new Size(200, 23);
            txtConfirmPassword.TabIndex = 3;
            txtConfirmPassword.TextChanged += txtConfirmPassword_TextChanged;
            // 
            // btnSendOtp
            // 
            btnSendOtp.Location = new Point(118, 128);
            btnSendOtp.Name = "btnSendOtp";
            btnSendOtp.Size = new Size(90, 25);
            btnSendOtp.TabIndex = 4;
            btnSendOtp.Text = "Send OTP";
            btnSendOtp.Click += btnSendOtp_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(118, 282);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(90, 25);
            btnReset.TabIndex = 5;
            btnReset.Text = "Reset";
            btnReset.Click += btnReset_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(118, 323);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(90, 25);
            btnBack.TabIndex = 6;
            btnBack.Text = "Back";
            btnBack.Click += btnBack_Click;
            // 
            // ResetPassword
            // 
            ClientSize = new Size(350, 360);
            Controls.Add(txtEmail);
            Controls.Add(txtOtp);
            Controls.Add(txtNewPassword);
            Controls.Add(txtConfirmPassword);
            Controls.Add(btnSendOtp);
            Controls.Add(btnReset);
            Controls.Add(btnBack);
            MaximumSize = new Size(366, 399);
            MinimumSize = new Size(366, 399);
            Name = "ResetPassword";
            Text = "ResetPassword";
            ResumeLayout(false);
            PerformLayout();
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