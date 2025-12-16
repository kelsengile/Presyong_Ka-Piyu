namespace Presyong_Ka_Piyu.Main.forms.PopUp_Forms
{
    partial class ConfirmDelete
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblMsg;
        private Button btnConfirm;
        private Button btnCancel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfirmDelete));
            lblMsg = new Label();
            btnConfirm = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lblMsg
            // 
            lblMsg.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblMsg.Location = new Point(20, 20);
            lblMsg.Name = "lblMsg";
            lblMsg.Size = new Size(360, 60);
            lblMsg.TabIndex = 0;
            lblMsg.Text = "Are you sure you want to delete ALL DATA?\n\n          This action cannot be undone.";
            // 
            // btnConfirm
            // 
            btnConfirm.BackColor = Color.IndianRed;
            btnConfirm.Location = new Point(25, 100);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(160, 35);
            btnConfirm.TabIndex = 1;
            btnConfirm.Text = "Yes, Delete Everything";
            btnConfirm.UseVisualStyleBackColor = false;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = SystemColors.Control;
            btnCancel.Location = new Point(200, 100);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(120, 35);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // ConfirmDelete
            // 
            BackColor = Color.Salmon;
            ClientSize = new Size(360, 160);
            Controls.Add(lblMsg);
            Controls.Add(btnConfirm);
            Controls.Add(btnCancel);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "ConfirmDelete";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Confirm Deletion";
            ResumeLayout(false);
        }
    }
}