using cmo_db_parser.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cmo_db_parser
{
    internal class Export
    {
        internal static void ExportAircrafts()
        {
            // Print the header
            Console.WriteLine("Aircrafts");
            Console.WriteLine(
                "Name," +
                "Type," +
                "Country," +
                "Service" +
                "");

            // Print the aircraft names and countries
            foreach (Aircraft aircraft in Aircraft.DataEntries.OfType<Aircraft>())
            {
                if (aircraft.OperatorCountry.Description != "Brazil")
                {
                    continue;
                }

                Console.WriteLine($"" +
                    $"{aircraft.Name}," +
                    $"{aircraft.Type.Description}," +
                    $"{aircraft.OperatorCountry.Description}," +
                    $"{aircraft.OperatorService.Description}" +
                    $"");
            }
        }
    }
}
