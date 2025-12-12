namespace Presyong_Ka_Piyu.Main.forms.Main_Forms
{
    partial class UserInfo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private TextBox txtUsername;
        private TextBox txtFullName;
        private TextBox txtEmail;
        private TextBox txtSchoolID;
        private TextBox txtBio;
        private TextBox txtCourse;
        private TextBox txtDepartment;
        private TextBox txtContactNumber;
        private TextBox txtContactFacebook;
        private TextBox txtContactInsta;
        private DateTimePicker dtpDateOfBirth;
        private TextBox txtAddress;
        private PictureBox picProfile;
        private Button btnSave;
        private TextBox txtAccountID;
        private TextBox txtCreatedAt;
        private TextBox txtRole;

        
        
        private Button btnChangeEmail;
        private Button btnChangePhone;
        private Button btnChangePassword;



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
            txtUsername = new TextBox();
            txtFullName = new TextBox();
            txtEmail = new TextBox();
            txtSchoolID = new TextBox();
            txtBio = new TextBox();
            txtCourse = new TextBox();
            txtDepartment = new TextBox();
            txtContactNumber = new TextBox();
            txtContactFacebook = new TextBox();
            txtContactInsta = new TextBox();
            dtpDateOfBirth = new DateTimePicker();
            txtAddress = new TextBox();
            picProfile = new PictureBox();
            btnSave = new Button();
            btnPanel = new Button();
            btnSearch = new Button();
            btnAdd = new Button();
            label1 = new Label();
            panel1 = new Panel();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            txtAccountID = new TextBox();
            txtCreatedAt = new TextBox();
            txtRole = new TextBox();
            label16 = new Label();
            label17 = new Label();
            label18 = new Label();
            label19 = new Label();
            btnChangePicture = new Button();
            btnChange_Email = new Button();
            btn_ChangePassword = new Button();
            label20 = new Label();
            ((System.ComponentModel.ISupportInitialize)picProfile).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(272, 140);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(200, 23);
            txtUsername.TabIndex = 6;
            txtUsername.TextChanged += txtUsername_TextChanged;
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(272, 185);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(200, 23);
            txtFullName.TabIndex = 7;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(144, 485);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(214, 23);
            txtEmail.TabIndex = 8;
            // 
            // txtSchoolID
            // 
            txtSchoolID.Location = new Point(272, 229);
            txtSchoolID.Name = "txtSchoolID";
            txtSchoolID.Size = new Size(200, 23);
            txtSchoolID.TabIndex = 9;
            // 
            // txtBio
            // 
            txtBio.Location = new Point(497, 129);
            txtBio.Multiline = true;
            txtBio.Name = "txtBio";
            txtBio.Size = new Size(269, 132);
            txtBio.TabIndex = 10;
            // 
            // txtCourse
            // 
            txtCourse.Location = new Point(92, 361);
            txtCourse.Name = "txtCourse";
            txtCourse.Size = new Size(266, 23);
            txtCourse.TabIndex = 11;
            // 
            // txtDepartment
            // 
            txtDepartment.Location = new Point(92, 399);
            txtDepartment.Name = "txtDepartment";
            txtDepartment.Size = new Size(266, 23);
            txtDepartment.TabIndex = 12;
            // 
            // txtContactNumber
            // 
            txtContactNumber.Location = new Point(144, 524);
            txtContactNumber.Name = "txtContactNumber";
            txtContactNumber.Size = new Size(214, 23);
            txtContactNumber.TabIndex = 13;
            // 
            // txtContactFacebook
            // 
            txtContactFacebook.Location = new Point(144, 562);
            txtContactFacebook.Name = "txtContactFacebook";
            txtContactFacebook.Size = new Size(214, 23);
            txtContactFacebook.TabIndex = 14;
            // 
            // txtContactInsta
            // 
            txtContactInsta.Location = new Point(144, 602);
            txtContactInsta.Name = "txtContactInsta";
            txtContactInsta.Size = new Size(214, 23);
            txtContactInsta.TabIndex = 15;
            // 
            // dtpDateOfBirth
            // 
            dtpDateOfBirth.Location = new Point(537, 295);
            dtpDateOfBirth.Name = "dtpDateOfBirth";
            dtpDateOfBirth.Size = new Size(200, 23);
            dtpDateOfBirth.TabIndex = 16;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(537, 337);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(200, 23);
            txtAddress.TabIndex = 17;
            // 
            // picProfile
            // 
            picProfile.BorderStyle = BorderStyle.FixedSingle;
            picProfile.Location = new Point(25, 129);
            picProfile.Name = "picProfile";
            picProfile.Size = new Size(150, 150);
            picProfile.SizeMode = PictureBoxSizeMode.Zoom;
            picProfile.TabIndex = 18;
            picProfile.TabStop = false;
            picProfile.Click += picProfile_Click_1;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(591, 605);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(78, 30);
            btnSave.TabIndex = 19;
            btnSave.Text = "Save";
            btnSave.Click += btnSave_Click;
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
            btnAdd.Location = new Point(686, 605);
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
            label1.Size = new Size(342, 30);
            label1.TabIndex = 4;
            label1.Text = "User Information  |  Presyong_Ka-Piyu";
            label1.Click += label1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnPanel);
            panel1.Controls.Add(btnSearch);
            panel1.Location = new Point(-3, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(789, 85);
            panel1.TabIndex = 5;
            panel1.Paint += panel1_Paint;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(198, 148);
            label2.Name = "label2";
            label2.Size = new Size(68, 15);
            label2.TabIndex = 20;
            label2.Text = "UserName: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(198, 188);
            label3.Name = "label3";
            label3.Size = new Size(61, 15);
            label3.TabIndex = 21;
            label3.Text = "FullName:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(199, 232);
            label4.Name = "label4";
            label4.Size = new Size(60, 15);
            label4.TabIndex = 22;
            label4.Text = "School ID:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(56, 493);
            label5.Name = "label5";
            label5.Size = new Size(39, 15);
            label5.TabIndex = 23;
            label5.Text = "Email:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(66, 324);
            label6.Name = "label6";
            label6.Size = new Size(142, 15);
            label6.TabIndex = 24;
            label6.Text = "College User Information:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(25, 364);
            label7.Name = "label7";
            label7.Size = new Size(47, 15);
            label7.TabIndex = 25;
            label7.Text = "Course:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(8, 402);
            label8.Name = "label8";
            label8.Size = new Size(73, 15);
            label8.TabIndex = 26;
            label8.Text = "Department:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(66, 451);
            label9.Name = "label9";
            label9.Size = new Size(118, 15);
            label9.TabIndex = 27;
            label9.Text = "Contact Information:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(25, 532);
            label10.Name = "label10";
            label10.Size = new Size(99, 15);
            label10.TabIndex = 28;
            label10.Text = "Contact Number:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(44, 570);
            label11.Name = "label11";
            label11.Size = new Size(61, 15);
            label11.TabIndex = 29;
            label11.Text = "Facebook:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(42, 605);
            label12.Name = "label12";
            label12.Size = new Size(63, 15);
            label12.TabIndex = 30;
            label12.Text = "Instagram:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(537, 399);
            label13.Name = "label13";
            label13.Size = new Size(140, 15);
            label13.TabIndex = 31;
            label13.Text = "Unique User Information:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(469, 301);
            label14.Name = "label14";
            label14.Size = new Size(62, 15);
            label14.TabIndex = 32;
            label14.Text = "Birth Date:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(469, 340);
            label15.Name = "label15";
            label15.Size = new Size(45, 15);
            label15.TabIndex = 33;
            label15.Text = "Adress:";
            // 
            // txtAccountID
            // 
            txtAccountID.Location = new Point(537, 428);
            txtAccountID.Name = "txtAccountID";
            txtAccountID.ReadOnly = true;
            txtAccountID.Size = new Size(200, 23);
            txtAccountID.TabIndex = 0;
            // 
            // txtCreatedAt
            // 
            txtCreatedAt.Location = new Point(537, 467);
            txtCreatedAt.Name = "txtCreatedAt";
            txtCreatedAt.ReadOnly = true;
            txtCreatedAt.Size = new Size(200, 23);
            txtCreatedAt.TabIndex = 1;
            // 
            // txtRole
            // 
            txtRole.Location = new Point(537, 506);
            txtRole.Name = "txtRole";
            txtRole.ReadOnly = true;
            txtRole.Size = new Size(200, 23);
            txtRole.TabIndex = 2;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(462, 431);
            label16.Name = "label16";
            label16.Size = new Size(69, 15);
            label16.TabIndex = 34;
            label16.Text = "Account ID:";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(462, 470);
            label17.Name = "label17";
            label17.Size = new Size(66, 15);
            label17.TabIndex = 35;
            label17.Text = "Created At:";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(481, 509);
            label18.Name = "label18";
            label18.Size = new Size(33, 15);
            label18.TabIndex = 36;
            label18.Text = "Role:";
            label18.Click += label18_Click;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(25, 102);
            label19.Name = "label19";
            label19.Size = new Size(87, 15);
            label19.TabIndex = 37;
            label19.Text = "Profile Picture: ";
            // 
            // btnChangePicture
            // 
            btnChangePicture.Font = new Font("Segoe UI", 7F);
            btnChangePicture.Location = new Point(25, 285);
            btnChangePicture.Name = "btnChangePicture";
            btnChangePicture.Size = new Size(80, 21);
            btnChangePicture.TabIndex = 38;
            btnChangePicture.Text = "Change Picture";
            btnChangePicture.UseVisualStyleBackColor = true;
            btnChangePicture.Click += btnChangePicture_Click;
            // 
            // btnChange_Email
            // 
            btnChange_Email.Location = new Point(364, 485);
            btnChange_Email.Name = "btnChange_Email";
            btnChange_Email.Size = new Size(75, 23);
            btnChange_Email.TabIndex = 39;
            btnChange_Email.Text = "Change";
            btnChange_Email.UseVisualStyleBackColor = true;
            btnChange_Email.Click += btnChange_Email_Click;
            // 
            // btn_ChangePassword
            // 
            btn_ChangePassword.Location = new Point(537, 570);
            btn_ChangePassword.Name = "btn_ChangePassword";
            btn_ChangePassword.Size = new Size(200, 23);
            btn_ChangePassword.TabIndex = 40;
            btn_ChangePassword.Text = "Change Password";
            btn_ChangePassword.UseVisualStyleBackColor = true;
            btn_ChangePassword.Click += btn_ChangePassword_Click;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(537, 548);
            label20.Name = "label20";
            label20.Size = new Size(52, 15);
            label20.TabIndex = 41;
            label20.Text = "Security:";
            // 
            // UserInfo
            // 
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(784, 661);
            Controls.Add(label20);
            Controls.Add(btn_ChangePassword);
            Controls.Add(btnChange_Email);
            Controls.Add(btnChangePicture);
            Controls.Add(label19);
            Controls.Add(label18);
            Controls.Add(label17);
            Controls.Add(label16);
            Controls.Add(txtAccountID);
            Controls.Add(txtCreatedAt);
            Controls.Add(txtRole);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnAdd);
            Controls.Add(panel1);
            Controls.Add(txtUsername);
            Controls.Add(txtFullName);
            Controls.Add(txtEmail);
            Controls.Add(txtSchoolID);
            Controls.Add(txtBio);
            Controls.Add(txtCourse);
            Controls.Add(txtDepartment);
            Controls.Add(txtContactNumber);
            Controls.Add(txtContactFacebook);
            Controls.Add(txtContactInsta);
            Controls.Add(dtpDateOfBirth);
            Controls.Add(txtAddress);
            Controls.Add(picProfile);
            Controls.Add(btnSave);
            Name = "UserInfo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "User Info";
            ((System.ComponentModel.ISupportInitialize)picProfile).EndInit();
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

        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
        private Label label18;
        private Label label19;
        private Button btnChangePicture;
        private Button btnChange_Email;
        private Button btn_ChangePassword;
        private Label label20;
    }
}