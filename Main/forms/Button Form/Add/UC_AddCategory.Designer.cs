namespace Presyong_Ka_Piyu.Main.forms.Button_Form
{
    partial class UC_AddCategory
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
            txtCategoryName = new TextBox();
            cmbCategoryType = new ComboBox();
            txtDescription = new TextBox();
            btnSave = new Button();
            btnCancel = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // txtCategoryName
            // 
            txtCategoryName.Location = new Point(80, 98);
            txtCategoryName.Name = "txtCategoryName";
            txtCategoryName.Size = new Size(300, 23);
            txtCategoryName.TabIndex = 0;
            // 
            // cmbCategoryType
            // 
            cmbCategoryType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategoryType.Location = new Point(80, 149);
            cmbCategoryType.Name = "cmbCategoryType";
            cmbCategoryType.Size = new Size(300, 23);
            cmbCategoryType.TabIndex = 1;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(20, 218);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(417, 221);
            txtDescription.TabIndex = 2;
            // 
            // btnSave
            // 
            btnSave.BackColor = SystemColors.Control;
            btnSave.Location = new Point(362, 454);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 30);
            btnSave.TabIndex = 3;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = SystemColors.Control;
            btnCancel.Location = new Point(272, 454);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 30);
            btnCancel.TabIndex = 4;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(160, 25);
            label1.Name = "label1";
            label1.Size = new Size(134, 28);
            label1.TabIndex = 5;
            label1.Text = "Add Category";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(80, 80);
            label2.Name = "label2";
            label2.Size = new Size(93, 15);
            label2.TabIndex = 6;
            label2.Text = "Category Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(80, 133);
            label3.Name = "label3";
            label3.Size = new Size(86, 15);
            label3.TabIndex = 7;
            label3.Text = "Category Type:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 200);
            label4.Name = "label4";
            label4.Size = new Size(70, 15);
            label4.TabIndex = 8;
            label4.Text = "Description:";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Control;
            button1.Location = new Point(20, 454);
            button1.Name = "button1";
            button1.Size = new Size(107, 30);
            button1.TabIndex = 9;
            button1.Text = "View Categories";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // UC_AddCategory
            // 
            BackColor = SystemColors.GradientActiveCaption;
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtCategoryName);
            Controls.Add(cmbCategoryType);
            Controls.Add(txtDescription);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            Name = "UC_AddCategory";
            Size = new Size(464, 502);
            Load += UC_AddCategory_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtCategoryName;
        private System.Windows.Forms.ComboBox cmbCategoryType;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private FormStartPosition StartPosition;
        private Button button1;
    }
}
