namespace Presyong_Ka_Piyu.Main.forms
{
    partial class CustomMessageBox
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
       
        private void InitializeComponent()
        {
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();

            // Label
            this.lblMessage.AutoSize = false;
            this.lblMessage.Location = new System.Drawing.Point(10, 10);
            this.lblMessage.Size = new System.Drawing.Size(260, 60);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // OK Button
            this.btnOK.Location = new System.Drawing.Point(95, 80);
            this.btnOK.Size = new System.Drawing.Size(80, 25);
            this.btnOK.Name = "btnOK";
            this.btnOK.Text = "OK";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);

            // CustomMessageBox form
            this.ClientSize = new System.Drawing.Size(280, 120);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnOK);
            this.Name = "CustomMessageBox";
            this.Text = "Message";
            this.Load += new System.EventHandler(this.CustomMessageBox_Load);
        }

        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Button btnOK;
    

        

        #endregion
    }
}