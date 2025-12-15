namespace Presyong_Ka_Piyu.Main.forms.PopUp_Forms.Info
{
    partial class CategoryInfo
    {

        private System.ComponentModel.IContainer components = null;
        private FlowLayoutPanel flpStoreCategories;
        private FlowLayoutPanel flpProductCategories;
        private Button btnDeleteSelected;
        private Label lblStores;
        private Label lblProducts;


        /// <summary>
        /// Required designer variable.
        /// </summary>
       

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
            flpStoreCategories = new FlowLayoutPanel();
            flpProductCategories = new FlowLayoutPanel();
            btnDeleteSelected = new Button();
            lblStores = new Label();
            lblProducts = new Label();
            label1 = new Label();
            panel1 = new Panel();
            SuspendLayout();
            // 
            // flpStoreCategories
            // 
            flpStoreCategories.AutoScroll = true;
            flpStoreCategories.BorderStyle = BorderStyle.FixedSingle;
            flpStoreCategories.Location = new Point(20, 113);
            flpStoreCategories.Name = "flpStoreCategories";
            flpStoreCategories.Size = new Size(432, 200);
            flpStoreCategories.TabIndex = 1;
            // 
            // flpProductCategories
            // 
            flpProductCategories.AutoScroll = true;
            flpProductCategories.BorderStyle = BorderStyle.FixedSingle;
            flpProductCategories.Location = new Point(20, 375);
            flpProductCategories.Name = "flpProductCategories";
            flpProductCategories.Size = new Size(432, 200);
            flpProductCategories.TabIndex = 3;
            // 
            // btnDeleteSelected
            // 
            btnDeleteSelected.BackColor = SystemColors.Control;
            btnDeleteSelected.Location = new Point(302, 581);
            btnDeleteSelected.Name = "btnDeleteSelected";
            btnDeleteSelected.Size = new Size(150, 30);
            btnDeleteSelected.TabIndex = 4;
            btnDeleteSelected.Text = "Delete Selected";
            btnDeleteSelected.UseVisualStyleBackColor = false;
            btnDeleteSelected.Click += BtnDeleteSelected_Click;
            // 
            // lblStores
            // 
            lblStores.AutoSize = true;
            lblStores.Font = new Font("Segoe UI", 12F);
            lblStores.Location = new Point(20, 89);
            lblStores.Name = "lblStores";
            lblStores.Size = new Size(127, 21);
            lblStores.TabIndex = 0;
            lblStores.Text = "Store Categories:";
            lblStores.Click += lblStores_Click;
            // 
            // lblProducts
            // 
            lblProducts.AutoSize = true;
            lblProducts.Font = new Font("Segoe UI", 12F);
            lblProducts.Location = new Point(20, 351);
            lblProducts.Name = "lblProducts";
            lblProducts.Size = new Size(145, 21);
            lblProducts.TabIndex = 2;
            lblProducts.Text = "Product Categories:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(178, 22);
            label1.Name = "label1";
            label1.Size = new Size(111, 30);
            label1.TabIndex = 5;
            label1.Text = "Categories:";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Location = new Point(-4, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(472, 78);
            panel1.TabIndex = 6;
            // 
            // CategoryInfo
            // 
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(464, 623);
            Controls.Add(label1);
            Controls.Add(lblStores);
            Controls.Add(flpStoreCategories);
            Controls.Add(lblProducts);
            Controls.Add(flpProductCategories);
            Controls.Add(btnDeleteSelected);
            Controls.Add(panel1);
            MaximumSize = new Size(480, 662);
            MinimumSize = new Size(480, 662);
            Name = "CategoryInfo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Categories Management";
            ResumeLayout(false);
            PerformLayout();
        }

        private Label label1;
        private Panel panel1;
    }

    #endregion
}
