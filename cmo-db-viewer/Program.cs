using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.UserSkins;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace cmo_db_viewer
{
    internal static class Program
    {
        internal static string SqlFilePath { get; private set; }
        internal static string DescriptionFolder { get; private set; }
        internal static string ImagesFolder { get; private set; }
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            // Set language and decimal to international
            CultureInfo.DefaultThreadCurrentCulture = System.Globalization.CultureInfo.InvariantCulture;

            SqlFilePath = args[0];
            DescriptionFolder = args[1];
            ImagesFolder = args[1];

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
