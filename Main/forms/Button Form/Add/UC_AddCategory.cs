using Presyong_Ka_Piyu.Main.forms.PopUp_Forms.Info;
using Presyong_Ka_Piyu.Main.programs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Presyong_Ka_Piyu.Main.forms.Button_Form
{
    public partial class UC_AddCategory : UserControl
    {
        private readonly string connectionString = "Data Source=C:\\Users\\acer nitro v15\\source\\repos\\Presyong_Ka-Piyu\\Design\\Main\\data\\Presyong_Ka-Piyu_Database.db";

        public UC_AddCategory()
        {
            InitializeComponent();
            
            LoadCategoryTypes();
        }

        private void LoadCategoryTypes()
        {
            cmbCategoryType.Items.Add("Product");
            cmbCategoryType.Items.Add("Store");
            cmbCategoryType.SelectedIndex = 0;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCategoryName.Text))
            {
                CustomMessageBox.Show("Category name is required.");
                return;
            }

            using var conn = new SQLiteConnection(connectionString);
            conn.Open();

            try
            {
                using var cmd = new SQLiteCommand(@"
                    INSERT INTO Categories
                    (CategoryName, CategoryType, Description)
                    VALUES
                    (@Name, @Type, @Description);", conn);

                cmd.Parameters.AddWithValue("@Name", txtCategoryName.Text.Trim());
                cmd.Parameters.AddWithValue("@Type", cmbCategoryType.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@Description", txtDescription.Text.Trim());

                cmd.ExecuteNonQuery();

                CustomMessageBox.Show("Category added successfully!");
                var addForm = this.FindForm() as Add;
                addForm?.RestartAddForm();
            }
            catch (Exception ex)
            {
                CustomMessageBox.Show(ex.Message);
            }
        }



        private void btnCancel_Click(object sender, EventArgs e)
        {
            var addForm = this.FindForm() as Add;
            addForm?.RestartAddForm();
        }

        private void UC_AddCategory_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CategoryInfo categoryInfoForm = new CategoryInfo();
            categoryInfoForm.Show();
        }
    }
}