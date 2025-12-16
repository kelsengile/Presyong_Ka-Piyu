using Microsoft.VisualBasic;
using System.Diagnostics;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Presyong_Ka_Piyu.Main.forms.Main_Forms
{
    partial class About
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            btnPanel = new System.Windows.Forms.Button();
            btnSearch = new System.Windows.Forms.Button();
            btnAdd = new System.Windows.Forms.Button();
            label1 = new Label();
            panel1 = new Panel();
            btn_Contact = new System.Windows.Forms.Button();
            label2 = new Label();
            label3 = new Label();
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
            label1.Location = new Point(92, 27);
            label1.Name = "label1";
            label1.Size = new Size(250, 30);
            label1.TabIndex = 4;
            label1.Text = "About  |  Presyong_Ka-Piyu";
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
            // btn_Contact
            // 
            btn_Contact.Location = new Point(12, 595);
            btn_Contact.Name = "btn_Contact";
            btn_Contact.Size = new Size(98, 42);
            btn_Contact.TabIndex = 6;
            btn_Contact.Text = "Contact Us";
            btn_Contact.UseVisualStyleBackColor = true;
            btn_Contact.Click += btn_Contact_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(87, 138);
            label2.Name = "label2";
            label2.Size = new Size(165, 56);
            label2.TabIndex = 7;
            label2.Text = "Presyong Ka-Piyu\nVersion 1.0";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(46, 228);
            label3.Name = "label3";
            label3.Size = new Size(697, 210);
            label3.TabIndex = 8;
            label3.Text = resources.GetString("label3.Text");
            label3.Click += label3_Click;
            // 
            // About
            // 
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(784, 661);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btn_Contact);
            Controls.Add(btnAdd);
            Controls.Add(btnPanel);
            Controls.Add(panel1);
            MaximumSize = new Size(800, 700);
            MinimumSize = new Size(800, 700);
            Name = "About";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "About";
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


        #endregion

        private System.Windows.Forms.Button btn_Contact;
        private Label label2;
        private Label label3;
    }
}