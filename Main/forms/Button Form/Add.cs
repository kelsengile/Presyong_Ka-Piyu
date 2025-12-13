using Presyong_Ka_Piyu.Main.forms.Button_Form;
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
    public partial class Add : Form
    {

        UC_AddProduct ucProduct;
        UC_AddShop ucShop;
        UC_AddCategory ucCategory;


        public Add()
        {
            InitializeComponent();
            ThemeManager.ApplyTheme(this);

            LoadUserControls();

            btnAddProduct.Click += btn_AddProduct_Click;
            btnAddShop.Click += btn_AddShop_Click;
            btnAddCategory.Click += btn_AddCategory_Click;

        }


        private void LoadUserControls()
        {
            ucProduct = new UC_AddProduct();
            ucShop = new UC_AddShop();
            ucCategory = new UC_AddCategory();

            panelContent.Controls.Add(ucProduct);
            panelContent.Controls.Add(ucShop);
            panelContent.Controls.Add(ucCategory);

            HideAll();
        }

        private void HideAll()
        {
            ucProduct.Hide();
            ucShop.Hide();
            ucCategory.Hide();
        }

        private void btn_AddProduct_Click(object sender, EventArgs e)
        {
            HideAll();
            ucProduct.Show();
            ucProduct.BringToFront();
        }

        private void btn_AddShop_Click(object sender, EventArgs e)
        {
            HideAll();
            ucShop.Show();
            ucShop.BringToFront();
        }

        private void btn_AddCategory_Click(object sender, EventArgs e)
        {
            HideAll();
            ucCategory.Show();
            ucCategory.BringToFront();
        }

        private void panelContent_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
