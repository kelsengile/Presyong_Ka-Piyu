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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomMessageBox));
            lblMessage = new Label();
            btnOK = new Button();
            SuspendLayout();
            // 
            // lblMessage
            // 
            lblMessage.Location = new Point(10, 10);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(260, 60);
            lblMessage.TabIndex = 0;
            lblMessage.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnOK
            // 
            btnOK.BackColor = SystemColors.Control;
            btnOK.Location = new Point(95, 80);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(80, 25);
            btnOK.TabIndex = 1;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = false;
            btnOK.Click += btnOK_Click;
            // 
            // CustomMessageBox
            // 
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(280, 120);
            Controls.Add(lblMessage);
            Controls.Add(btnOK);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "CustomMessageBox";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Message";
            Load += CustomMessageBox_Load;
            ResumeLayout(false);
        }

        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Button btnOK;
    

        

        #endregion
    }
}