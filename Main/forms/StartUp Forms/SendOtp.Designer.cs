namespace Presyong_Ka_Piyu.Main.forms
{
    partial class SendOtp
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
            txtOtp = new TextBox();
            btnVerify = new Button();
            btnResend = new Button();
            SuspendLayout();
            // 
            // txtOtp
            // 
            txtOtp.Location = new Point(72, 131);
            txtOtp.Name = "txtOtp";
            txtOtp.Size = new Size(200, 23);
            txtOtp.TabIndex = 0;
            // 
            // btnVerify
            // 
            btnVerify.Location = new Point(72, 192);
            btnVerify.Name = "btnVerify";
            btnVerify.Size = new Size(90, 25);
            btnVerify.TabIndex = 1;
            btnVerify.Text = "Verify OTP";
            btnVerify.Click += btnVerify_Click;
            // 
            // btnResend
            // 
            btnResend.Location = new Point(182, 192);
            btnResend.Name = "btnResend";
            btnResend.Size = new Size(90, 25);
            btnResend.TabIndex = 2;
            btnResend.Text = "Resend OTP";
            btnResend.Click += btnResend_Click;
            // 
            // SendOtp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(350, 360);
            Controls.Add(txtOtp);
            Controls.Add(btnVerify);
            Controls.Add(btnResend);
            MaximumSize = new Size(366, 399);
            MinimumSize = new Size(366, 399);
            Name = "SendOtp";
            Text = "SendOtp";
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.TextBox txtOtp;
        private System.Windows.Forms.Button btnVerify;
        private System.Windows.Forms.Button btnResend;

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        

        #endregion
    }
}