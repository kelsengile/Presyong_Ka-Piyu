namespace Presyong_Ka_Piyu.Main.forms.Main_Forms
{
    partial class Settings
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
            btnPanel = new Button();
            btnSearch = new Button();
            btnAdd = new Button();
            label1 = new Label();
            panel1 = new Panel();
            AccountSettinglabel = new Label();
            btnuserinfo = new Button();
            DataLabel = new Label();
            DeleteDatabutton = new Button();
            ViewTablesbutton = new Button();
            SystemInfolabel = new Label();
            Apperancelabel = new Label();
            SystemInfoTextlabel = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            chkDarkMode = new CheckBox();
            btnChangeFont = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
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
            btnSearch.Location = new Point(685, 27);
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
            btnAdd.Location = new Point(680, 607);
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
            label1.BackColor = SystemColors.GradientActiveCaption;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(92, 27);
            label1.Name = "label1";
            label1.Size = new Size(266, 30);
            label1.TabIndex = 4;
            label1.Text = "Settings  |  Presyong_Ka-Piyu";
            label1.Click += label1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(btnSearch);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-5, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(789, 85);
            panel1.TabIndex = 5;
            // 
            // AccountSettinglabel
            // 
            AccountSettinglabel.AutoSize = true;
            AccountSettinglabel.Font = new Font("Segoe UI", 13F);
            AccountSettinglabel.Location = new Point(53, 119);
            AccountSettinglabel.Name = "AccountSettinglabel";
            AccountSettinglabel.Size = new Size(313, 25);
            AccountSettinglabel.TabIndex = 6;
            AccountSettinglabel.Text = "Account Settings  |  User Information: ";
            AccountSettinglabel.Click += label2_Click;
            // 
            // btnuserinfo
            // 
            btnuserinfo.BackColor = SystemColors.Control;
            btnuserinfo.Location = new Point(87, 156);
            btnuserinfo.Name = "btnuserinfo";
            btnuserinfo.Size = new Size(627, 23);
            btnuserinfo.TabIndex = 7;
            btnuserinfo.Text = "Open User Information";
            btnuserinfo.UseVisualStyleBackColor = false;
            btnuserinfo.Click += btnuserinfo_Click;
            // 
            // DataLabel
            // 
            DataLabel.AutoSize = true;
            DataLabel.Font = new Font("Segoe UI", 13F);
            DataLabel.Location = new Point(53, 225);
            DataLabel.Name = "DataLabel";
            DataLabel.Size = new Size(122, 25);
            DataLabel.TabIndex = 9;
            DataLabel.Text = "Data Settings:";
            // 
            // DeleteDatabutton
            // 
            DeleteDatabutton.BackColor = SystemColors.Control;
            DeleteDatabutton.Location = new Point(87, 272);
            DeleteDatabutton.Name = "DeleteDatabutton";
            DeleteDatabutton.Size = new Size(298, 23);
            DeleteDatabutton.TabIndex = 10;
            DeleteDatabutton.Text = "Delete Data";
            DeleteDatabutton.UseVisualStyleBackColor = false;
            DeleteDatabutton.Click += DeleteDatabutton_Click;
            // 
            // ViewTablesbutton
            // 
            ViewTablesbutton.BackColor = SystemColors.Control;
            ViewTablesbutton.Location = new Point(421, 272);
            ViewTablesbutton.Name = "ViewTablesbutton";
            ViewTablesbutton.Size = new Size(293, 23);
            ViewTablesbutton.TabIndex = 11;
            ViewTablesbutton.Text = "View Tables";
            ViewTablesbutton.UseVisualStyleBackColor = false;
            ViewTablesbutton.Click += ViewTablesbutton_Click;
            // 
            // SystemInfolabel
            // 
            SystemInfolabel.AutoSize = true;
            SystemInfolabel.Font = new Font("Segoe UI", 13F);
            SystemInfolabel.Location = new Point(53, 479);
            SystemInfolabel.Name = "SystemInfolabel";
            SystemInfolabel.Size = new Size(172, 25);
            SystemInfolabel.TabIndex = 12;
            SystemInfolabel.Text = "System Information:";
            SystemInfolabel.Click += label2_Click_1;
            // 
            // Apperancelabel
            // 
            Apperancelabel.AutoSize = true;
            Apperancelabel.Font = new Font("Segoe UI", 13F);
            Apperancelabel.Location = new Point(53, 341);
            Apperancelabel.Name = "Apperancelabel";
            Apperancelabel.Size = new Size(101, 25);
            Apperancelabel.TabIndex = 13;
            Apperancelabel.Text = "Apperance:";
            // 
            // SystemInfoTextlabel
            // 
            SystemInfoTextlabel.AutoSize = true;
            SystemInfoTextlabel.Location = new Point(87, 524);
            SystemInfoTextlabel.Name = "SystemInfoTextlabel";
            SystemInfoTextlabel.Size = new Size(145, 15);
            SystemInfoTextlabel.TabIndex = 14;
            SystemInfoTextlabel.Text = "Application Version:   1.0.0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(87, 551);
            label2.Name = "label2";
            label2.Size = new Size(122, 15);
            label2.TabIndex = 15;
            label2.Text = "Build Data:   DEC 2025";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(87, 577);
            label3.Name = "label3";
            label3.Size = new Size(105, 15);
            label3.TabIndex = 16;
            label3.Text = "Data Version:   v1.0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(285, 524);
            label4.Name = "label4";
            label4.Size = new Size(137, 15);
            label4.TabIndex = 17;
            label4.Text = "Net Framework:  .NET 10";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(285, 551);
            label5.Name = "label5";
            label5.Size = new Size(133, 15);
            label5.TabIndex = 18;
            label5.Text = "Developed by: SlothFish";
            // 
            // chkDarkMode
            // 
            chkDarkMode.AutoSize = true;
            chkDarkMode.BackColor = SystemColors.GradientActiveCaption;
            chkDarkMode.Location = new Point(190, 388);
            chkDarkMode.Name = "chkDarkMode";
            chkDarkMode.Size = new Size(84, 19);
            chkDarkMode.TabIndex = 19;
            chkDarkMode.Text = "Dark Mode";
            chkDarkMode.UseVisualStyleBackColor = false;
            chkDarkMode.CheckedChanged += chkDarkMode_CheckedChanged;
            // 
            // btnChangeFont
            // 
            btnChangeFont.BackColor = SystemColors.Control;
            btnChangeFont.Location = new Point(459, 378);
            btnChangeFont.Name = "btnChangeFont";
            btnChangeFont.Size = new Size(199, 36);
            btnChangeFont.TabIndex = 20;
            btnChangeFont.Text = "Change Font";
            btnChangeFont.UseVisualStyleBackColor = false;
            btnChangeFont.Click += btnChangeFont_Click;
            // 
            // Settings
            // 
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(784, 661);
            Controls.Add(btnChangeFont);
            Controls.Add(chkDarkMode);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(SystemInfoTextlabel);
            Controls.Add(Apperancelabel);
            Controls.Add(SystemInfolabel);
            Controls.Add(ViewTablesbutton);
            Controls.Add(DeleteDatabutton);
            Controls.Add(DataLabel);
            Controls.Add(btnuserinfo);
            Controls.Add(AccountSettinglabel);
            Controls.Add(btnAdd);
            Controls.Add(btnPanel);
            Controls.Add(panel1);
            MaximumSize = new Size(800, 700);
            MinimumSize = new Size(800, 700);
            Name = "Settings";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Settings";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();


        }



        private System.Windows.Forms.Button btnPanel;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnAdd;
        private Label label1;
        private Panel panel1;
        

        #endregion

        private Label AccountSettinglabel;
        private Button btnuserinfo;
        private Label DataLabel;
        private Button DeleteDatabutton;
        private Button ViewTablesbutton;
        private Label SystemInfolabel;
        private Label Apperancelabel;
        private Label SystemInfoTextlabel;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private GroupBox grpAppearance;
        private CheckBox chkDarkMode;
        private Button btnChangeFont;
    }
}