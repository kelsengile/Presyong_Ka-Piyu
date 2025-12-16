namespace Presyong_Ka_Piyu.Main.forms
{
    partial class Map
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private PictureBox mapBox;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Map));
            btnPanel = new Button();
            btnSearch = new Button();
            btnAdd = new Button();
            label1 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            btn_CIT2 = new Button();
            btn_Cafeteria1 = new Button();
            btn_gate1 = new Button();
            btn_CIT = new Button();
            btn_Cafeteria2 = new Button();
            btn_XeroxService = new Button();
            btn_PrintingService2 = new Button();
            btn_BAO = new Button();
            btn_Gate2 = new Button();
            btn_ActivityCenter = new Button();
            btn_CCS = new Button();
            btn_CTECAS = new Button();
            btn_CCJE = new Button();
            btn_CBAA = new Button();
            btn_CIHTM = new Button();
            btn_CONAH = new Button();
            btn_COE = new Button();
            btn_Automotive = new Button();
            btn_Hotel = new Button();
            btn_Church = new Button();
            btn_Admin = new Button();
            btn_Library = new Button();
            btn_Court = new Button();
            btn_TheGears = new Button();
            btn_OpenField = new Button();
            btn_GrandStand = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
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
            btnAdd.Location = new Point(701, 628);
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
            label1.Location = new Point(92, 24);
            label1.Name = "label1";
            label1.Size = new Size(519, 30);
            label1.TabIndex = 4;
            label1.Text = "LSPU Main Campus Map (Santa Cruz)  |  Presyong_Ka-Piyu";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnSearch);
            panel1.Location = new Point(-5, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(799, 85);
            panel1.TabIndex = 5;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Control;
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.BackgroundImageLayout = ImageLayout.Zoom;
            panel2.Controls.Add(btn_CIT2);
            panel2.Controls.Add(btn_Cafeteria1);
            panel2.Controls.Add(btn_gate1);
            panel2.Controls.Add(btn_CIT);
            panel2.Controls.Add(btn_Cafeteria2);
            panel2.Controls.Add(btn_XeroxService);
            panel2.Controls.Add(btn_PrintingService2);
            panel2.Controls.Add(btn_BAO);
            panel2.Controls.Add(btn_Gate2);
            panel2.Controls.Add(btn_ActivityCenter);
            panel2.Controls.Add(btn_CCS);
            panel2.Controls.Add(btn_CTECAS);
            panel2.Controls.Add(btn_CCJE);
            panel2.Controls.Add(btn_CBAA);
            panel2.Controls.Add(btn_CIHTM);
            panel2.Controls.Add(btn_CONAH);
            panel2.Controls.Add(btn_COE);
            panel2.Controls.Add(btn_Automotive);
            panel2.Controls.Add(btn_Hotel);
            panel2.Controls.Add(btn_Church);
            panel2.Controls.Add(btn_Admin);
            panel2.Controls.Add(btn_Library);
            panel2.Controls.Add(btn_Court);
            panel2.Controls.Add(btn_TheGears);
            panel2.Controls.Add(btn_OpenField);
            panel2.Controls.Add(btn_GrandStand);
            panel2.Location = new Point(12, 84);
            panel2.Name = "panel2";
            panel2.Size = new Size(760, 559);
            panel2.TabIndex = 6;
            panel2.Paint += panel2_Paint;
            // 
            // btn_CIT2
            // 
            btn_CIT2.BackgroundImage = (Image)resources.GetObject("btn_CIT2.BackgroundImage");
            btn_CIT2.BackgroundImageLayout = ImageLayout.Zoom;
            btn_CIT2.FlatAppearance.BorderSize = 0;
            btn_CIT2.FlatStyle = FlatStyle.Flat;
            btn_CIT2.Location = new Point(129, -13);
            btn_CIT2.Name = "btn_CIT2";
            btn_CIT2.Size = new Size(68, 60);
            btn_CIT2.TabIndex = 25;
            btn_CIT2.UseVisualStyleBackColor = true;
            btn_CIT2.Click += btn_CIT2_Click;
            // 
            // btn_Cafeteria1
            // 
            btn_Cafeteria1.BackgroundImage = (Image)resources.GetObject("btn_Cafeteria1.BackgroundImage");
            btn_Cafeteria1.BackgroundImageLayout = ImageLayout.Zoom;
            btn_Cafeteria1.FlatAppearance.BorderSize = 0;
            btn_Cafeteria1.FlatStyle = FlatStyle.Flat;
            btn_Cafeteria1.Location = new Point(234, 255);
            btn_Cafeteria1.Name = "btn_Cafeteria1";
            btn_Cafeteria1.Size = new Size(126, 45);
            btn_Cafeteria1.TabIndex = 1;
            btn_Cafeteria1.UseVisualStyleBackColor = true;
            btn_Cafeteria1.Click += btn_Cafeteria1_Click;
            // 
            // btn_gate1
            // 
            btn_gate1.BackgroundImage = (Image)resources.GetObject("btn_gate1.BackgroundImage");
            btn_gate1.BackgroundImageLayout = ImageLayout.Zoom;
            btn_gate1.FlatAppearance.BorderSize = 0;
            btn_gate1.FlatStyle = FlatStyle.Flat;
            btn_gate1.Location = new Point(347, 530);
            btn_gate1.Name = "btn_gate1";
            btn_gate1.Size = new Size(112, 44);
            btn_gate1.TabIndex = 0;
            btn_gate1.UseVisualStyleBackColor = true;
            btn_gate1.Click += btn_gate1_Click_1;
            // 
            // btn_CIT
            // 
            btn_CIT.BackgroundImage = (Image)resources.GetObject("btn_CIT.BackgroundImage");
            btn_CIT.BackgroundImageLayout = ImageLayout.Zoom;
            btn_CIT.FlatAppearance.BorderSize = 0;
            btn_CIT.FlatStyle = FlatStyle.Flat;
            btn_CIT.Location = new Point(130, 103);
            btn_CIT.Name = "btn_CIT";
            btn_CIT.Size = new Size(67, 23);
            btn_CIT.TabIndex = 2;
            btn_CIT.UseVisualStyleBackColor = true;
            btn_CIT.Click += btn_CIT_Click;
            // 
            // btn_Cafeteria2
            // 
            btn_Cafeteria2.BackgroundImage = (Image)resources.GetObject("btn_Cafeteria2.BackgroundImage");
            btn_Cafeteria2.BackgroundImageLayout = ImageLayout.Zoom;
            btn_Cafeteria2.FlatAppearance.BorderSize = 0;
            btn_Cafeteria2.FlatStyle = FlatStyle.Flat;
            btn_Cafeteria2.Location = new Point(203, 214);
            btn_Cafeteria2.Name = "btn_Cafeteria2";
            btn_Cafeteria2.Size = new Size(75, 35);
            btn_Cafeteria2.TabIndex = 2;
            btn_Cafeteria2.UseVisualStyleBackColor = true;
            btn_Cafeteria2.Click += btn_Cafeteria2_Click;
            // 
            // btn_XeroxService
            // 
            btn_XeroxService.BackgroundImage = (Image)resources.GetObject("btn_XeroxService.BackgroundImage");
            btn_XeroxService.BackgroundImageLayout = ImageLayout.Zoom;
            btn_XeroxService.FlatAppearance.BorderSize = 0;
            btn_XeroxService.FlatStyle = FlatStyle.Flat;
            btn_XeroxService.Location = new Point(302, 306);
            btn_XeroxService.Name = "btn_XeroxService";
            btn_XeroxService.Size = new Size(70, 38);
            btn_XeroxService.TabIndex = 3;
            btn_XeroxService.UseVisualStyleBackColor = true;
            btn_XeroxService.Click += btn_XeroxService_Click_1;
            // 
            // btn_PrintingService2
            // 
            btn_PrintingService2.BackgroundImage = (Image)resources.GetObject("btn_PrintingService2.BackgroundImage");
            btn_PrintingService2.BackgroundImageLayout = ImageLayout.Zoom;
            btn_PrintingService2.FlatAppearance.BorderSize = 0;
            btn_PrintingService2.FlatStyle = FlatStyle.Flat;
            btn_PrintingService2.Location = new Point(183, 168);
            btn_PrintingService2.Name = "btn_PrintingService2";
            btn_PrintingService2.Size = new Size(84, 40);
            btn_PrintingService2.TabIndex = 4;
            btn_PrintingService2.UseVisualStyleBackColor = true;
            btn_PrintingService2.Click += btn_PrintingService2_Click;
            // 
            // btn_BAO
            // 
            btn_BAO.BackgroundImage = (Image)resources.GetObject("btn_BAO.BackgroundImage");
            btn_BAO.BackgroundImageLayout = ImageLayout.Zoom;
            btn_BAO.FlatAppearance.BorderSize = 0;
            btn_BAO.FlatStyle = FlatStyle.Flat;
            btn_BAO.Location = new Point(378, 321);
            btn_BAO.Name = "btn_BAO";
            btn_BAO.Size = new Size(39, 23);
            btn_BAO.TabIndex = 5;
            btn_BAO.UseVisualStyleBackColor = true;
            btn_BAO.Click += btn_BAO_Click;
            // 
            // btn_Gate2
            // 
            btn_Gate2.BackgroundImage = (Image)resources.GetObject("btn_Gate2.BackgroundImage");
            btn_Gate2.BackgroundImageLayout = ImageLayout.Zoom;
            btn_Gate2.FlatAppearance.BorderSize = 0;
            btn_Gate2.FlatStyle = FlatStyle.Flat;
            btn_Gate2.Location = new Point(607, 88);
            btn_Gate2.Name = "btn_Gate2";
            btn_Gate2.Size = new Size(76, 28);
            btn_Gate2.TabIndex = 6;
            btn_Gate2.UseVisualStyleBackColor = true;
            btn_Gate2.Click += btn_Gate2_Click;
            // 
            // btn_ActivityCenter
            // 
            btn_ActivityCenter.BackgroundImage = (Image)resources.GetObject("btn_ActivityCenter.BackgroundImage");
            btn_ActivityCenter.BackgroundImageLayout = ImageLayout.Zoom;
            btn_ActivityCenter.FlatAppearance.BorderSize = 0;
            btn_ActivityCenter.FlatStyle = FlatStyle.Flat;
            btn_ActivityCenter.Location = new Point(408, 207);
            btn_ActivityCenter.Name = "btn_ActivityCenter";
            btn_ActivityCenter.Size = new Size(110, 69);
            btn_ActivityCenter.TabIndex = 7;
            btn_ActivityCenter.UseVisualStyleBackColor = true;
            btn_ActivityCenter.Click += btn_ActivityCenter_Click;
            // 
            // btn_CCS
            // 
            btn_CCS.BackgroundImage = (Image)resources.GetObject("btn_CCS.BackgroundImage");
            btn_CCS.BackgroundImageLayout = ImageLayout.Zoom;
            btn_CCS.FlatAppearance.BorderSize = 0;
            btn_CCS.FlatStyle = FlatStyle.Flat;
            btn_CCS.Location = new Point(292, 426);
            btn_CCS.Name = "btn_CCS";
            btn_CCS.Size = new Size(97, 47);
            btn_CCS.TabIndex = 8;
            btn_CCS.UseVisualStyleBackColor = true;
            btn_CCS.Click += btn_CCS_Click_1;
            // 
            // btn_CTECAS
            // 
            btn_CTECAS.BackgroundImage = (Image)resources.GetObject("btn_CTECAS.BackgroundImage");
            btn_CTECAS.BackgroundImageLayout = ImageLayout.Zoom;
            btn_CTECAS.FlatAppearance.BorderSize = 0;
            btn_CTECAS.FlatStyle = FlatStyle.Flat;
            btn_CTECAS.Location = new Point(85, 195);
            btn_CTECAS.Name = "btn_CTECAS";
            btn_CTECAS.Size = new Size(112, 38);
            btn_CTECAS.TabIndex = 9;
            btn_CTECAS.UseVisualStyleBackColor = true;
            btn_CTECAS.Click += btn_CTECAS_Click;
            // 
            // btn_CCJE
            // 
            btn_CCJE.BackgroundImage = (Image)resources.GetObject("btn_CCJE.BackgroundImage");
            btn_CCJE.BackgroundImageLayout = ImageLayout.Zoom;
            btn_CCJE.FlatAppearance.BorderSize = 0;
            btn_CCJE.FlatStyle = FlatStyle.Flat;
            btn_CCJE.Location = new Point(28, 24);
            btn_CCJE.Name = "btn_CCJE";
            btn_CCJE.Size = new Size(96, 63);
            btn_CCJE.TabIndex = 10;
            btn_CCJE.UseVisualStyleBackColor = true;
            btn_CCJE.Click += btn_CCJE_Click;
            // 
            // btn_CBAA
            // 
            btn_CBAA.BackgroundImage = (Image)resources.GetObject("btn_CBAA.BackgroundImage");
            btn_CBAA.BackgroundImageLayout = ImageLayout.Zoom;
            btn_CBAA.FlatAppearance.BorderSize = 0;
            btn_CBAA.FlatStyle = FlatStyle.Flat;
            btn_CBAA.Location = new Point(99, 150);
            btn_CBAA.Name = "btn_CBAA";
            btn_CBAA.Size = new Size(87, 39);
            btn_CBAA.TabIndex = 11;
            btn_CBAA.UseVisualStyleBackColor = true;
            btn_CBAA.Click += btn_CBAA_Click;
            // 
            // btn_CIHTM
            // 
            btn_CIHTM.BackgroundImage = (Image)resources.GetObject("btn_CIHTM.BackgroundImage");
            btn_CIHTM.BackgroundImageLayout = ImageLayout.Zoom;
            btn_CIHTM.FlatAppearance.BorderSize = 0;
            btn_CIHTM.FlatStyle = FlatStyle.Flat;
            btn_CIHTM.Location = new Point(273, 168);
            btn_CIHTM.Name = "btn_CIHTM";
            btn_CIHTM.Size = new Size(84, 33);
            btn_CIHTM.TabIndex = 13;
            btn_CIHTM.UseVisualStyleBackColor = true;
            btn_CIHTM.Click += btn_CIHTM_Click;
            // 
            // btn_CONAH
            // 
            btn_CONAH.BackgroundImage = (Image)resources.GetObject("btn_CONAH.BackgroundImage");
            btn_CONAH.BackgroundImageLayout = ImageLayout.Zoom;
            btn_CONAH.FlatAppearance.BorderSize = 0;
            btn_CONAH.FlatStyle = FlatStyle.Flat;
            btn_CONAH.Location = new Point(395, 93);
            btn_CONAH.Name = "btn_CONAH";
            btn_CONAH.Size = new Size(100, 23);
            btn_CONAH.TabIndex = 14;
            btn_CONAH.UseVisualStyleBackColor = true;
            btn_CONAH.Click += btn_CONAH_Click;
            // 
            // btn_COE
            // 
            btn_COE.BackgroundImage = (Image)resources.GetObject("btn_COE.BackgroundImage");
            btn_COE.BackgroundImageLayout = ImageLayout.Zoom;
            btn_COE.FlatAppearance.BorderSize = 0;
            btn_COE.FlatStyle = FlatStyle.Flat;
            btn_COE.Location = new Point(539, 151);
            btn_COE.Name = "btn_COE";
            btn_COE.Size = new Size(95, 38);
            btn_COE.TabIndex = 15;
            btn_COE.UseVisualStyleBackColor = true;
            btn_COE.Click += btn_COE_Click;
            // 
            // btn_Automotive
            // 
            btn_Automotive.BackgroundImage = (Image)resources.GetObject("btn_Automotive.BackgroundImage");
            btn_Automotive.BackgroundImageLayout = ImageLayout.Zoom;
            btn_Automotive.FlatAppearance.BorderSize = 0;
            btn_Automotive.FlatStyle = FlatStyle.Flat;
            btn_Automotive.Location = new Point(251, 103);
            btn_Automotive.Name = "btn_Automotive";
            btn_Automotive.Size = new Size(121, 46);
            btn_Automotive.TabIndex = 16;
            btn_Automotive.UseVisualStyleBackColor = true;
            btn_Automotive.Click += btn_Automotive_Click;
            // 
            // btn_Hotel
            // 
            btn_Hotel.BackgroundImage = (Image)resources.GetObject("btn_Hotel.BackgroundImage");
            btn_Hotel.BackgroundImageLayout = ImageLayout.Zoom;
            btn_Hotel.FlatAppearance.BorderSize = 0;
            btn_Hotel.FlatStyle = FlatStyle.Flat;
            btn_Hotel.Location = new Point(264, 214);
            btn_Hotel.Name = "btn_Hotel";
            btn_Hotel.Size = new Size(81, 32);
            btn_Hotel.TabIndex = 17;
            btn_Hotel.UseVisualStyleBackColor = true;
            btn_Hotel.Click += btn_Hotel_Click;
            // 
            // btn_Church
            // 
            btn_Church.BackgroundImage = (Image)resources.GetObject("btn_Church.BackgroundImage");
            btn_Church.BackgroundImageLayout = ImageLayout.Zoom;
            btn_Church.FlatAppearance.BorderSize = 0;
            btn_Church.FlatStyle = FlatStyle.Flat;
            btn_Church.Location = new Point(206, 321);
            btn_Church.Name = "btn_Church";
            btn_Church.Size = new Size(72, 43);
            btn_Church.TabIndex = 18;
            btn_Church.UseVisualStyleBackColor = true;
            btn_Church.Click += btn_Church_Click;
            // 
            // btn_Admin
            // 
            btn_Admin.BackgroundImage = (Image)resources.GetObject("btn_Admin.BackgroundImage");
            btn_Admin.BackgroundImageLayout = ImageLayout.Zoom;
            btn_Admin.FlatAppearance.BorderSize = 0;
            btn_Admin.FlatStyle = FlatStyle.Flat;
            btn_Admin.Location = new Point(361, 374);
            btn_Admin.Name = "btn_Admin";
            btn_Admin.Size = new Size(66, 46);
            btn_Admin.TabIndex = 19;
            btn_Admin.UseVisualStyleBackColor = true;
            btn_Admin.Click += btn_Admin_Click_1;
            // 
            // btn_Library
            // 
            btn_Library.BackgroundImage = (Image)resources.GetObject("btn_Library.BackgroundImage");
            btn_Library.BackgroundImageLayout = ImageLayout.Zoom;
            btn_Library.FlatAppearance.BorderSize = 0;
            btn_Library.FlatStyle = FlatStyle.Flat;
            btn_Library.Location = new Point(399, 485);
            btn_Library.Name = "btn_Library";
            btn_Library.Size = new Size(105, 48);
            btn_Library.TabIndex = 20;
            btn_Library.UseVisualStyleBackColor = true;
            btn_Library.Click += btn_Library_Click;
            // 
            // btn_Court
            // 
            btn_Court.BackgroundImage = (Image)resources.GetObject("btn_Court.BackgroundImage");
            btn_Court.BackgroundImageLayout = ImageLayout.Zoom;
            btn_Court.FlatAppearance.BorderSize = 0;
            btn_Court.FlatStyle = FlatStyle.Flat;
            btn_Court.Location = new Point(423, 374);
            btn_Court.Name = "btn_Court";
            btn_Court.Size = new Size(72, 41);
            btn_Court.TabIndex = 21;
            btn_Court.UseVisualStyleBackColor = true;
            btn_Court.Click += btn_Court_Click;
            // 
            // btn_TheGears
            // 
            btn_TheGears.BackgroundImage = (Image)resources.GetObject("btn_TheGears.BackgroundImage");
            btn_TheGears.BackgroundImageLayout = ImageLayout.Zoom;
            btn_TheGears.FlatAppearance.BorderSize = 0;
            btn_TheGears.FlatStyle = FlatStyle.Flat;
            btn_TheGears.Location = new Point(612, 225);
            btn_TheGears.Name = "btn_TheGears";
            btn_TheGears.Size = new Size(71, 51);
            btn_TheGears.TabIndex = 22;
            btn_TheGears.UseVisualStyleBackColor = true;
            btn_TheGears.Click += btn_TheGears_Click;
            // 
            // btn_OpenField
            // 
            btn_OpenField.BackgroundImage = (Image)resources.GetObject("btn_OpenField.BackgroundImage");
            btn_OpenField.BackgroundImageLayout = ImageLayout.Zoom;
            btn_OpenField.FlatAppearance.BorderSize = 0;
            btn_OpenField.FlatStyle = FlatStyle.Flat;
            btn_OpenField.Location = new Point(539, 334);
            btn_OpenField.Name = "btn_OpenField";
            btn_OpenField.Size = new Size(95, 72);
            btn_OpenField.TabIndex = 23;
            btn_OpenField.UseVisualStyleBackColor = true;
            btn_OpenField.Click += btn_OpenField_Click;
            // 
            // btn_GrandStand
            // 
            btn_GrandStand.BackgroundImage = (Image)resources.GetObject("btn_GrandStand.BackgroundImage");
            btn_GrandStand.BackgroundImageLayout = ImageLayout.Zoom;
            btn_GrandStand.FlatAppearance.BorderSize = 0;
            btn_GrandStand.FlatStyle = FlatStyle.Flat;
            btn_GrandStand.Location = new Point(624, 374);
            btn_GrandStand.Name = "btn_GrandStand";
            btn_GrandStand.Size = new Size(91, 57);
            btn_GrandStand.TabIndex = 24;
            btn_GrandStand.UseVisualStyleBackColor = true;
            btn_GrandStand.Click += btn_GrandStand_Click;
            // 
            // Map
            // 
            BackColor = SystemColors.GradientActiveCaption;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(784, 661);
            Controls.Add(btnAdd);
            Controls.Add(btnPanel);
            Controls.Add(panel2);
            Controls.Add(panel1);
            MaximumSize = new Size(800, 700);
            MinimumSize = new Size(800, 700);
            Name = "Map";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Campus Map";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }




        private System.Windows.Forms.Button btnPanel;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnAdd;
        private Label label1;
        private Panel panel1;

        #endregion

        private Panel panel2;
        private Button btn_gate1;
        private Button btn_Cafeteria1;
        private Button btn_CIT;
       

        private Button btn_Cafeteria2;
        private Button btn_XeroxService;
        private Button btn_PrintingService2;
        private Button btn_BAO;
        private Button btn_Gate2;
        private Button btn_ActivityCenter;
        private Button btn_CCS;
        private Button btn_CTECAS;
        private Button btn_CCJE;
        private Button btn_CBAA;
        private Button btn_CIHTM;
        private Button btn_CONAH;
        private Button btn_COE;
        private Button btn_Automotive;
        private Button btn_Hotel;
        private Button btn_Church;
        private Button btn_Admin;
        private Button btn_Library;
        private Button btn_Court;
        private Button btn_TheGears;
        private Button btn_OpenField;
        private Button btn_GrandStand;
        private Button btn_CIT2;
    }

}