using Presyong_Ka_Piyu.Main.programs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Presyong_Ka_Piyu.Main.forms
{
    public partial class CustomMessageBox : Form
    {

        private static string messageToShow = "";
        public CustomMessageBox()
        {

            InitializeComponent();
            ThemeManager.ApplyTheme(this);
        }

        public static void Show(string message)
        {
            messageToShow = message;

            CustomMessageBox box = new CustomMessageBox();
            box.StartPosition = FormStartPosition.CenterScreen;
            box.ShowDialog();
        }

        // Loads message into label when form opens
        private void CustomMessageBox_Load(object sender, EventArgs e)
        {
            lblMessage.Text = messageToShow;

            // Prevent resizing
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        // Close button
        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
  