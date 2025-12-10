using Presyong_Ka_Piyu.Main.forms.Main_Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Presyong_Ka_Piyu.Main.forms.PopUp_Forms
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();

            
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
                    frm is UserInfo)
                {
                    frm.Close();
                }
            }
        }


        private void btnUserInfo_Click(object sender, EventArgs e)
        {
            close();

            UserInfo userinfo = new UserInfo();
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