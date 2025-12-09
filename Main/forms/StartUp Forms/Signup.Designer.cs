namespace Presyong_Ka_Piyu
{
    partial class Signup
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
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            txtConfirmPassword = new TextBox();
            txtEmail = new TextBox();
            btnSignup = new Button();
            btnBack = new Button();
            SuspendLayout();
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(37, 138);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(200, 23);
            txtUsername.TabIndex = 0;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(37, 183);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(200, 23);
            txtPassword.TabIndex = 1;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(37, 230);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.PasswordChar = '*';
            txtConfirmPassword.Size = new Size(200, 23);
            txtConfirmPassword.TabIndex = 2;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(37, 280);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(200, 23);
            txtEmail.TabIndex = 3;
            // 
            // btnSignup
            // 
            btnSignup.Location = new Point(95, 329);
            btnSignup.Name = "btnSignup";
            btnSignup.Size = new Size(90, 25);
            btnSignup.TabIndex = 4;
            btnSignup.Text = "Sign Up";
            btnSignup.Click += btnSignup_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(95, 398);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(90, 25);
            btnBack.TabIndex = 5;
            btnBack.Text = "Back";
            btnBack.Click += btnBack_Click;
            // 
            // Signup
            // 
            ClientSize = new Size(800, 450);
            Controls.Add(txtUsername);
            Controls.Add(txtPassword);
            Controls.Add(txtConfirmPassword);
            Controls.Add(txtEmail);
            Controls.Add(btnSignup);
            Controls.Add(btnBack);
            MaximumSize = new Size(816, 489);
            MinimumSize = new Size(816, 489);
            Name = "Signup";
            Text = "SignUp";
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnSignup;
        private System.Windows.Forms.Button btnBack;
    

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>




        #endregion
    }
}