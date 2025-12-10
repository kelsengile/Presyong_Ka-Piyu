using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Presyong_Ka_Piyu.Main.forms.Main_Forms
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
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
            PopUp_Forms.Menu panel = new PopUp_Forms.Menu();
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
    }
}