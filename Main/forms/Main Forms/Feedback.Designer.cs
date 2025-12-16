namespace Presyong_Ka_Piyu.Main.forms.Main_Forms
{
    partial class Feedback
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
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnPanel
            // 
            btnPanel.BackColor = SystemColors.Control;
            btnPanel.Location = new Point(-5, 20);
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
            label1.Size = new Size(278, 30);
            label1.TabIndex = 4;
            label1.Text = "Feedback  |  Presyong_Ka-Piyu";
            label1.Click += label1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnSearch);
            panel1.Location = new Point(-5, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(789, 85);
            panel1.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F);
            label2.Location = new Point(167, 205);
            label2.Name = "label2";
            label2.Size = new Size(428, 37);
            label2.TabIndex = 6;
            label2.Text = "What do you think about our App?";
            // 
            // button1
            // 
            button1.Location = new Point(98, 331);
            button1.Name = "button1";
            button1.Size = new Size(84, 50);
            button1.TabIndex = 7;
            button1.Text = "Facebook";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(342, 331);
            button2.Name = "button2";
            button2.Size = new Size(84, 50);
            button2.TabIndex = 8;
            button2.Text = "Instagram";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(587, 331);
            button3.Name = "button3";
            button3.Size = new Size(84, 50);
            button3.TabIndex = 9;
            button3.Text = "Email";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Feedback
            // 
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(784, 661);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(btnAdd);
            Controls.Add(btnPanel);
            Controls.Add(panel1);
            MaximumSize = new Size(800, 700);
            MinimumSize = new Size(800, 700);
            Name = "Feedback";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Feedback";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();


        }



        private System.Windows.Forms.Button btnPanel;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnAdd;
        private Label label1;
        private Panel panel1;
        private Label label2;
        private Button button1;
        private Button button2;
        private Button button3;
    }

        #endregion
   }
