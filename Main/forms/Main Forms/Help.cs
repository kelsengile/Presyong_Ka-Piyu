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
    public partial class Help : Form
    {
        public Help()
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

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Question1_Button(object sender, EventArgs e)
        {
            CustomMessageBox.Show("Kasi Masakit");
        }

        private void Question2_Button(object sender, EventArgs e)
        {
            CustomMessageBox.Show("Kasi");
        }

        private void Question3_Button(object sender, EventArgs e)
        {
            CustomMessageBox.Show("Napakaangas");
        }

        private void Question4_Button(object sender, EventArgs e)
        {
            CustomMessageBox.Show("Napakaangas");
        }

        private void Question5_Button(object sender, EventArgs e)
        {
            CustomMessageBox.Show("Napakaangas");
        }

        private void Question6_Button(object sender, EventArgs e)
        {
            CustomMessageBox.Show("Napakaangas");
        }

        private void Question7_Button(object sender, EventArgs e)
        {
            CustomMessageBox.Show("Napakaangas");
        }

        private void Question8_Button(object sender, EventArgs e)
        {
            CustomMessageBox.Show("Napakaangas");
        }

        private void Question9_Button(object sender, EventArgs e)
        {
            CustomMessageBox.Show("Napakaangas");
        }

        private void Question10_Button(object sender, EventArgs e)
        {
            CustomMessageBox.Show("Napakaangas");
        }

        private void AskSpecificQuestions_Button(object sender, EventArgs e)
        {
            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = "mailto:presyongkapiyu@gmail.com",
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to open email client: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
    
