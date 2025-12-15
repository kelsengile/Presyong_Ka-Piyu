using Presyong_Ka_Piyu.Main.programs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Presyong_Ka_Piyu.Main.forms.PopUp_Forms.Info
{
    public partial class CategoryInfo : Form
    {
        private string connectionString = @"Data Source=C:\\Users\\conel\\Downloads\\Programs\\Projects\\Presyong_Ka-Piyu\\Main\\data\\Presyong_Ka-Piyu_Database.db";
        private int? selectedCategoryId = null;
        private Color defaultPanelColor = ThemeManager.IsDarkMode ? Color.FromArgb(40, 40, 40) : ThemeManager.LabelBackColor;
        private Color selectedPanelColor = Color.CadetBlue;
        private string selectedCategoryType = null;

        public CategoryInfo()
        {
            InitializeComponent();
            ThemeManager.ApplyTheme(this);
            LoadCategories();
        }

        private void LoadCategories()
        {
            flpStoreCategories.Controls.Clear();
            flpProductCategories.Controls.Clear();

            using var conn = new SQLiteConnection(connectionString);
            conn.Open();

            string sql = "SELECT Id, CategoryName, CategoryType, Description FROM Categories ORDER BY CategoryType, CategoryName";

            using var cmd = new SQLiteCommand(sql, conn);
            using var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                int id = Convert.ToInt32(reader["Id"]);
                string name = reader["CategoryName"].ToString();
                string type = reader["CategoryType"].ToString();
                string desc = reader["Description"].ToString();

                var panel = CreateCategoryItem(id, name, desc, type);

                if (type == "Store")
                    flpStoreCategories.Controls.Add(panel);
                else
                    flpProductCategories.Controls.Add(panel);
            }
        }

        private Panel CreateCategoryItem(int id, string name, string description, string type)
        {
            Panel panel = new Panel
            {
                Width = 420,
                Height = 50,
                BorderStyle = BorderStyle.FixedSingle,
                Tag = new { Id = id, Type = type },
                Cursor = Cursors.Hand,
                BackColor = defaultPanelColor
            };

            Label lbl = new Label
            {
                Text = $"{name} | {description}",
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleLeft,
                Font = new Font(ThemeManager.SelectedFont, 10),
                BackColor = panel.BackColor,
                ForeColor = ThemeManager.IsDarkMode ? Color.White : ThemeManager.LabelForeColor
            };

            panel.Controls.Add(lbl);

            // Attach click event to panel and all children
            AttachClickEvent(panel, panel_Click);

            return panel;
        }

        private void AttachClickEvent(Control parent, EventHandler handler)
        {
            parent.Click += handler;
            foreach (Control c in parent.Controls)
                AttachClickEvent(c, handler); // recursive
        }

        private void panel_Click(object sender, EventArgs e)
        {
            Panel panel = sender as Panel ?? (sender as Control)?.Parent as Panel;
            if (panel != null)
                SelectCategory(panel);
        }

        private void SelectCategory(Panel panel)
        {
            // Check if the panel is already selected
            bool isAlreadySelected = panel.BackColor == selectedPanelColor;

            // Deselect all panels first
            foreach (Panel p in flpStoreCategories.Controls)
                p.BackColor = defaultPanelColor;
            foreach (Panel p in flpProductCategories.Controls)
                p.BackColor = defaultPanelColor;

            // Reset font style for all labels
            foreach (Panel p in flpStoreCategories.Controls)
                if (p.Controls[0] is Label lbl) lbl.Font = new Font(lbl.Font, FontStyle.Regular);
            foreach (Panel p in flpProductCategories.Controls)
                if (p.Controls[0] is Label lbl) lbl.Font = new Font(lbl.Font, FontStyle.Regular);

            // If it wasn't already selected, select it
            if (!isAlreadySelected)
            {
                panel.BackColor = selectedPanelColor;
                if (panel.Controls.Count > 0 && panel.Controls[0] is Label lbl)
                    lbl.Font = new Font(lbl.Font, FontStyle.Bold);

                // Store selection info
                dynamic tag = panel.Tag;
                selectedCategoryId = tag.Id;
                selectedCategoryType = tag.Type;
            }
            else
            {
                // If already selected, deselect
                selectedCategoryId = -1;    // or null if using nullable int
                selectedCategoryType = null;
            }
        }



        private void BtnDeleteSelected_Click(object sender, EventArgs e)
        {
            if (selectedCategoryId == null)
            {
                CustomMessageBox.Show("Please select a category first.");
                return;
            }

            var result = MessageBox.Show(
                $"Are you sure you want to delete the selected {selectedCategoryType} category?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                using var conn = new SQLiteConnection(connectionString);
                conn.Open();
                using var cmd = new SQLiteCommand("DELETE FROM Categories WHERE Id=@Id", conn);
                cmd.Parameters.AddWithValue("@Id", selectedCategoryId);
                cmd.ExecuteNonQuery();

                // Refresh categories
                selectedCategoryId = null;
                selectedCategoryType = null;
                LoadCategories();
            }
        }

        private void lblStores_Click(object sender, EventArgs e)
        {

        }
    }
}