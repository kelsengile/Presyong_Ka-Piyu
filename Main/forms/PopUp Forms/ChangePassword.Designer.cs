namespace Presyong_Ka_Piyu.Main.forms.PopUp_Forms
{
    partial class ChangePassword
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
            label1 = new Label();
            txt_CurrentPassword = new TextBox();
            txt_NewPassword = new TextBox();
            txt_ConfirmPassword = new TextBox();
            btn_ChangePasswordButton = new Button();
            btn_ForgotPassword = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(94, 65);
            label1.Name = "label1";
            label1.Size = new Size(164, 28);
            label1.TabIndex = 0;
            label1.Text = "Change Password";
            // 
            // txt_CurrentPassword
            // 
            txt_CurrentPassword.Location = new Point(52, 124);
            txt_CurrentPassword.Name = "txt_CurrentPassword";
            txt_CurrentPassword.Size = new Size(242, 23);
            txt_CurrentPassword.TabIndex = 1;
            // 
            // txt_NewPassword
            // 
            txt_NewPassword.Location = new Point(52, 171);
            txt_NewPassword.Name = "txt_NewPassword";
            txt_NewPassword.Size = new Size(242, 23);
            txt_NewPassword.TabIndex = 2;
            // 
            // txt_ConfirmPassword
            // 
            txt_ConfirmPassword.Location = new Point(52, 225);
            txt_ConfirmPassword.Name = "txt_ConfirmPassword";
            txt_ConfirmPassword.Size = new Size(242, 23);
            txt_ConfirmPassword.TabIndex = 3;
            // 
            // btn_ChangePasswordButton
            // 
            btn_ChangePasswordButton.Location = new Point(125, 305);
            btn_ChangePasswordButton.Name = "btn_ChangePasswordButton";
            btn_ChangePasswordButton.Size = new Size(88, 23);
            btn_ChangePasswordButton.TabIndex = 4;
            btn_ChangePasswordButton.Text = "Change";
            btn_ChangePasswordButton.UseVisualStyleBackColor = true;
            btn_ChangePasswordButton.Click += btn_ChangePasswordButton_Click;
            // 
            // btn_ForgotPassword
            // 
            btn_ForgotPassword.Font = new Font("Segoe UI", 7F);
            btn_ForgotPassword.Location = new Point(125, 254);
            btn_ForgotPassword.Name = "btn_ForgotPassword";
            btn_ForgotPassword.Size = new Size(88, 23);
            btn_ForgotPassword.TabIndex = 5;
            btn_ForgotPassword.Text = "Forgot Password";
            btn_ForgotPassword.UseVisualStyleBackColor = true;
            btn_ForgotPassword.Click += btn_ForgotPassword_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(52, 106);
            label2.Name = "label2";
            label2.Size = new Size(100, 15);
            label2.TabIndex = 6;
            label2.Text = "Current Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(52, 153);
            label3.Name = "label3";
            label3.Size = new Size(84, 15);
            label3.TabIndex = 7;
            label3.Text = "New Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(52, 207);
            label4.Name = "label4";
            label4.Size = new Size(104, 15);
            label4.TabIndex = 8;
            label4.Text = "Confirm Password";
            // 
            // ChangePassword
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(350, 360);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btn_ForgotPassword);
            Controls.Add(btn_ChangePasswordButton);
            Controls.Add(txt_ConfirmPassword);
            Controls.Add(txt_NewPassword);
            Controls.Add(txt_CurrentPassword);
            Controls.Add(label1);
            MaximumSize = new Size(366, 399);
            MinimumSize = new Size(366, 399);
            Name = "ChangePassword";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ChangePassword";
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        private Label label1;
        private TextBox txt_CurrentPassword;
        private TextBox txt_NewPassword;
        private TextBox txt_ConfirmPassword;
        private Button btn_ChangePasswordButton;
        private Button btn_ForgotPassword;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}