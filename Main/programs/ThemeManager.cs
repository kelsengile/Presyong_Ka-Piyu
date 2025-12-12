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

        // User-defined colors for normal mode
        public static Color DefaultBackColor { get; set; } = SystemColors.GradientActiveCaption;
        public static Color DefaultForeColor { get; set; } = Color.Black;

        public static Color PanelBackColor { get; set; } = SystemColors.ActiveCaption;
        public static Color PanelForeColor { get; set; } = Color.Black;

        public static Color ButtonBackColor { get; set; } = SystemColors.Control;
        public static Color ButtonForeColor { get; set; } = Color.Black;

        public static Color LabelBackColor { get; set; } = SystemColors.GradientActiveCaption;
        public static Color LabelForeColor { get; set; } = Color.Black;

        // Apply theme to any form
        public static void ApplyTheme(Form form)
        {
            form.Font = new Font(SelectedFont, form.Font.Size);

            if (IsDarkMode)
            {
                form.BackColor = Color.FromArgb(40, 40, 40);
                form.ForeColor = Color.White;
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
                    c.ForeColor = Color.White;

                    if (c is Panel)
                        c.BackColor = Color.FromArgb(55, 55, 55);
                    else if (c is Button)
                        c.BackColor = Color.FromArgb(80, 80, 80);
                    else
                        c.BackColor = Color.FromArgb(40, 40, 40);
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