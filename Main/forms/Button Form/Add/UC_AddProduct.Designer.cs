namespace Presyong_Ka_Piyu.Main.forms.Button_Form
{
    partial class UC_AddProduct
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtName = new TextBox();
            txtDescription = new TextBox();
            cmbCategory = new ComboBox();
            cmbStore = new ComboBox();
            numPrice = new NumericUpDown();
            numRating = new NumericUpDown();
            picImage = new PictureBox();
            btnBrowse = new Button();
            btnSave = new Button();
            btnCancel = new Button();
            chkFavorite = new CheckBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)numPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numRating).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picImage).BeginInit();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(201, 77);
            txtName.Name = "txtName";
            txtName.Size = new Size(238, 23);
            txtName.TabIndex = 0;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(19, 293);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(429, 156);
            txtDescription.TabIndex = 5;
            // 
            // cmbCategory
            // 
            cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategory.Location = new Point(201, 186);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(238, 23);
            cmbCategory.TabIndex = 1;
            // 
            // cmbStore
            // 
            cmbStore.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStore.Location = new Point(201, 131);
            cmbStore.Name = "cmbStore";
            cmbStore.Size = new Size(238, 23);
            cmbStore.TabIndex = 2;
            // 
            // numPrice
            // 
            numPrice.DecimalPlaces = 2;
            numPrice.Location = new Point(170, 250);
            numPrice.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numPrice.Name = "numPrice";
            numPrice.Size = new Size(120, 23);
            numPrice.TabIndex = 3;
            numPrice.ValueChanged += numPrice_ValueChanged;
            // 
            // numRating
            // 
            numRating.DecimalPlaces = 1;
            numRating.Location = new Point(319, 250);
            numRating.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            numRating.Name = "numRating";
            numRating.Size = new Size(120, 23);
            numRating.TabIndex = 4;
            // 
            // picImage
            // 
            picImage.BorderStyle = BorderStyle.FixedSingle;
            picImage.Location = new Point(19, 72);
            picImage.Name = "picImage";
            picImage.Size = new Size(150, 150);
            picImage.SizeMode = PictureBoxSizeMode.Zoom;
            picImage.TabIndex = 6;
            picImage.TabStop = false;
            // 
            // btnBrowse
            // 
            btnBrowse.BackColor = SystemColors.ControlLightLight;
            btnBrowse.Location = new Point(19, 228);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(111, 22);
            btnBrowse.TabIndex = 7;
            btnBrowse.Text = "Browse Image";
            btnBrowse.UseVisualStyleBackColor = false;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = SystemColors.Control;
            btnSave.Location = new Point(364, 462);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 30);
            btnSave.TabIndex = 8;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = SystemColors.Control;
            btnCancel.Location = new Point(283, 462);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 30);
            btnCancel.TabIndex = 9;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // chkFavorite
            // 
            chkFavorite.AutoSize = true;
            chkFavorite.Location = new Point(165, 469);
            chkFavorite.Name = "chkFavorite";
            chkFavorite.Size = new Size(112, 19);
            chkFavorite.TabIndex = 0;
            chkFavorite.Text = "Mark as Favorite";
            chkFavorite.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(170, 232);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 10;
            label1.Text = "Price:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(319, 232);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 11;
            label2.Text = "Rating:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(201, 113);
            label3.Name = "label3";
            label3.Size = new Size(37, 15);
            label3.TabIndex = 12;
            label3.Text = "Store:";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(201, 168);
            label4.Name = "label4";
            label4.Size = new Size(58, 15);
            label4.TabIndex = 13;
            label4.Text = "Category:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F);
            label5.Location = new Point(170, 19);
            label5.Name = "label5";
            label5.Size = new Size(127, 28);
            label5.TabIndex = 14;
            label5.Text = "Add Product:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(201, 59);
            label6.Name = "label6";
            label6.Size = new Size(87, 15);
            label6.TabIndex = 15;
            label6.Text = "Product Name:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(19, 275);
            label7.Name = "label7";
            label7.Size = new Size(70, 15);
            label7.TabIndex = 16;
            label7.Text = "Description:";
            // 
            // UC_AddProduct
            // 
            BackColor = SystemColors.GradientActiveCaption;
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtName);
            Controls.Add(cmbCategory);
            Controls.Add(cmbStore);
            Controls.Add(numPrice);
            Controls.Add(numRating);
            Controls.Add(txtDescription);
            Controls.Add(picImage);
            Controls.Add(btnBrowse);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            Controls.Add(chkFavorite);
            Name = "UC_AddProduct";
            Size = new Size(464, 502);
            ((System.ComponentModel.ISupportInitialize)numPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)numRating).EndInit();
            ((System.ComponentModel.ISupportInitialize)picImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.CheckBox chkFavorite;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.ComboBox cmbStore;
        private System.Windows.Forms.NumericUpDown numPrice;
        private System.Windows.Forms.NumericUpDown numRating;
        private System.Windows.Forms.PictureBox picImage;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private Label label1;
        private Label label2;
        private Label label3;
        public Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private FormStartPosition StartPosition;
    }
}
