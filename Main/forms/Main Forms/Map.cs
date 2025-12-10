using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Presyong_Ka_Piyu.Main.forms
{
    public partial class Map : Form
    {
        public Map()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }

        // Open the Panel Form
        private void btnPanel_Click(object sender, EventArgs e)
        {
            PopUp_Forms.Menu panel = new PopUp_Forms.Menu();
            panel.Show();
        }

        // Open the Search Form
        private void btnSearch_Click(object sender, EventArgs e)
        {
            PopUp_Forms.Search search = new PopUp_Forms.Search();
            search.Show();
        }

        // Open the Add Form
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Add add = new Add();
            add.Show();
        }

        private void mapBox_Click(object sender, EventArgs e)
        {

        }
    }
}
