using Presyong_Ka_Piyu.Main.forms.Main_Forms;
using Presyong_Ka_Piyu.Main.forms.PopUp_Forms;
using Presyong_Ka_Piyu.Main.programs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static Presyong_Ka_Piyu.Login;

namespace Presyong_Ka_Piyu.Main.forms
{
    public partial class Map : Form
    {
        private string connectionString = @"Data Source=C:\Users\conel\Downloads\Programs\Projects\Presyong_Ka-Piyu\Main\data\Presyong_Ka-Piyu_Database.db";

        public Map()
        {
            InitializeComponent();
            ThemeManager.ApplyTheme(this);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

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


        private void OpenMarketplaceByLocation(string locationName)
        {
            int locationId = -1;

            using (var conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                using var cmd = new SQLiteCommand("SELECT Id FROM Locations WHERE LocationName=@LocationName", conn);
                cmd.Parameters.AddWithValue("@LocationName", locationName);

                var result = cmd.ExecuteScalar();
                if (result != null)
                    locationId = Convert.ToInt32(result);
            }

            if (locationId != -1)
            {
                var marketplace = new MarketPlace(locationId, locationName);
                marketplace.ShowDialog();
            }
            else
            {
                MessageBox.Show("No stores found for this location.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void mapBox_Click(object sender, EventArgs e)
        {

        }



        // ===============================
        // BUTTON CLICK HANDLERS
        // ===============================

        private void btn_Cafeteria1_Click(object sender, EventArgs e)
        {
            OpenMarketplaceByLocation("Cafeteria 1");
        }

        private void btn_Cafeteria2_Click(object sender, EventArgs e)
        {
            OpenMarketplaceByLocation("Cafeteria 2");
        }



        private void btn_PrintingService2_Click(object sender, EventArgs e)
        {
            OpenMarketplaceByLocation("Printing Service 2");
        }

        private void btn_gate1_Click_1(object sender, EventArgs e)
        {
            OpenMarketplaceByLocation("GATE1");
        }

        private void btn_Gate2_Click(object sender, EventArgs e)
        {
            OpenMarketplaceByLocation("GATE2");
        }

        private void btn_ActivityCenter_Click(object sender, EventArgs e)
        {
            OpenMarketplaceByLocation("Activity Center");
        }

        private void btn_CCS_Click(object sender, EventArgs e)
        {
            OpenMarketplaceByLocation("CCS");
        }

        private void btn_CIT_Click(object sender, EventArgs e)
        {
            OpenMarketplaceByLocation("CIT");
        }

        private void btn_CIT2_Click(object sender, EventArgs e)
        {
            OpenMarketplaceByLocation("CIT");
        }

        private void btn_CCJE_Click(object sender, EventArgs e)
        {
            OpenMarketplaceByLocation("CCJE");
        }

        private void btn_CBAA_Click(object sender, EventArgs e)
        {
            OpenMarketplaceByLocation("CBAA");
        }

        private void btn_CTECAS_Click(object sender, EventArgs e)
        {
            OpenMarketplaceByLocation("CTE/CAS");
        }

        private void btn_CIHTM_Click(object sender, EventArgs e)
        {
            OpenMarketplaceByLocation("CIHTM");
        }

        private void btn_CONAH_Click(object sender, EventArgs e)
        {
            OpenMarketplaceByLocation("CONAH");
        }

        private void btn_COE_Click(object sender, EventArgs e)
        {
            OpenMarketplaceByLocation("COE");
        }

        private void btn_Automotive_Click(object sender, EventArgs e)
        {
            OpenMarketplaceByLocation("Automotive");
        }

        private void btn_Hotel_Click(object sender, EventArgs e)
        {
            OpenMarketplaceByLocation("Hotel");
        }

        private void btn_Church_Click(object sender, EventArgs e)
        {
            OpenMarketplaceByLocation("Church");
        }

        private void btn_Admin_Click(object sender, EventArgs e)
        {
            OpenMarketplaceByLocation("Admin");
        }

        private void btn_Library_Click(object sender, EventArgs e)
        {
            OpenMarketplaceByLocation("Library");
        }

        private void btn_Court_Click(object sender, EventArgs e)
        {
            OpenMarketplaceByLocation("Court");
        }

        private void btn_TheGears_Click(object sender, EventArgs e)
        {
            OpenMarketplaceByLocation("The Gears");
        }

        private void btn_OpenField_Click(object sender, EventArgs e)
        {
            OpenMarketplaceByLocation("OPEN FIELD");
        }

        private void btn_GrandStand_Click(object sender, EventArgs e)
        {
            OpenMarketplaceByLocation("GRAND STAND");
        }

        private void btn_BAO_Click(object sender, EventArgs e)
        {
            OpenMarketplaceByLocation("BAO");
        }

        private void btn_XeroxService_Click_1(object sender, EventArgs e)
        {
            OpenMarketplaceByLocation("Xerox Service");
        }

        private void btn_Admin_Click_1(object sender, EventArgs e)
        {
            OpenMarketplaceByLocation("Admin");
        }

        private void btn_CCS_Click_1(object sender, EventArgs e)
        {
            OpenMarketplaceByLocation("CCS");
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}



