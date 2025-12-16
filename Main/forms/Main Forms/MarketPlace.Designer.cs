namespace Presyong_Ka_Piyu.Main.forms.Main_Forms
{
    partial class MarketPlace
    {
        
        private FlowLayoutPanel flpStores;
        private Label lblLocation;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MarketPlace));
            lblLocation = new Label();
            flpStores = new FlowLayoutPanel();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblLocation
            // 
            lblLocation.BorderStyle = BorderStyle.Fixed3D;
            lblLocation.Font = new Font("Segoe UI", 15F);
            lblLocation.Location = new Point(224, 36);
            lblLocation.Name = "lblLocation";
            lblLocation.Size = new Size(341, 36);
            lblLocation.TabIndex = 0;
            lblLocation.TextAlign = ContentAlignment.TopCenter;
            lblLocation.Click += lblLocation_Click;
            // 
            // flpStores
            // 
            flpStores.AutoScroll = true;
            flpStores.Location = new Point(27, 119);
            flpStores.Name = "flpStores";
            flpStores.Size = new Size(731, 430);
            flpStores.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(lblLocation);
            panel1.Location = new Point(-4, -6);
            panel1.Name = "panel1";
            panel1.Size = new Size(792, 100);
            panel1.TabIndex = 3;
            // 
            // MarketPlace
            // 
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(784, 561);
            Controls.Add(flpStores);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MarketPlace";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MarketPlace";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
    }
}