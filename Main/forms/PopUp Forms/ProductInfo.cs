using Presyong_Ka_Piyu.Main.programs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Presyong_Ka_Piyu.Main.forms.PopUp_Forms
{
    public partial class ProductInfo : Form
    {
        public ProductInfo()
        {
            InitializeComponent();
            ThemeManager.ApplyTheme(this);
        }
    }
}
