namespace Presyong_Ka_Piyu.Main.forms.PopUp_Forms
{
    partial class StoreInfo
    {
        private TextBox txtName, txtContact, txtDescription;
        private ComboBox cmbCategory;
        private PictureBox picImage;
        private Button btnBrowse, btnSave, btnCancel;
        private NumericUpDown numRating;
        private ComboBox cmbLocation;
        private CheckBox chkFavorite;


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
            txtContact = new TextBox();
            txtDescription = new TextBox();
            cmbCategory = new ComboBox();
            picImage = new PictureBox();
            btnBrowse = new Button();
            btnSave = new Button();
            btnCancel = new Button();
            numRating = new NumericUpDown();
            chkFavorite = new CheckBox();
            label1 = new Label();
            cmbLocation = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)picImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numRating).BeginInit();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(311, 72);
            txtName.Name = "txtName";
            txtName.Size = new Size(155, 23);
            txtName.TabIndex = 0;
            // 
            // txtContact
            // 
            txtContact.Location = new Point(311, 130);
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(155, 23);
            txtContact.TabIndex = 2;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(472, 72);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(269, 210);
            txtDescription.TabIndex = 3;
            // 
            // cmbCategory
            // 
            cmbCategory.Location = new Point(311, 159);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(155, 23);
            cmbCategory.TabIndex = 4;
            // 
            // picImage
            // 
            picImage.BorderStyle = BorderStyle.FixedSingle;
            picImage.Location = new Point(25, 72);
            picImage.Name = "picImage";
            picImage.Size = new Size(270, 210);
            picImage.TabIndex = 5;
            picImage.TabStop = false;
            picImage.Click += picImage_Click;
            // 
            // btnBrowse
            // 
            btnBrowse.Location = new Point(25, 288);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(75, 23);
            btnBrowse.TabIndex = 6;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(637, 563);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 9;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(537, 563);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 10;
            btnCancel.Click += btnCancel_Click;
            // 
            // numRating
            // 
            numRating.Location = new Point(311, 188);
            numRating.Name = "numRating";
            numRating.Size = new Size(145, 23);
            numRating.TabIndex = 7;
            // 
            // chkFavorite
            // 
            chkFavorite.Location = new Point(336, 258);
            chkFavorite.Name = "chkFavorite";
            chkFavorite.Size = new Size(104, 24);
            chkFavorite.TabIndex = 8;
            chkFavorite.CheckedChanged += chkFavorite_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(285, 29);
            label1.Name = "label1";
            label1.Size = new Size(170, 28);
            label1.TabIndex = 11;
            label1.Text = "Store Information:";
            // 
            // cmbLocation
            // 
            cmbLocation.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbLocation.Location = new Point(311, 101);
            cmbLocation.Name = "cmbLocation";
            cmbLocation.Size = new Size(155, 23);
            cmbLocation.TabIndex = 12;
            // 
            // StoreInfo
            // 
            ClientSize = new Size(753, 615);
            Controls.Add(label1);
            Controls.Add(txtName);
            Controls.Add(cmbLocation);
            Controls.Add(txtContact);
            Controls.Add(txtDescription);
            Controls.Add(cmbCategory);
            Controls.Add(picImage);
            Controls.Add(btnBrowse);
            Controls.Add(numRating);
            Controls.Add(chkFavorite);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            Name = "StoreInfo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Store Details";
            ((System.ComponentModel.ISupportInitialize)picImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)numRating).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label label1;
    }
}
        

        #endregion
    