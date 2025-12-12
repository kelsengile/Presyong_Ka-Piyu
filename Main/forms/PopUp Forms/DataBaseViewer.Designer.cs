namespace Presyong_Ka_Piyu.Main.forms.PopUp_Forms
{
    partial class DataBaseViewer
    {
        private System.ComponentModel.IContainer components = null;
        private ComboBox comboTables;
        private Button btnLoadTable;
        private DataGridView gridView;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            comboTables = new ComboBox();
            btnLoadTable = new Button();
            gridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)gridView).BeginInit();
            SuspendLayout();
            // 
            // comboTables
            // 
            comboTables.DropDownStyle = ComboBoxStyle.DropDownList;
            comboTables.Location = new Point(20, 20);
            comboTables.Name = "comboTables";
            comboTables.Size = new Size(200, 23);
            comboTables.TabIndex = 0;
            // 
            // btnLoadTable
            // 
            btnLoadTable.BackColor = SystemColors.Control;
            btnLoadTable.Location = new Point(230, 20);
            btnLoadTable.Name = "btnLoadTable";
            btnLoadTable.Size = new Size(120, 25);
            btnLoadTable.TabIndex = 1;
            btnLoadTable.Text = "Load Table";
            btnLoadTable.UseVisualStyleBackColor = false;
            btnLoadTable.Click += btnLoadTable_Click;
            // 
            // gridView
            // 
            gridView.AllowUserToAddRows = false;
            gridView.AllowUserToDeleteRows = false;
            gridView.Location = new Point(20, 60);
            gridView.Name = "gridView";
            gridView.ReadOnly = true;
            gridView.Size = new Size(740, 550);
            gridView.TabIndex = 2;
            // 
            // DataBaseViewer
            // 
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(784, 661);
            Controls.Add(comboTables);
            Controls.Add(btnLoadTable);
            Controls.Add(gridView);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "DataBaseViewer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Database Viewer";
            ((System.ComponentModel.ISupportInitialize)gridView).EndInit();
            ResumeLayout(false);
        }
    }
}