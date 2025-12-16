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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResetPassword));
            txtEmail = new TextBox();
            txtOtp = new TextBox();
            txtNewPassword = new TextBox();
            txtConfirmPassword = new TextBox();
            btnSendOtp = new Button();
            btnReset = new Button();
            btnBack = new Button();
            resetpasslabel = new Label();
            emaillabel = new Label();
            OTPabel = new Label();
            newpasslabel = new Label();
            confirmpasslabel = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(74, 79);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(200, 23);
            txtEmail.TabIndex = 0;
            // 
            // txtOtp
            // 
            txtOtp.Location = new Point(74, 165);
            txtOtp.Name = "txtOtp";
            txtOtp.Size = new Size(200, 23);
            txtOtp.TabIndex = 1;
            // 
            // txtNewPassword
            // 
            txtNewPassword.Location = new Point(74, 209);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.PasswordChar = '*';
            txtNewPassword.Size = new Size(200, 23);
            txtNewPassword.TabIndex = 2;
            txtNewPassword.TextChanged += txtNewPassword_TextChanged;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(74, 253);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.PasswordChar = '*';
            txtConfirmPassword.Size = new Size(200, 23);
            txtConfirmPassword.TabIndex = 3;
            txtConfirmPassword.TextChanged += txtConfirmPassword_TextChanged;
            // 
            // btnSendOtp
            // 
            btnSendOtp.BackColor = SystemColors.Control;
            btnSendOtp.Location = new Point(127, 108);
            btnSendOtp.Name = "btnSendOtp";
            btnSendOtp.Size = new Size(90, 25);
            btnSendOtp.TabIndex = 4;
            btnSendOtp.Text = "Send OTP";
            btnSendOtp.UseVisualStyleBackColor = false;
            btnSendOtp.Click += btnSendOtp_Click;
            // 
            // btnReset
            // 
            btnReset.BackColor = SystemColors.Control;
            btnReset.Location = new Point(127, 282);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(90, 25);
            btnReset.TabIndex = 5;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = SystemColors.Control;
            btnBack.Location = new Point(127, 313);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(90, 25);
            btnBack.TabIndex = 6;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // resetpasslabel
            // 
            resetpasslabel.AutoSize = true;
            resetpasslabel.Font = new Font("Segoe UI", 15F);
            resetpasslabel.Location = new Point(124, 23);
            resetpasslabel.Name = "resetpasslabel";
            resetpasslabel.Size = new Size(144, 28);
            resetpasslabel.TabIndex = 7;
            resetpasslabel.Text = "Reset Password";
            // 
            // emaillabel
            // 
            emaillabel.AutoSize = true;
            emaillabel.Location = new Point(74, 61);
            emaillabel.Name = "emaillabel";
            emaillabel.Size = new Size(94, 15);
            emaillabel.TabIndex = 8;
            emaillabel.Text = "registered email:";
            emaillabel.Click += label1_Click;
            // 
            // OTPabel
            // 
            OTPabel.AutoSize = true;
            OTPabel.Location = new Point(74, 147);
            OTPabel.Name = "OTPabel";
            OTPabel.Size = new Size(29, 15);
            OTPabel.TabIndex = 9;
            OTPabel.Text = "OTP";
            OTPabel.Click += label2_Click;
            // 
            // newpasslabel
            // 
            newpasslabel.AutoSize = true;
            newpasslabel.Location = new Point(74, 191);
            newpasslabel.Name = "newpasslabel";
            newpasslabel.Size = new Size(85, 15);
            newpasslabel.TabIndex = 10;
            newpasslabel.Text = "new password:";
            newpasslabel.Click += label3_Click;
            // 
            // confirmpasslabel
            // 
            confirmpasslabel.AutoSize = true;
            confirmpasslabel.Location = new Point(74, 235);
            confirmpasslabel.Name = "confirmpasslabel";
            confirmpasslabel.Size = new Size(105, 15);
            confirmpasslabel.TabIndex = 11;
            confirmpasslabel.Text = "confirm password:";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(96, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(28, 32);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // ResetPassword
            // 
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(350, 360);
            Controls.Add(pictureBox1);
            Controls.Add(confirmpasslabel);
            Controls.Add(newpasslabel);
            Controls.Add(OTPabel);
            Controls.Add(emaillabel);
            Controls.Add(resetpasslabel);
            Controls.Add(txtEmail);
            Controls.Add(txtOtp);
            Controls.Add(txtNewPassword);
            Controls.Add(txtConfirmPassword);
            Controls.Add(btnSendOtp);
            Controls.Add(btnReset);
            Controls.Add(btnBack);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(366, 399);
            MinimumSize = new Size(366, 399);
            Name = "ResetPassword";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ResetPassword";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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

        private Label resetpasslabel;
        private Label emaillabel;
        private Label OTPabel;
        private Label newpasslabel;
        private Label confirmpasslabel;
        private PictureBox pictureBox1;
    }
}