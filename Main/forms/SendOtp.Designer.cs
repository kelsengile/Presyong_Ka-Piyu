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
            this.txtOtp = new System.Windows.Forms.TextBox();
            this.btnVerify = new System.Windows.Forms.Button();
            this.btnResend = new System.Windows.Forms.Button();

            // OTP Textbox
            this.txtOtp.Location = new System.Drawing.Point(20, 20);
            this.txtOtp.Size = new System.Drawing.Size(200, 23);
            this.txtOtp.Name = "txtOtp";

            // Verify Button
            this.btnVerify.Location = new System.Drawing.Point(20, 60);
            this.btnVerify.Size = new System.Drawing.Size(90, 25);
            this.btnVerify.Text = "Verify OTP";
            this.btnVerify.Click += new System.EventHandler(this.btnVerify_Click);

            // Resend OTP Button
            this.btnResend.Location = new System.Drawing.Point(130, 60);
            this.btnResend.Size = new System.Drawing.Size(90, 25);
            this.btnResend.Text = "Resend OTP";
            this.btnResend.Click += new System.EventHandler(this.btnResend_Click);

            this.ClientSize = new System.Drawing.Size(250, 120);
            this.Controls.Add(this.txtOtp);
            this.Controls.Add(this.btnVerify);
            this.Controls.Add(this.btnResend);
            this.Name = "SendOtp";

            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "SendOtp";
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