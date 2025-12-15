using Microsoft.VisualBasic.ApplicationServices;
using Presyong_Ka_Piyu.Main.forms.Main_Forms;
using Presyong_Ka_Piyu.Main.programs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static Presyong_Ka_Piyu.Login;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Presyong_Ka_Piyu.Main.forms.PopUp_Forms
{
    public partial class Menu : Form
    {
        private int LoggedInUserId;
        private string connectionString = @"Data Source=C:\Users\conel\Downloads\Programs\Projects\Presyong_Ka-Piyu\Main\data\Presyong_Ka-Piyu_Database.db";
        

        public Menu(int userId)
        {
            InitializeComponent();
            ThemeManager.ApplyTheme(this);

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

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string username = reader["Username"].ToString();
                            string schoolID = reader["SchoolID"].ToString();

                            // Set TextBoxes
                            

                            // Set profile picture
                            string path = reader["ProfilePicture"].ToString();
                            if (!string.IsNullOrEmpty(path) && File.Exists(path))
                                picProfile.Image = Image.FromFile(path);
                            else
                                picProfile.Image = null; // default avatar

                            // **Set btnUserInfo text dynamically**
                            btnUserInfo.Text = $"Username: {username}\nSchoolID: {schoolID}";
                        }
                    }
                }
            }
        }






        private void close()
        {
            for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
            {
                Form frm = Application.OpenForms[i];

                if (frm is About ||
                    frm is Feedback ||
                    frm is Main_Forms.Help ||
                    frm is Map ||
                    frm is Settings ||
                    frm is UserInfo 
                    )
                {
                    frm.Close();
                }
            }
        }


        private void btnUserInfo_Click(object sender, EventArgs e)
        {
            close();

            UserInfo userinfo = new UserInfo(Session.LoggedInUserId);
            userinfo.Show();
            
        }

        private void btnMap_Click(object sender, EventArgs e)
        {
            close();

            Map map = new Map();
            map.Show();
            
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            close();

            Settings settings = new Settings();
            settings.Show();
            
        }

        private void btnFeedback_Click(object sender, EventArgs e)
        {
            close();

            Feedback feedback = new Feedback();
            feedback.Show();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            close();

            Main_Forms.Help help = new Main_Forms.Help();
            help.Show();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            close();

            About about = new About();
            about.Show();
            
        }
    }
}