namespace Presyong_Ka_Piyu.Main.forms.PopUp_Forms
{
    partial class Menu
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
            picProfile = new PictureBox();
            btnUserInfo = new Button();
            btnMap = new Button();
            btnAbout = new Button();
            btnSettings = new Button();
            btnFeedback = new Button();
            btnHelp = new Button();
            ((System.ComponentModel.ISupportInitialize)picProfile).BeginInit();
            SuspendLayout();
            // 
            // picProfile
            // 
            picProfile.BorderStyle = BorderStyle.FixedSingle;
            picProfile.Location = new Point(12, 25);
            picProfile.Name = "picProfile";
            picProfile.Size = new Size(100, 100);
            picProfile.SizeMode = PictureBoxSizeMode.Zoom;
            picProfile.TabIndex = 0;
            picProfile.TabStop = false;
            picProfile.Click += picProfile_Click;
            // 
            // btnUserInfo
            // 
            btnUserInfo.BackColor = SystemColors.Control;
            btnUserInfo.FlatAppearance.BorderSize = 0;
            btnUserInfo.FlatStyle = FlatStyle.Flat;
            btnUserInfo.Location = new Point(118, 25);
            btnUserInfo.Name = "btnUserInfo";
            btnUserInfo.Size = new Size(133, 100);
            btnUserInfo.TabIndex = 1;
            btnUserInfo.TextAlign = ContentAlignment.MiddleLeft;
            btnUserInfo.UseVisualStyleBackColor = false;
            btnUserInfo.Click += btnUserInfo_Click;
            // 
            // btnMap
            // 
            btnMap.BackColor = SystemColors.Control;
            btnMap.FlatAppearance.BorderSize = 0;
            btnMap.Location = new Point(12, 144);
            btnMap.Name = "btnMap";
            btnMap.Size = new Size(239, 35);
            btnMap.TabIndex = 2;
            btnMap.Text = "Map";
            btnMap.UseVisualStyleBackColor = false;
            btnMap.Click += btnMap_Click;
            // 
            // btnAbout
            // 
            btnAbout.BackColor = SystemColors.Control;
            btnAbout.FlatAppearance.BorderSize = 0;
            btnAbout.Location = new Point(12, 226);
            btnAbout.Name = "btnAbout";
            btnAbout.Size = new Size(239, 35);
            btnAbout.TabIndex = 3;
            btnAbout.Text = "About";
            btnAbout.UseVisualStyleBackColor = false;
            btnAbout.Click += btnAbout_Click;
            // 
            // btnSettings
            // 
            btnSettings.BackColor = SystemColors.Control;
            btnSettings.FlatAppearance.BorderSize = 0;
            btnSettings.Location = new Point(12, 185);
            btnSettings.Name = "btnSettings";
            btnSettings.Size = new Size(239, 35);
            btnSettings.TabIndex = 4;
            btnSettings.Text = "Settings";
            btnSettings.UseVisualStyleBackColor = false;
            btnSettings.Click += btnSettings_Click;
            // 
            // btnFeedback
            // 
            btnFeedback.BackColor = SystemColors.Control;
            btnFeedback.FlatAppearance.BorderSize = 0;
            btnFeedback.Location = new Point(12, 267);
            btnFeedback.Name = "btnFeedback";
            btnFeedback.Size = new Size(239, 35);
            btnFeedback.TabIndex = 5;
            btnFeedback.Text = "Feedback";
            btnFeedback.UseVisualStyleBackColor = false;
            btnFeedback.Click += btnFeedback_Click;
            // 
            // btnHelp
            // 
            btnHelp.BackColor = SystemColors.Control;
            btnHelp.FlatAppearance.BorderSize = 0;
            btnHelp.Location = new Point(12, 308);
            btnHelp.Name = "btnHelp";
            btnHelp.Size = new Size(239, 35);
            btnHelp.TabIndex = 6;
            btnHelp.Text = "Help";
            btnHelp.UseVisualStyleBackColor = false;
            btnHelp.Click += btnHelp_Click;
            // 
            // Menu
            // 
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(264, 371);
            Controls.Add(picProfile);
            Controls.Add(btnUserInfo);
            Controls.Add(btnMap);
            Controls.Add(btnAbout);
            Controls.Add(btnSettings);
            Controls.Add(btnFeedback);
            Controls.Add(btnHelp);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MaximumSize = new Size(280, 410);
            MinimumSize = new Size(280, 410);
            Name = "Menu";
            Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)picProfile).EndInit();
            ResumeLayout(false);
        }

        private System.Windows.Forms.PictureBox picProfile;
        private System.Windows.Forms.Button btnUserInfo;
        private System.Windows.Forms.Button btnMap;
        private System.Windows.Forms.Button btnAbout; // NEW BUTTON FIELD
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnFeedback;
        private System.Windows.Forms.Button btnHelp;
    



    }



        #endregion
    
}