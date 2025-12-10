namespace Presyong_Ka_Piyu.Main.forms
{
    partial class Map
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
            mapBox = new PictureBox();
            btnPanel = new Button();
            btnSearch = new Button();
            btnAdd = new Button();
            label1 = new Label();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)mapBox).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // mapBox
            // 
            mapBox.Image = Properties.Resources.MapImagePrototype;
            mapBox.Location = new Point(-5, 81);
            mapBox.Name = "mapBox";
            mapBox.Size = new Size(799, 583);
            mapBox.SizeMode = PictureBoxSizeMode.Zoom;
            mapBox.TabIndex = 0;
            mapBox.TabStop = false;
            mapBox.Click += mapBox_Click;
            // 
            // btnPanel
            // 
            btnPanel.BackColor = SystemColors.Control;
            btnPanel.Location = new Point(-5, 20);
            btnPanel.Name = "btnPanel";
            btnPanel.Size = new Size(86, 45);
            btnPanel.TabIndex = 1;
            btnPanel.Text = "Menu";
            btnPanel.UseVisualStyleBackColor = false;
            btnPanel.Click += btnMenu_Click;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = SystemColors.Control;
            btnSearch.Location = new Point(697, 35);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(80, 30);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = SystemColors.Control;
            btnAdd.Location = new Point(692, 619);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(80, 30);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(102, 30);
            label1.Name = "label1";
            label1.Size = new Size(135, 21);
            label1.TabIndex = 4;
            label1.Text = "Presyong_Ka-Piyu";
            label1.Click += label1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(btnSearch);
            panel1.Location = new Point(-5, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(799, 85);
            panel1.TabIndex = 5;
            // 
            // Map
            // 
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(784, 661);
            Controls.Add(label1);
            Controls.Add(btnAdd);
            Controls.Add(btnPanel);
            Controls.Add(panel1);
            Controls.Add(mapBox);
            MaximumSize = new Size(800, 700);
            MinimumSize = new Size(800, 700);
            Name = "Map";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Campus Map";
            Load += Map_Load;
            ((System.ComponentModel.ISupportInitialize)mapBox).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.PictureBox mapBox;
        private System.Windows.Forms.Button btnPanel;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnAdd;

        #endregion

        private Label label1;
        private Panel panel1;
    }

}