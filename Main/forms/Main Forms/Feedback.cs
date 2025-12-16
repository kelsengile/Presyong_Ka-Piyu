using Presyong_Ka_Piyu.Main.programs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static Presyong_Ka_Piyu.Login;

namespace Presyong_Ka_Piyu.Main.forms.Main_Forms
{
    public partial class Feedback : Form
    {
        public Feedback()
        {
            InitializeComponent();
            ThemeManager.ApplyTheme(this);
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

        private void button1_Click(object sender, EventArgs e)
        {
            string url = "https://www.facebook.com/profile.php?id=61585260779651"; // Replace with your website
            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to open the website. " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string url = "https://www.instagram.com/presyongkapiyu/"; // Replace with your website
            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to open the website. " + ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string email = "presyongkasgkapiyu@gmail.com";
                string subject = Uri.EscapeDataString("Hello from Presyong Ka-Piyu App");
                string body = Uri.EscapeDataString("Hi,\n\nI would like to contact you regarding...");

                // Gmail compose URL
                string gmailUrl = $"https://mail.google.com/mail/?view=cm&fs=1&to={email}&su={subject}&body={body}";

                Process.Start(new ProcessStartInfo
                {
                    FileName = gmailUrl,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                CustomMessageBox.Show("Unable to open Gmail. " + ex.Message);
            }
        }
    }
}