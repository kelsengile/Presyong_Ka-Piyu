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
            panel1 = new Panel();
            signuplabel = new Label();
            emaillabel = new Label();
            confirmpasswordlabel = new Label();
            passwordlabel = new Label();
            usernamelabel = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(89, 145);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(200, 23);
            txtUsername.TabIndex = 0;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(89, 189);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(200, 23);
            txtPassword.TabIndex = 1;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(89, 233);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.PasswordChar = '*';
            txtConfirmPassword.Size = new Size(200, 23);
            txtConfirmPassword.TabIndex = 2;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(89, 277);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(200, 23);
            txtEmail.TabIndex = 3;
            // 
            // btnSignup
            // 
            btnSignup.BackColor = SystemColors.Control;
            btnSignup.Location = new Point(145, 324);
            btnSignup.Name = "btnSignup";
            btnSignup.Size = new Size(90, 25);
            btnSignup.TabIndex = 4;
            btnSignup.Text = "Sign Up";
            btnSignup.UseVisualStyleBackColor = false;
            btnSignup.Click += btnSignup_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = SystemColors.Control;
            btnBack.Location = new Point(145, 365);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(90, 25);
            btnBack.TabIndex = 5;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GradientActiveCaption;
            panel1.Controls.Add(signuplabel);
            panel1.Controls.Add(emaillabel);
            panel1.Controls.Add(confirmpasswordlabel);
            panel1.Controls.Add(passwordlabel);
            panel1.Controls.Add(usernamelabel);
            panel1.Controls.Add(txtUsername);
            panel1.Controls.Add(btnBack);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(btnSignup);
            panel1.Controls.Add(txtConfirmPassword);
            panel1.Controls.Add(txtEmail);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(380, 430);
            panel1.TabIndex = 6;
            // 
            // signuplabel
            // 
            signuplabel.AutoSize = true;
            signuplabel.Font = new Font("Segoe UI", 15F);
            signuplabel.Location = new Point(145, 64);
            signuplabel.Name = "signuplabel";
            signuplabel.Size = new Size(82, 28);
            signuplabel.TabIndex = 10;
            signuplabel.Text = "Sign Up";
            // 
            // emaillabel
            // 
            emaillabel.AutoSize = true;
            emaillabel.Location = new Point(89, 259);
            emaillabel.Name = "emaillabel";
            emaillabel.Size = new Size(39, 15);
            emaillabel.TabIndex = 9;
            emaillabel.Text = "email:";
            // 
            // confirmpasswordlabel
            // 
            confirmpasswordlabel.AutoSize = true;
            confirmpasswordlabel.Location = new Point(89, 215);
            confirmpasswordlabel.Name = "confirmpasswordlabel";
            confirmpasswordlabel.Size = new Size(105, 15);
            confirmpasswordlabel.TabIndex = 8;
            confirmpasswordlabel.Text = "confirm password:";
            // 
            // passwordlabel
            // 
            passwordlabel.AutoSize = true;
            passwordlabel.Location = new Point(89, 171);
            passwordlabel.Name = "passwordlabel";
            passwordlabel.Size = new Size(60, 15);
            passwordlabel.TabIndex = 7;
            passwordlabel.Text = "password:";
            // 
            // usernamelabel
            // 
            usernamelabel.AutoSize = true;
            usernamelabel.Location = new Point(89, 127);
            usernamelabel.Name = "usernamelabel";
            usernamelabel.Size = new Size(62, 15);
            usernamelabel.TabIndex = 6;
            usernamelabel.Text = "username:";
            // 
            // Signup
            // 
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            MaximumSize = new Size(816, 489);
            MinimumSize = new Size(816, 489);
            Name = "Signup";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SignUp";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
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

        private Panel panel1;
        private Label usernamelabel;
        private Label signuplabel;
        private Label emaillabel;
        private Label confirmpasswordlabel;
        private Label passwordlabel;
    }
}