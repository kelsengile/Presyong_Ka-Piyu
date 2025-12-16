using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace Presyong_Ka_Piyu.Main.programs
{
    internal class ThemeManager
    {
        // Global theme state
        public static bool IsDarkMode => Properties.Settings.Default.DarkMode;
        public static string SelectedFont => Properties.Settings.Default.AppFont;

        public static Color DarkBackColor { get; set; } = Color.FromArgb(40, 40, 40);
        public static Color DarkPanelBackColor { get; set; } = Color.FromArgb(55, 55, 55);
        public static Color DarkButtonBackColor { get; set; } = Color.FromArgb(80, 80, 80);
        public static Color DarkForeColor { get; set; } = Color.LightGray;
        public static Color DarkLabelForeColor { get; set; } = Color.Gainsboro;

        // User-defined colors for normal mode
        public static Color DefaultBackColor { get; set; } = SystemColors.GradientActiveCaption;
        public static Color DefaultForeColor { get; set; } = Color.Black;

        public static Color PanelBackColor { get; set; } = SystemColors.ActiveCaption;
        public static Color PanelForeColor { get; set; } = Color.Black;

        public static Color ButtonBackColor { get; set; } = SystemColors.Control;
        public static Color ButtonForeColor { get; set; } = Color.Black;

        public static Color LabelBackColor { get; set; } = SystemColors.GradientActiveCaption;
        public static Color LabelForeColor { get; set; } = Color.Black;

        public static Color TextBoxBackColor { get; set; } = SystemColors.Control;
        public static Color TextBoxForeColor { get; set; } = Color.Black;
        public static Color DarkUserControlBackColor { get; set; } = Color.FromArgb(45, 45, 45);

        // Apply theme to any form
        public static void ApplyTheme(Form form)
        {
            form.Font = new Font(SelectedFont, form.Font.Size);

            if (IsDarkMode)
            {
                form.BackColor = DarkBackColor;
                form.ForeColor = DarkForeColor;
            }

            else
            {
                form.BackColor = DefaultBackColor;
                form.ForeColor = DefaultForeColor;
            }

            ApplyThemeToControls(form.Controls);
        }

        // Apply theme recursively to all controls
        private static void ApplyThemeToControls(Control.ControlCollection controls)
        {
            foreach (Control c in controls)
            {
                c.Font = new Font(SelectedFont, c.Font.Size);

                if (IsDarkMode)
                {
                    if (c is Panel)
                    {
                        c.BackColor = DarkPanelBackColor;
                        c.ForeColor = DarkForeColor;
                    }
                    else if (c is Button)
                    {
                        c.BackColor = DarkButtonBackColor;
                        c.ForeColor = DarkForeColor;
                    }
                    else if (c is Label)
                    {
                        c.BackColor = Color.Transparent;
                        c.ForeColor = DarkLabelForeColor;
                    }
                    else if (c is TextBox)
                    {
                        c.BackColor = Color.FromArgb(60, 60, 60);
                        c.ForeColor = DarkForeColor;
                    }
                    else if (c is UserControl)
                    {
                        c.BackColor = DarkUserControlBackColor;
                        c.ForeColor = DarkForeColor;
                    }
                    else
                    {
                        c.BackColor = DarkBackColor;
                        c.ForeColor = DarkForeColor;
                    }
                }
                else
                {
                    // User-defined colors for normal mode
                    if (c is Panel)
                    {
                        c.BackColor = PanelBackColor;
                        c.ForeColor = PanelForeColor;
                    }
                    else if (c is Button)
                    {
                        c.BackColor = ButtonBackColor;
                        c.ForeColor = ButtonForeColor;
                    }
                    else if (c is Label)
                    {
                        c.BackColor = LabelBackColor;
                        c.ForeColor = LabelForeColor;
                    }
                    else if (c is TextBox)
                    {
                        c.BackColor = TextBoxBackColor;
                        c.ForeColor = TextBoxForeColor;
                    }
                    else
                    {
                        c.BackColor = DefaultBackColor;
                        c.ForeColor = DefaultForeColor;
                    }
                }

                // Recursion for nested controls
                if (c.HasChildren)
                    ApplyThemeToControls(c.Controls);
            }
        }

        // Switch theme and save
        public static void SetDarkMode(bool isDark)
        {
            Properties.Settings.Default.DarkMode = isDark;
            Properties.Settings.Default.Save();
        }

        // Change global font
        public static void SetFont(string fontName)
        {
            Properties.Settings.Default.AppFont = fontName;
            Properties.Settings.Default.Save();
        }
    }
}