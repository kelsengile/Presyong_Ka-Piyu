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
    public partial class Panel : Form
    {
        public Panel()
        {
            InitializeComponent();

            
        }

        



        private void btnUserInfo_Click(object sender, EventArgs e)
        {
            UserInfo f = new UserInfo();
            f.Show();
            
        }

        private void btnMap_Click(object sender, EventArgs e)
        {
            Map map = new Map();
            map.Show();
            
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            Settings f = new Settings();
            f.Show();
            
        }

        private void btnFeedback_Click(object sender, EventArgs e)
        {
            Feedback f = new Feedback();
            f.Show();
            

        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            Main_Forms.Help f = new Main_Forms.Help();
            f.Show();
            ;

        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            About f = new About();
            f.Show();
            
        }
    }
}