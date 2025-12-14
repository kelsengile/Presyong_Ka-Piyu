namespace Presyong_Ka_Piyu.Main.forms.PopUp_Forms
{
    partial class Search
    {

        private TextBox txtSearch;
        private FlowLayoutPanel flpResults;

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
            txtSearch = new TextBox();
            flpResults = new FlowLayoutPanel();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(71, 22);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(220, 23);
            txtSearch.TabIndex = 0;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // flpResults
            // 
            flpResults.AutoScroll = true;
            flpResults.FlowDirection = FlowDirection.TopDown;
            flpResults.Location = new Point(20, 60);
            flpResults.Name = "flpResults";
            flpResults.Size = new Size(271, 416);
            flpResults.TabIndex = 1;
            flpResults.WrapContents = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 25);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 2;
            label1.Text = "Search:";
            // 
            // Search
            // 
            ClientSize = new Size(308, 498);
            Controls.Add(label1);
            Controls.Add(txtSearch);
            Controls.Add(flpResults);
            MaximumSize = new Size(324, 537);
            MinimumSize = new Size(324, 537);
            Name = "Search";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Search";
            Load += Search_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
    }
}