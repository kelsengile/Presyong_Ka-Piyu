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

        private List<(string Question, string Answer)> faqs = new List<(string, string)>
{
    ("What is Presyong Ka-Piyu?", "Presyong Ka-Piyu is an app to track product prices across LSPU stores."),
    ("How can I add a new store?", "Go to the Add Store section and fill in the store details."),
    ("How to report a price issue?", "Contact us via email: presyongkasgkapiyu@gmail.com."),
    ("Is the app free to use?", "Yes! The app is completely free for all students and faculty."),
    ("Can I mark my favorite stores?", "Yes, you can mark any store as favorite in the store details section."),
    ("How do I search for products?", "Use the search bar on the main screen to find products by name or category."),
    ("Can I edit store information?", "Yes, you can edit store details if you have the proper access rights."),
    ("Does the app support multiple campuses?", "Currently, the app supports only LSPU Main Campus (Santa Cruz)."),
    ("Can I see store ratings?", "Yes, each store shows an average rating based on user inputs."),
    ("How are prices updated?", "Prices are updated manually by the store owners or admin users."),
    ("What if a store is closed temporarily?", "You can mark it as inactive or remove it from your favorites."),
    ("Can I suggest new categories or products?", "Yes, you can send your suggestions via the contact email."),
    ("Is there a dark mode in the app?", "Yes! Enable dark mode in the settings to reduce eye strain."),
    ("How do I view a store's products?", "Click on a store in the marketplace to see its products along with prices and ratings."),
    ("Is my data saved locally or online?", "Data is saved locally in the app's SQLite database, ensuring offline access.")
};

        public Help()
        {
            InitializeComponent();
            ThemeManager.ApplyTheme(this);


            LoadFAQ();
        }

        private void LoadFAQ()
        {
            flpFAQ.Controls.Clear();

            foreach (var faq in faqs)
            {
                Panel panel = new Panel
                {
                    Width = flpFAQ.ClientSize.Width - 25,
                    Height = 50,
                    Margin = new Padding(5),
                    BackColor = Color.WhiteSmoke
                };

                Label lblQuestion = new Label
                {
                    Text = faq.Question,
                    AutoSize = false,
                    Width = panel.Width - 120,
                    Height = 50,
                    Location = new Point(10, 10),
                    Font = new Font("Segoe UI", 10, FontStyle.Regular)
                };

                Button btnAnswer = new Button
                {
                    Text = "Show Answer",
                    Location = new Point(panel.Width - 100, 10),
                    Size = new Size(90, 30)
                };
                btnAnswer.Click += (s, e) => MessageBox.Show(faq.Answer, "Answer", MessageBoxButtons.OK, MessageBoxIcon.Information);

                panel.Controls.Add(lblQuestion);
                panel.Controls.Add(btnAnswer);

                flpFAQ.Controls.Add(panel);
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



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string email = "presyongkasgkapiyu@gmail.com";
                string subject = Uri.EscapeDataString("Hello from Presyong Ka-Piyu App");
                string body = Uri.EscapeDataString("Hi,\n\nI would like to contact you regarding...");

                // Gmail compose URL
                string gmailUrl = $"https://mail.google.com/mail/?view=cm&fs=1&to={email}&su={subject}&body={body}";

                Process.Start(new ProcessStartInfo
                {
                    FileName = gmailUrl,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                CustomMessageBox.Show("Unable to open Gmail. " + ex.Message);
            }
        }
    }
}
    
