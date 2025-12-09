namespace Presyong_Ka_Piyu
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
            btnLogin = new Button();
            btnSignup = new Button();
            btnForgot = new Button();
            SuspendLayout();
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(521, 139);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(200, 23);
            txtUsername.TabIndex = 0;
            txtUsername.TextChanged += txtUsername_TextChanged;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(521, 201);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(200, 23);
            txtPassword.TabIndex = 1;
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(578, 316);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(90, 25);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Login";
            btnLogin.Click += btnLogin_Click;
            // 
            // btnSignup
            // 
            btnSignup.Location = new Point(578, 361);
            btnSignup.Name = "btnSignup";
            btnSignup.Size = new Size(90, 25);
            btnSignup.TabIndex = 3;
            btnSignup.Text = "Sign Up";
            btnSignup.Click += btnSignup_Click;
            // 
            // btnForgot
            // 
            btnForgot.Location = new Point(562, 249);
            btnForgot.Name = "btnForgot";
            btnForgot.Size = new Size(120, 25);
            btnForgot.TabIndex = 4;
            btnForgot.Text = "Forgot Password?";
            btnForgot.Click += btnForgot_Click;
            // 
            // Login
            // 
            ClientSize = new Size(800, 450);
            Controls.Add(txtUsername);
            Controls.Add(txtPassword);
            Controls.Add(btnLogin);
            Controls.Add(btnSignup);
            Controls.Add(btnForgot);
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnSignup;
        private System.Windows.Forms.Button btnForgot;

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>


        #endregion
    }
}
