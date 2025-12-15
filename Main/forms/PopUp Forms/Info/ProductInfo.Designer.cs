namespace Presyong_Ka_Piyu.Main.forms.PopUp_Forms
{
    partial class ProductInfo
    {

        private TextBox txtName;
        private ComboBox cmbCategory;
        private TextBox txtDescription;
        private PictureBox picImage;
        private Button btnBrowse;
        private NumericUpDown numRating;
        private CheckBox chkFavorite;
        private ComboBox cmbStore;
        private NumericUpDown numPrice;
        private Button btnSave;
        private Button btnCancel;

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
            txtName = new TextBox();
            cmbCategory = new ComboBox();
            txtDescription = new TextBox();
            picImage = new PictureBox();
            btnBrowse = new Button();
            numRating = new NumericUpDown();
            chkFavorite = new CheckBox();
            cmbStore = new ComboBox();
            numPrice = new NumericUpDown();
            btnSave = new Button();
            btnCancel = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)picImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numRating).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numPrice).BeginInit();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 12F);
            txtName.Location = new Point(183, 24);
            txtName.Name = "txtName";
            txtName.Size = new Size(174, 29);
            txtName.TabIndex = 0;
            txtName.TextChanged += txtName_TextChanged;
            // 
            // cmbCategory
            // 
            cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(174, 101);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(189, 23);
            cmbCategory.TabIndex = 1;
            cmbCategory.SelectedIndexChanged += cmbCategory_SelectedIndexChanged;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(20, 338);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(337, 197);
            txtDescription.TabIndex = 2;
            txtDescription.TextChanged += txtDescription_TextChanged;
            // 
            // picImage
            // 
            picImage.BorderStyle = BorderStyle.FixedSingle;
            picImage.Location = new Point(12, 74);
            picImage.Name = "picImage";
            picImage.Size = new Size(150, 150);
            picImage.SizeMode = PictureBoxSizeMode.Zoom;
            picImage.TabIndex = 3;
            picImage.TabStop = false;
            // 
            // btnBrowse
            // 
            btnBrowse.Location = new Point(12, 230);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(100, 25);
            btnBrowse.TabIndex = 4;
            btnBrowse.Text = "Change Image";
            btnBrowse.UseVisualStyleBackColor = true;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // numRating
            // 
            numRating.DecimalPlaces = 1;
            numRating.Location = new Point(174, 189);
            numRating.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            numRating.Name = "numRating";
            numRating.Size = new Size(189, 23);
            numRating.TabIndex = 5;
            // 
            // chkFavorite
            // 
            chkFavorite.AutoSize = true;
            chkFavorite.Location = new Point(175, 284);
            chkFavorite.Name = "chkFavorite";
            chkFavorite.Size = new Size(68, 19);
            chkFavorite.TabIndex = 6;
            chkFavorite.Text = "Favorite";
            chkFavorite.UseVisualStyleBackColor = true;
            // 
            // cmbStore
            // 
            cmbStore.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStore.FormattingEnabled = true;
            cmbStore.Location = new Point(174, 145);
            cmbStore.Name = "cmbStore";
            cmbStore.Size = new Size(189, 23);
            cmbStore.TabIndex = 7;
            // 
            // numPrice
            // 
            numPrice.DecimalPlaces = 2;
            numPrice.Location = new Point(175, 233);
            numPrice.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numPrice.Name = "numPrice";
            numPrice.Size = new Size(188, 23);
            numPrice.TabIndex = 8;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(272, 563);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 30);
            btnSave.TabIndex = 9;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(183, 563);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 30);
            btnCancel.TabIndex = 10;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(183, 6);
            label1.Name = "label1";
            label1.Size = new Size(87, 15);
            label1.TabIndex = 11;
            label1.Text = "Product Name:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(20, 27);
            label2.Name = "label2";
            label2.Size = new Size(157, 21);
            label2.TabIndex = 12;
            label2.Text = "Product Information: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(174, 83);
            label3.Name = "label3";
            label3.Size = new Size(103, 15);
            label3.TabIndex = 13;
            label3.Text = "Product Category:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(174, 127);
            label4.Name = "label4";
            label4.Size = new Size(37, 15);
            label4.TabIndex = 14;
            label4.Text = "Store:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(174, 171);
            label5.Name = "label5";
            label5.Size = new Size(44, 15);
            label5.TabIndex = 15;
            label5.Text = "Rating:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(175, 215);
            label6.Name = "label6";
            label6.Size = new Size(36, 15);
            label6.TabIndex = 16;
            label6.Text = "Price:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(20, 320);
            label7.Name = "label7";
            label7.Size = new Size(70, 15);
            label7.TabIndex = 17;
            label7.Text = "Description:";
            // 
            // button1
            // 
            button1.Location = new Point(20, 563);
            button1.Name = "button1";
            button1.Size = new Size(100, 30);
            button1.TabIndex = 18;
            button1.Text = "Delete Product";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ProductInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(375, 605);
            Controls.Add(button1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtName);
            Controls.Add(cmbCategory);
            Controls.Add(txtDescription);
            Controls.Add(picImage);
            Controls.Add(btnBrowse);
            Controls.Add(numRating);
            Controls.Add(chkFavorite);
            Controls.Add(cmbStore);
            Controls.Add(numPrice);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            Name = "ProductInfo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Product Details";
            ((System.ComponentModel.ISupportInitialize)picImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)numRating).EndInit();
            ((System.ComponentModel.ISupportInitialize)numPrice).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button button1;
    }
}