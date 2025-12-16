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
        private FlowLayoutPanel flpStoreProducts;


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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StoreInfo));
            txtName = new TextBox();
            flpStoreProducts = new FlowLayoutPanel();
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            btn_DeleteStore = new Button();
            ((System.ComponentModel.ISupportInitialize)picImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numRating).BeginInit();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 15F);
            txtName.Location = new Point(368, 21);
            txtName.Name = "txtName";
            txtName.Size = new Size(174, 34);
            txtName.TabIndex = 0;
            // 
            // flpStoreProducts
            // 
            flpStoreProducts.AutoScroll = true;
            flpStoreProducts.BackColor = SystemColors.Control;
            flpStoreProducts.FlowDirection = FlowDirection.TopDown;
            flpStoreProducts.Location = new Point(25, 361);
            flpStoreProducts.Name = "flpStoreProducts";
            flpStoreProducts.Padding = new Padding(10);
            flpStoreProducts.Size = new Size(716, 196);
            flpStoreProducts.TabIndex = 20;
            flpStoreProducts.WrapContents = false;
            flpStoreProducts.Paint += flpStoreProducts_Paint;
            // 
            // txtContact
            // 
            txtContact.Location = new Point(301, 193);
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(164, 23);
            txtContact.TabIndex = 2;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(472, 87);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(270, 225);
            txtDescription.TabIndex = 3;
            // 
            // cmbCategory
            // 
            cmbCategory.BackColor = SystemColors.Window;
            cmbCategory.Location = new Point(303, 149);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(162, 23);
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
            btnBrowse.Size = new Size(100, 25);
            btnBrowse.TabIndex = 6;
            btnBrowse.Text = "Change Image";
            btnBrowse.Click += btnBrowse_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(666, 570);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 9;
            btnSave.Text = "Save";
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(585, 570);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 10;
            btnCancel.Text = "Cancel";
            btnCancel.Click += btnCancel_Click;
            // 
            // numRating
            // 
            numRating.Location = new Point(304, 237);
            numRating.Name = "numRating";
            numRating.Size = new Size(161, 23);
            numRating.TabIndex = 7;
            numRating.ValueChanged += numRating_ValueChanged;
            // 
            // chkFavorite
            // 
            chkFavorite.Location = new Point(303, 289);
            chkFavorite.Name = "chkFavorite";
            chkFavorite.Size = new Size(104, 24);
            chkFavorite.TabIndex = 8;
            chkFavorite.Text = "Favorite";
            chkFavorite.CheckedChanged += chkFavorite_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(192, 21);
            label1.Name = "label1";
            label1.Size = new Size(170, 28);
            label1.TabIndex = 11;
            label1.Text = "Store Information:";
            // 
            // cmbLocation
            // 
            cmbLocation.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbLocation.Location = new Point(300, 105);
            cmbLocation.Name = "cmbLocation";
            cmbLocation.Size = new Size(165, 23);
            cmbLocation.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(301, 219);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 13;
            label2.Text = "Rating:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(368, 6);
            label3.Name = "label3";
            label3.Size = new Size(72, 15);
            label3.TabIndex = 14;
            label3.Text = "Store Name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(303, 87);
            label4.Name = "label4";
            label4.Size = new Size(56, 15);
            label4.TabIndex = 15;
            label4.Text = "Location:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(301, 131);
            label5.Name = "label5";
            label5.Size = new Size(88, 15);
            label5.TabIndex = 16;
            label5.Text = "Store Category:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(300, 175);
            label6.Name = "label6";
            label6.Size = new Size(52, 15);
            label6.TabIndex = 17;
            label6.Text = "Contact:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(472, 69);
            label7.Name = "label7";
            label7.Size = new Size(70, 15);
            label7.TabIndex = 18;
            label7.Text = "Description:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F);
            label8.Location = new Point(25, 337);
            label8.Name = "label8";
            label8.Size = new Size(74, 21);
            label8.TabIndex = 19;
            label8.Text = "Products:";
            // 
            // btn_DeleteStore
            // 
            btn_DeleteStore.Location = new Point(25, 570);
            btn_DeleteStore.Name = "btn_DeleteStore";
            btn_DeleteStore.Size = new Size(90, 30);
            btn_DeleteStore.TabIndex = 21;
            btn_DeleteStore.Text = "Delete Store";
            btn_DeleteStore.UseVisualStyleBackColor = true;
            btn_DeleteStore.Click += button1_Click;
            // 
            // StoreInfo
            // 
            ClientSize = new Size(766, 605);
            Controls.Add(btn_DeleteStore);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
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
            Controls.Add(flpStoreProducts);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(782, 644);
            MinimumSize = new Size(782, 644);
            Name = "StoreInfo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Store Details";
            ((System.ComponentModel.ISupportInitialize)picImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)numRating).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button btn_DeleteStore;
    }
}
        

        #endregion
    