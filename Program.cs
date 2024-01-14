using static System.Net.Mime.MediaTypeNames;
using System;

namespace HMS_v1
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
            ApplicationConfiguration.Initialize();
            Application.Run(new StaffDashboardPage());

            // Color.FromArgb(0xFF, 0x3B, 0x85, 0x7E); dark green
            // Color.FromArgb(0xFF, 0xDA, 0xE8, 0xE6); light green
            // Color.FromArgb(0xFF, 0x65, 0x86, 0xAD); blue
        }
    }
}