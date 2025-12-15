namespace Presyong_Ka_Piyu.Main.forms
{
    partial class Add
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private Panel panelMenu;
        private Panel panelContent;
        private Button btnAddProduct;
        private Button btnAddShop;
        private Button btnAddCategory;

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
            panelMenu = new Panel();
            btnAddShop = new Button();
            button2 = new Button();
            Addlabel = new Label();
            btnAddCategory = new Button();
            btnAddProduct = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panelContent = new Panel();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            panelMenu.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.Controls.Add(btnAddShop);
            panelMenu.Controls.Add(button2);
            panelMenu.Controls.Add(Addlabel);
            panelMenu.Controls.Add(btnAddCategory);
            panelMenu.Controls.Add(btnAddProduct);
            panelMenu.Controls.Add(flowLayoutPanel1);
            panelMenu.Dock = DockStyle.Top;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(464, 121);
            panelMenu.TabIndex = 1;
            // 
            // btnAddShop
            // 
            btnAddShop.BackColor = SystemColors.Control;
            btnAddShop.Location = new Point(169, 42);
            btnAddShop.Name = "btnAddShop";
            btnAddShop.Size = new Size(130, 50);
            btnAddShop.TabIndex = 1;
            btnAddShop.Text = "Shop";
            btnAddShop.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.Location = new Point(0, 98);
            button2.Name = "button2";
            button2.Size = new Size(458, 12);
            button2.TabIndex = 0;
            button2.UseVisualStyleBackColor = true;
            // 
            // Addlabel
            // 
            Addlabel.AutoSize = true;
            Addlabel.BorderStyle = BorderStyle.Fixed3D;
            Addlabel.Font = new Font("Segoe UI", 15F);
            Addlabel.Location = new Point(206, 9);
            Addlabel.Name = "Addlabel";
            Addlabel.Size = new Size(51, 30);
            Addlabel.TabIndex = 3;
            Addlabel.Text = "Add";
            // 
            // btnAddCategory
            // 
            btnAddCategory.BackColor = SystemColors.Control;
            btnAddCategory.Location = new Point(305, 42);
            btnAddCategory.Name = "btnAddCategory";
            btnAddCategory.Size = new Size(130, 50);
            btnAddCategory.TabIndex = 0;
            btnAddCategory.Text = "Category";
            btnAddCategory.UseVisualStyleBackColor = false;
            // 
            // btnAddProduct
            // 
            btnAddProduct.BackColor = SystemColors.Control;
            btnAddProduct.Location = new Point(33, 42);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new Size(130, 50);
            btnAddProduct.TabIndex = 2;
            btnAddProduct.Text = "Product";
            btnAddProduct.UseVisualStyleBackColor = false;
            btnAddProduct.Click += btnAddProduct_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = SystemColors.ActiveCaption;
            flowLayoutPanel1.Location = new Point(0, 1);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(464, 256);
            flowLayoutPanel1.TabIndex = 4;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint;
            // 
            // panelContent
            // 
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(0, 121);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(464, 502);
            panelContent.TabIndex = 0;
            panelContent.Paint += panelContent_Paint;
            // 
            // Add
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(464, 623);
            Controls.Add(panelContent);
            Controls.Add(panelMenu);
            MaximumSize = new Size(480, 662);
            MinimumSize = new Size(480, 662);
            Name = "Add";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add";
            panelMenu.ResumeLayout(false);
            panelMenu.PerformLayout();
            ResumeLayout(false);
        }

        #endregion



        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label Addlabel;
        private FlowLayoutPanel flowLayoutPanel1;
       
        private Button button2;
    }
}