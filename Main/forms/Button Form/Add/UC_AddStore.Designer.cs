namespace Presyong_Ka_Piyu.Main.forms.Button_Form
{
    partial class UC_AddStore
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
            cmbLocation = new ComboBox();
            txtContact = new TextBox();
            cmbCategory = new ComboBox();
            numRating = new NumericUpDown();
            txtDescription = new TextBox();
            picImage = new PictureBox();
            btnBrowse = new Button();
            chkFavorite = new CheckBox();
            btnSave = new Button();
            btnCancel = new Button();
            label_addshop = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)numRating).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picImage).BeginInit();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(197, 87);
            txtName.Name = "txtName";
            txtName.Size = new Size(253, 23);
            txtName.TabIndex = 0;
            // 
            // cmbLocation
            // 
            cmbLocation.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbLocation.Location = new Point(197, 183);
            cmbLocation.Name = "cmbLocation";
            cmbLocation.Size = new Size(253, 23);
            cmbLocation.TabIndex = 1;
            // 
            // txtContact
            // 
            txtContact.Location = new Point(197, 230);
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(253, 23);
            txtContact.TabIndex = 2;
            // 
            // cmbCategory
            // 
            cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategory.Location = new Point(197, 137);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(253, 23);
            cmbCategory.TabIndex = 3;
            cmbCategory.SelectedIndexChanged += cmbCategory_SelectedIndexChanged;
            // 
            // numRating
            // 
            numRating.DecimalPlaces = 1;
            numRating.Location = new Point(315, 277);
            numRating.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            numRating.Name = "numRating";
            numRating.Size = new Size(120, 23);
            numRating.TabIndex = 4;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(24, 319);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(426, 134);
            txtDescription.TabIndex = 6;
            // 
            // picImage
            // 
            picImage.BorderStyle = BorderStyle.FixedSingle;
            picImage.Location = new Point(24, 75);
            picImage.Name = "picImage";
            picImage.Size = new Size(150, 150);
            picImage.SizeMode = PictureBoxSizeMode.Zoom;
            picImage.TabIndex = 7;
            picImage.TabStop = false;
            // 
            // btnBrowse
            // 
            btnBrowse.BackColor = SystemColors.Control;
            btnBrowse.Font = new Font("Segoe UI", 7F);
            btnBrowse.Location = new Point(24, 231);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(111, 22);
            btnBrowse.TabIndex = 8;
            btnBrowse.Text = "Browse Image";
            btnBrowse.UseVisualStyleBackColor = false;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // chkFavorite
            // 
            chkFavorite.AutoSize = true;
            chkFavorite.Location = new Point(176, 459);
            chkFavorite.Name = "chkFavorite";
            chkFavorite.Size = new Size(112, 19);
            chkFavorite.TabIndex = 5;
            chkFavorite.Text = "Mark as Favorite";
            // 
            // btnSave
            // 
            btnSave.BackColor = SystemColors.Control;
            btnSave.Location = new Point(375, 459);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 30);
            btnSave.TabIndex = 9;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = SystemColors.Control;
            btnCancel.Location = new Point(294, 459);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 30);
            btnCancel.TabIndex = 10;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // label_addshop
            // 
            label_addshop.AutoSize = true;
            label_addshop.Font = new Font("Segoe UI", 15F);
            label_addshop.Location = new Point(176, 21);
            label_addshop.Name = "label_addshop";
            label_addshop.Size = new Size(100, 28);
            label_addshop.TabIndex = 11;
            label_addshop.Text = "Add Shop";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(197, 69);
            label1.Name = "label1";
            label1.Size = new Size(72, 15);
            label1.TabIndex = 12;
            label1.Text = "Store Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(197, 119);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 13;
            label2.Text = "Category:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(197, 165);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 14;
            label3.Text = "Location:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(197, 212);
            label4.Name = "label4";
            label4.Size = new Size(52, 15);
            label4.TabIndex = 15;
            label4.Text = "Contact:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(265, 279);
            label5.Name = "label5";
            label5.Size = new Size(44, 15);
            label5.TabIndex = 16;
            label5.Text = "Rating:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(24, 301);
            label6.Name = "label6";
            label6.Size = new Size(70, 15);
            label6.TabIndex = 17;
            label6.Text = "Description:";
            // 
            // UC_AddStore
            // 
            BackColor = SystemColors.GradientActiveCaption;
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label_addshop);
            Controls.Add(txtName);
            Controls.Add(cmbLocation);
            Controls.Add(txtContact);
            Controls.Add(cmbCategory);
            Controls.Add(numRating);
            Controls.Add(chkFavorite);
            Controls.Add(txtDescription);
            Controls.Add(picImage);
            Controls.Add(btnBrowse);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            Name = "UC_AddStore";
            Size = new Size(464, 502);
            ((System.ComponentModel.ISupportInitialize)numRating).EndInit();
            ((System.ComponentModel.ISupportInitialize)picImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ComboBox cmbLocation;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.NumericUpDown numRating;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.PictureBox picImage;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.CheckBox chkFavorite;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private Label label_addshop;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private FormStartPosition StartPosition;
    }
}
