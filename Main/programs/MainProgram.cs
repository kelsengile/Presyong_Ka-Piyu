using Presyong_Ka_Piyu.Main.programs;
using System.Runtime.InteropServices;

namespace Presyong_Ka_Piyu
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.

            Database.Initialize();

            ApplicationConfiguration.Initialize();
            Application.Run(new Login());

            
        }
    }
}