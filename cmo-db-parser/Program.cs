using cmo_db_parser.Models;
using System;
using System.Collections.Generic;
using System.Data.SQLite;

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
            // Check if the user provided a path to the database file
            if (args.Length == 0)
            {
                Console.WriteLine("Please provide a path to the database file.");

                ConsoleExtensions.Pause();
                return;
            }

            string sqlFilePath = args[0];

            // Read the tables in the database
            CMODatabase.ReadTables(sqlFilePath);

            Export.ExportAircrafts();
            ConsoleExtensions.Pause();
        }

        
    }
}
