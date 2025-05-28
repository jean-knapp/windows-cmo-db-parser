using cmo_db_parser.Models;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Globalization;

namespace cmo_db_parser
{
    internal class Program
    {
        
        /// <summary>
        /// Main entry point for the application
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // Set language and decimal to international
            CultureInfo.DefaultThreadCurrentCulture = System.Globalization.CultureInfo.InvariantCulture;

            // Check if the user provided a path to the database file
            if (args.Length == 0)
            {
                Console.WriteLine("Please provide a path to the database file.");

                ConsoleExtensions.Pause();
                return;
            }

            string sqlFilePath = args[0];

            string descriptionFolder = args[1];
            string imagesFolder = args[1];

            // Read the tables in the database
            CMODatabase.ReadTables(sqlFilePath);

            CMODatabase.ReadDescriptions(descriptionFolder);

            Export.ExportCSVs();
            Export.CopyImages(imagesFolder);
            ConsoleExtensions.Pause();
        }

        
    }
}
