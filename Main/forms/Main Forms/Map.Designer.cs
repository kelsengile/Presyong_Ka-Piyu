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
            ((System.ComponentModel.ISupportInitialize)mapBox).BeginInit();
            SuspendLayout();
            // 
            // mapBox
            // 
            mapBox.Image = Properties.Resources.MapImagePrototype;
            mapBox.Location = new Point(104, 105);
            mapBox.Name = "mapBox";
            mapBox.Size = new Size(798, 583);
            mapBox.SizeMode = PictureBoxSizeMode.Zoom;
            mapBox.TabIndex = 0;
            mapBox.TabStop = false;
            // 
            // btnPanel
            // 
            btnPanel.Location = new Point(-2, 38);
            btnPanel.Name = "btnPanel";
            btnPanel.Size = new Size(80, 48);
            btnPanel.TabIndex = 1;
            btnPanel.Text = "Menu";
            btnPanel.Click += btnPanel_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(770, 47);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(218, 30);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Search";
            btnSearch.Click += btnSearch_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(908, 658);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(80, 30);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Add";
            btnAdd.Click += btnAdd_Click;
            // 
            // Map
            // 
            ClientSize = new Size(1000, 700);
            Controls.Add(btnAdd);
            Controls.Add(mapBox);
            Controls.Add(btnPanel);
            Controls.Add(btnSearch);
            Name = "Map";
            Text = "Campus Map";
            ((System.ComponentModel.ISupportInitialize)mapBox).EndInit();
            ResumeLayout(false);
        }

        private System.Windows.Forms.PictureBox mapBox;
        private System.Windows.Forms.Button btnPanel;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnAdd;

        


        

        #endregion
    }

}