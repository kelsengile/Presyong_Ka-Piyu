using Presyong_Ka_Piyu.Main.forms.PopUp_Forms;
using Presyong_Ka_Piyu.Main.programs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static Presyong_Ka_Piyu.Login;

namespace Presyong_Ka_Piyu.Main.forms.Main_Forms
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
            chkDarkMode.Checked = ThemeManager.IsDarkMode;
            ThemeManager.ApplyTheme(this);


        }

        private void chkDarkMode_CheckedChanged(object sender, EventArgs e)
        {
            ThemeManager.SetDarkMode(chkDarkMode.Checked);
            ThemeManager.ApplyTheme(this);

            // Update all open forms
            foreach (Form frm in Application.OpenForms)
                ThemeManager.ApplyTheme(frm);
        }

        private void btnChangeFont_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            fd.Font = new Font(ThemeManager.SelectedFont, 10);

            if (fd.ShowDialog() == DialogResult.OK)
            {
                ThemeManager.SetFont(fd.Font.Name);

                // Apply theme again globally
                foreach (Form f in Application.OpenForms)
                    ThemeManager.ApplyTheme(f);
            }
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


        private void UserInfoclose()
        {
            for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
            {
                Form frm = Application.OpenForms[i];
                if (frm is UserInfo ||
                    frm is Settings)
                {
                    frm.Close();
                }
            }
        }

        private void btnuserinfo_Click(object sender, EventArgs e)
        {
            UserInfoclose();

            UserInfo userInfoForm = new UserInfo(Session.LoggedInUserId);
            userInfoForm.Show();
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Settings_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void DataBaseViewerclose()
        {
            for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
            {
                Form frm = Application.OpenForms[i];

                if (frm is PopUp_Forms.DataBaseViewer
                    )
                {
                    frm.Close();
                }
            }
        }

        private void ViewTablesbutton_Click(object sender, EventArgs e)
        {
            DataBaseViewerclose();
            DataBaseViewer databaseviewer = new DataBaseViewer();
            databaseviewer.Show();
        }

        private void DeleteDatabutton_Click(object sender, EventArgs e)
        {
            ConfirmDelete confirmDelete = new ConfirmDelete();
            confirmDelete.Show();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}