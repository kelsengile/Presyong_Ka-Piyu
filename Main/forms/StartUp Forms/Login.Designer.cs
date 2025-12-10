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
            panel1 = new Panel();
            loginlabel = new Label();
            passwordlabel = new Label();
            usernamelabel = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(97, 184);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(200, 23);
            txtUsername.TabIndex = 0;
            txtUsername.TextChanged += txtUsername_TextChanged;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(97, 226);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(200, 23);
            txtPassword.TabIndex = 1;
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = SystemColors.Control;
            btnLogin.Location = new Point(147, 309);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(107, 28);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnSignup
            // 
            btnSignup.BackColor = SystemColors.Control;
            btnSignup.Location = new Point(147, 357);
            btnSignup.Name = "btnSignup";
            btnSignup.Size = new Size(107, 28);
            btnSignup.TabIndex = 3;
            btnSignup.Text = "Sign Up";
            btnSignup.UseVisualStyleBackColor = false;
            btnSignup.Click += btnSignup_Click;
            // 
            // btnForgot
            // 
            btnForgot.BackColor = SystemColors.GradientActiveCaption;
            btnForgot.FlatAppearance.BorderSize = 0;
            btnForgot.FlatStyle = FlatStyle.Flat;
            btnForgot.Font = new Font("Segoe UI", 7F);
            btnForgot.Location = new Point(147, 255);
            btnForgot.Name = "btnForgot";
            btnForgot.Size = new Size(107, 22);
            btnForgot.TabIndex = 4;
            btnForgot.Text = "Forgot Password?";
            btnForgot.UseVisualStyleBackColor = false;
            btnForgot.Click += btnForgot_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GradientActiveCaption;
            panel1.Controls.Add(loginlabel);
            panel1.Controls.Add(passwordlabel);
            panel1.Controls.Add(usernamelabel);
            panel1.Controls.Add(btnSignup);
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(txtUsername);
            panel1.Controls.Add(btnForgot);
            panel1.Location = new Point(408, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(380, 430);
            panel1.TabIndex = 5;
            panel1.Paint += panel1_Paint;
            // 
            // loginlabel
            // 
            loginlabel.AutoSize = true;
            loginlabel.Font = new Font("Segoe UI", 15F);
            loginlabel.Location = new Point(164, 97);
            loginlabel.Name = "loginlabel";
            loginlabel.Size = new Size(66, 28);
            loginlabel.TabIndex = 7;
            loginlabel.Text = "Log In";
            // 
            // passwordlabel
            // 
            passwordlabel.AutoSize = true;
            passwordlabel.Font = new Font("Segoe UI", 7F);
            passwordlabel.Location = new Point(97, 210);
            passwordlabel.Name = "passwordlabel";
            passwordlabel.Size = new Size(48, 12);
            passwordlabel.TabIndex = 6;
            passwordlabel.Text = "password:";
            passwordlabel.Click += label2_Click;
            // 
            // usernamelabel
            // 
            usernamelabel.AutoSize = true;
            usernamelabel.Font = new Font("Segoe UI", 7F);
            usernamelabel.Location = new Point(97, 166);
            usernamelabel.Name = "usernamelabel";
            usernamelabel.Size = new Size(50, 12);
            usernamelabel.TabIndex = 5;
            usernamelabel.Text = "username:";
            usernamelabel.Click += label1_Click;
            // 
            // Login
            // 
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            MaximumSize = new Size(816, 489);
            MinimumSize = new Size(816, 489);
            Name = "Login";
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnSignup;
        private System.Windows.Forms.Button btnForgot;
        private Panel panel1;
        private Label passwordlabel;
        private Label usernamelabel;
        private Label loginlabel;
    }
}
