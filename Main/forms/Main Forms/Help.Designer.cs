namespace Presyong_Ka_Piyu.Main.forms.Main_Forms
{
    partial class Help
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnPanel = new Button();
            btnSearch = new Button();
            btnAdd = new Button();
            label1 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            Question1 = new Button();
            Question2 = new Button();
            Question3 = new Button();
            Question4 = new Button();
            Question5 = new Button();
            Question6 = new Button();
            Question7 = new Button();
            Question8 = new Button();
            Question9 = new Button();
            Question10 = new Button();
            AskQuestion = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnPanel
            // 
            btnPanel.BackColor = SystemColors.Control;
            btnPanel.Location = new Point(3, 20);
            btnPanel.Name = "btnPanel";
            btnPanel.Size = new Size(86, 45);
            btnPanel.TabIndex = 1;
            btnPanel.Text = "Menu";
            btnPanel.UseVisualStyleBackColor = false;
            btnPanel.Click += btnMenu_Click;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = SystemColors.Control;
            btnSearch.Location = new Point(685, 27);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(80, 30);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = SystemColors.Control;
            btnAdd.Location = new Point(680, 607);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(80, 30);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.GradientActiveCaption;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(92, 24);
            label1.Name = "label1";
            label1.Size = new Size(226, 30);
            label1.TabIndex = 4;
            label1.Text = "Help | Presyong_Ka-Piyu";
            label1.Click += label1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnPanel);
            panel1.Controls.Add(btnSearch);
            panel1.Location = new Point(-5, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(789, 85);
            panel1.TabIndex = 5;
            // 
            // panel2
            // 
            panel2.AutoScroll = true;
            panel2.Controls.Add(flowLayoutPanel1);
            panel2.Location = new Point(12, 103);
            panel2.Name = "panel2";
            panel2.Size = new Size(760, 498);
            panel2.TabIndex = 6;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.Controls.Add(Question1);
            flowLayoutPanel1.Controls.Add(Question2);
            flowLayoutPanel1.Controls.Add(Question3);
            flowLayoutPanel1.Controls.Add(Question4);
            flowLayoutPanel1.Controls.Add(Question5);
            flowLayoutPanel1.Controls.Add(Question6);
            flowLayoutPanel1.Controls.Add(Question7);
            flowLayoutPanel1.Controls.Add(Question8);
            flowLayoutPanel1.Controls.Add(Question9);
            flowLayoutPanel1.Controls.Add(Question10);
            flowLayoutPanel1.Controls.Add(AskQuestion);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Font = new Font("Segoe UI", 15F, FontStyle.Italic | FontStyle.Underline);
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(760, 498);
            flowLayoutPanel1.TabIndex = 0;
            flowLayoutPanel1.WrapContents = false;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint;
            // 
            // Question1
            // 
            Question1.FlatAppearance.BorderSize = 0;
            Question1.FlatStyle = FlatStyle.Flat;
            Question1.Font = new Font("Segoe UI", 15F, FontStyle.Italic | FontStyle.Underline);
            Question1.Location = new Point(3, 3);
            Question1.Name = "Question1";
            Question1.Size = new Size(727, 45);
            Question1.TabIndex = 0;
            Question1.Text = "Bakit ang sakit ng puwet ko?";
            Question1.UseVisualStyleBackColor = true;
            Question1.Click += Question1_Button;
            // 
            // Question2
            // 
            Question2.FlatAppearance.BorderSize = 0;
            Question2.FlatStyle = FlatStyle.Flat;
            Question2.Font = new Font("Segoe UI", 15F, FontStyle.Italic | FontStyle.Underline);
            Question2.Location = new Point(3, 54);
            Question2.Name = "Question2";
            Question2.Size = new Size(727, 45);
            Question2.TabIndex = 1;
            Question2.Text = "Bakit?";
            Question2.UseVisualStyleBackColor = true;
            Question2.Click += Question2_Button;
            // 
            // Question3
            // 
            Question3.FlatAppearance.BorderSize = 0;
            Question3.FlatStyle = FlatStyle.Flat;
            Question3.Font = new Font("Segoe UI", 15F, FontStyle.Italic | FontStyle.Underline);
            Question3.Location = new Point(3, 105);
            Question3.Name = "Question3";
            Question3.Size = new Size(727, 45);
            Question3.TabIndex = 2;
            Question3.Text = "Ano?";
            Question3.UseVisualStyleBackColor = true;
            Question3.Click += Question3_Button;
            // 
            // Question4
            // 
            Question4.FlatAppearance.BorderSize = 0;
            Question4.FlatStyle = FlatStyle.Flat;
            Question4.Font = new Font("Segoe UI", 15F, FontStyle.Italic | FontStyle.Underline);
            Question4.Location = new Point(3, 156);
            Question4.Name = "Question4";
            Question4.Size = new Size(727, 45);
            Question4.TabIndex = 3;
            Question4.Text = "Saan?";
            Question4.UseVisualStyleBackColor = true;
            Question4.Click += Question4_Button;
            // 
            // Question5
            // 
            Question5.FlatAppearance.BorderSize = 0;
            Question5.FlatStyle = FlatStyle.Flat;
            Question5.Font = new Font("Segoe UI", 15F, FontStyle.Italic | FontStyle.Underline);
            Question5.Location = new Point(3, 207);
            Question5.Name = "Question5";
            Question5.Size = new Size(727, 45);
            Question5.TabIndex = 4;
            Question5.Text = "Kailan?";
            Question5.UseVisualStyleBackColor = true;
            Question5.Click += Question5_Button;
            // 
            // Question6
            // 
            Question6.FlatAppearance.BorderSize = 0;
            Question6.FlatStyle = FlatStyle.Flat;
            Question6.Font = new Font("Segoe UI", 15F, FontStyle.Italic | FontStyle.Underline);
            Question6.Location = new Point(3, 258);
            Question6.Name = "Question6";
            Question6.Size = new Size(727, 45);
            Question6.TabIndex = 5;
            Question6.Text = "Paano?";
            Question6.UseVisualStyleBackColor = true;
            Question6.Click += Question6_Button;
            // 
            // Question7
            // 
            Question7.FlatAppearance.BorderSize = 0;
            Question7.FlatStyle = FlatStyle.Flat;
            Question7.Font = new Font("Segoe UI", 15F, FontStyle.Italic | FontStyle.Underline);
            Question7.Location = new Point(3, 309);
            Question7.Name = "Question7";
            Question7.Size = new Size(727, 45);
            Question7.TabIndex = 6;
            Question7.Text = "Sino?";
            Question7.UseVisualStyleBackColor = true;
            Question7.Click += Question7_Button;
            // 
            // Question8
            // 
            Question8.FlatAppearance.BorderSize = 0;
            Question8.FlatStyle = FlatStyle.Flat;
            Question8.Font = new Font("Segoe UI", 15F, FontStyle.Italic | FontStyle.Underline);
            Question8.Location = new Point(3, 360);
            Question8.Name = "Question8";
            Question8.Size = new Size(727, 45);
            Question8.TabIndex = 7;
            Question8.Text = "Hala?";
            Question8.UseVisualStyleBackColor = true;
            Question8.Click += Question8_Button;
            // 
            // Question9
            // 
            Question9.FlatAppearance.BorderSize = 0;
            Question9.FlatStyle = FlatStyle.Flat;
            Question9.Font = new Font("Segoe UI", 15F, FontStyle.Italic | FontStyle.Underline);
            Question9.Location = new Point(3, 411);
            Question9.Name = "Question9";
            Question9.Size = new Size(727, 45);
            Question9.TabIndex = 8;
            Question9.Text = "Luh?";
            Question9.UseVisualStyleBackColor = true;
            Question9.Click += Question9_Button;
            // 
            // Question10
            // 
            Question10.FlatAppearance.BorderSize = 0;
            Question10.FlatStyle = FlatStyle.Flat;
            Question10.Font = new Font("Segoe UI", 15F, FontStyle.Italic | FontStyle.Underline);
            Question10.Location = new Point(3, 462);
            Question10.Name = "Question10";
            Question10.Size = new Size(727, 45);
            Question10.TabIndex = 9;
            Question10.Text = "Ginawa ko?";
            Question10.UseVisualStyleBackColor = true;
            Question10.Click += Question10_Button;
            // 
            // button1
            // 
            AskQuestion.FlatAppearance.BorderSize = 0;
            AskQuestion.FlatStyle = FlatStyle.Flat;
            AskQuestion.Font = new Font("Segoe UI", 15F, FontStyle.Italic | FontStyle.Underline);
            AskQuestion.Location = new Point(3, 513);
            AskQuestion.Name = "button1";
            AskQuestion.Size = new Size(727, 45);
            AskQuestion.TabIndex = 10;
            AskQuestion.Text = "Ask Specific Questions.";
            AskQuestion.UseVisualStyleBackColor = true;
            AskQuestion.Click += AskSpecificQuestions_Button;
            // 
            // Help
            // 
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(784, 661);
            Controls.Add(panel2);
            Controls.Add(btnAdd);
            Controls.Add(panel1);
            MaximumSize = new Size(800, 700);
            MinimumSize = new Size(800, 700);
            Name = "Help";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Help";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnPanel;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnAdd;
        private Label label1;
        private Panel panel1;
        private Panel panel2;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button Question1;
        private Button Question2;
        private Button Question3;
        private Button Question4;
        private Button Question5;
        private Button Question6;
        private Button Question7;
        private Button Question8;
        private Button Question9;
        private Button Question10;
        private Button AskQuestion;
    }

        #endregion
}
