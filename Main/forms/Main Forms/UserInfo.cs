using Microsoft.VisualBasic.ApplicationServices;
using Presyong_Ka_Piyu.Main.forms.PopUp_Forms;
using Presyong_Ka_Piyu.Main.programs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Windows.Forms;
using static Presyong_Ka_Piyu.Login;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Presyong_Ka_Piyu.Main.forms.Main_Forms
{
    public partial class UserInfo : Form
    {
        public int LoggedInUserId;
        private string connectionString = @"Data Source=C:\Users\conel\Downloads\Programs\Projects\Presyong_Ka-Piyu\Main\data\Presyong_Ka-Piyu_Database.db";



        public UserInfo(int userId)
        {
            InitializeComponent();
            ThemeManager.ApplyTheme(this);

            txtAccountID.ReadOnly = true;
            txtCreatedAt.ReadOnly = true;
            txtRole.ReadOnly = true;

            LoggedInUserId = userId;
            LoadUserInfo();
        }


        private void LoadUserInfo()
        {
            using (var con = new SQLiteConnection(connectionString))
            {
                con.Open();
                string query = "SELECT * FROM Users WHERE AccountId = @id";

                using (var cmd = new SQLiteCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@id", LoggedInUserId);

                    using (var reader = cmd.ExecuteReader()) // <-- use "using" here
                    {
                        if (reader.Read())
                        {
                            txtUsername.Text = reader["Username"].ToString();
                            txtFullName.Text = reader["FullName"].ToString();
                            txtEmail.Text = reader["Email"].ToString();
                            txtSchoolID.Text = reader["SchoolID"].ToString();
                            txtBio.Text = reader["Bio"].ToString();
                            txtCourse.Text = reader["Course"].ToString();
                            txtDepartment.Text = reader["Department"].ToString();
                            txtContactNumber.Text = reader["ContactNumber"].ToString();
                            txtContactFacebook.Text = reader["ContactFacebook"].ToString();
                            txtContactInsta.Text = reader["ContactInsta"].ToString();
                            txtAddress.Text = reader["Address"].ToString();

                            txtAccountID.Text = reader["AccountId"].ToString();
                            txtCreatedAt.Text = reader["CreatedAt"].ToString();
                            txtRole.Text = reader["Role"].ToString();


                            if (DateTime.TryParse(reader["DateOfBirth"]?.ToString(), out DateTime dob))
                                dtpDateOfBirth.Value = dob;

                            string path = reader["ProfilePicture"].ToString();
                            if (!string.IsNullOrEmpty(path) && File.Exists(path))
                            {
                                picProfile.Image = Image.FromFile(path);
                            }
                            else
                            {
                                picProfile.Image = null; // or default avatar
                            }
                        }
                    } // <-- reader disposed here
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (var con = new SQLiteConnection(connectionString))
            {
                con.Open();

                string query = @"
                    UPDATE Users SET
                        Username=@Username,
                        FullName=@FullName,
                        Email=@Email,
                        SchoolID=@SchoolID,
                        Bio=@Bio,
                        Course=@Course,
                        Department=@Department,
                        ContactNumber=@ContactNumber,
                        ContactFacebook=@FB,
                        ContactInsta=@Insta,
                        DateOfBirth=@DOB,
                        Address=@Address
                    WHERE AccountId=@id";

                using (var cmd = new SQLiteCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Username", txtUsername.Text);
                    cmd.Parameters.AddWithValue("@FullName", txtFullName.Text);
                    cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@SchoolID", txtSchoolID.Text);
                    cmd.Parameters.AddWithValue("@Bio", txtBio.Text);
                    cmd.Parameters.AddWithValue("@Course", txtCourse.Text);
                    cmd.Parameters.AddWithValue("@Department", txtDepartment.Text);
                    cmd.Parameters.AddWithValue("@ContactNumber", txtContactNumber.Text);
                    cmd.Parameters.AddWithValue("@FB", txtContactFacebook.Text);
                    cmd.Parameters.AddWithValue("@Insta", txtContactInsta.Text);
                    cmd.Parameters.AddWithValue("@DOB", dtpDateOfBirth.Value.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
                    cmd.Parameters.AddWithValue("@id", LoggedInUserId);

                    cmd.ExecuteNonQuery();

                }
            }

            CustomMessageBox.Show("Profile updated successfully!");
        }


        private void btnChangePicture_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png";
                ofd.Title = "Select Profile Picture";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    // Display the image immediately
                    picProfile.Image = Image.FromFile(ofd.FileName);

                    // Save the picture path to the database
                    SaveProfilePicture(ofd.FileName);
                }
            }
        }


        private void SaveProfilePicture(string path)
        {
            try
            {
                using (var con = new SQLiteConnection(connectionString))
                {
                    con.Open();
                    string query = "UPDATE Users SET ProfilePicture=@pic WHERE AccountId=@id";

                    using (var cmd = new SQLiteCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@pic", path);
                        cmd.Parameters.AddWithValue("@id", LoggedInUserId);
                        cmd.ExecuteNonQuery();
                    }
                }

                CustomMessageBox.Show("Profile picture updated successfully!");
            }
            catch (Exception ex)
            {
                CustomMessageBox.Show("Error updating profile picture: " + ex.Message);
            }
        }




        private void changeemailclose()
        {
            for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
            {
                Form frm = Application.OpenForms[i];

                if (frm is PopUp_Forms.ChangeEmailOTP
                    )
                {
                    frm.Close();
                }
            }
        }

        private void btnChange_Email_Click(object sender, EventArgs e)
        {
            string newEmail = txtEmail.Text.Trim();
            if (string.IsNullOrEmpty(newEmail))
            {
                CustomMessageBox.Show("Enter a valid email.");
                return;
            }

            changeemailclose();

            // Open the OTP verification form
            PopUp_Forms.ChangeEmailOTP otpForm = new PopUp_Forms.ChangeEmailOTP(LoggedInUserId, newEmail);
            otpForm.ShowDialog();

            // Reload user info after OTP verification
            LoadUserInfo();
        }








        // Open the Panel Form

        private void menuclose()
        {
            for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
            {
                Form frm = Application.OpenForms[i];
                if (frm is PopUp_Forms.Menu)
                {
                    frm.Close();
                }
            }
        }
        private void btnMenu_Click(object sender, EventArgs e)
        {
            menuclose();
            PopUp_Forms.Menu panel = new PopUp_Forms.Menu(Session.LoggedInUserId);
            panel.Show();
        }

        // Open the Search Form

        private void searchclose()
        {
            for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
            {
                Form frm = Application.OpenForms[i];
                if (frm is PopUp_Forms.Search)
                {
                    frm.Close();
                }
            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            searchclose();
            PopUp_Forms.Search search = new PopUp_Forms.Search();
            search.Show();
        }

        // Open the Add Form

        private void addclose()
        {
            for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
            {
                Form frm = Application.OpenForms[i];
                if (frm is Add)
                {
                    frm.Close();
                }
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            addclose();
            Add add = new Add();
            add.Show();
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void picProfile_Click(object sender, EventArgs e)
        {

        }

        private void txtFullName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSchoolID_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblProfilePicture_Click(object sender, EventArgs e)
        {

        }

        private void lblBio_Click(object sender, EventArgs e)
        {

        }



        private void lblCourse_Click(object sender, EventArgs e)
        {

        }

        private void txtDepartment_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblContactNumber_Click(object sender, EventArgs e)
        {

        }

        private void txtAccountNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void picProfile_Click_1(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }



        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }


        private void changepassclose()
        {
            for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
            {
                Form frm = Application.OpenForms[i];

                if (frm is ChangePassword
                    )
                {
                    frm.Close();
                }
            }
        }
        private void btn_ChangePassword_Click(object sender, EventArgs e)
        {
            changepassclose();

            ChangePassword changepassword = new ChangePassword(LoggedInUserId);
            changepassword.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show(
        "Are you sure you want to permanently delete your account?",
        "Delete Account",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Warning);

            if (confirm != DialogResult.Yes)
                return;

            try
            {
                using (var con = new SQLiteConnection(connectionString))
                {
                    con.Open();

                    string deleteQuery = "DELETE FROM Users WHERE AccountId = @id";

                    using (var cmd = new SQLiteCommand(deleteQuery, con))
                    {
                        cmd.Parameters.AddWithValue("@id", LoggedInUserId);
                        cmd.ExecuteNonQuery();
                    }
                }

                CustomMessageBox.Show("Your account has been deleted.");

                // Close all open forms
                foreach (Form frm in Application.OpenForms.Cast<Form>().ToList())
                {
                    frm.Close();
                }

                // Return to login screen
                Login login = new Login();
                login.Show();
            }
            catch (Exception ex)
            {
                CustomMessageBox.Show("Error deleting account:\n" + ex.Message);
            }
        }

    }
    
}
    
