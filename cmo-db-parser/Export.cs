using cmo_db_parser.Models;
using System;
using System.IO;
using System.Linq;
using System.Text;

namespace cmo_db_parser
{
    internal class Export
    {
        internal static void ExportCSVs()
        {
            // Query the user to type a string of two characters matching the TwoLetterCode of the ISO.
            Console.WriteLine("Insert the two letter country code defined in the ISO 3166-1.");
            string twoLetterCode = Console.ReadLine().ToUpper();
            Console.Clear();

            if (!Directory.Exists(AppDomain.CurrentDomain.BaseDirectory + $"output\\{twoLetterCode}"))
            {
                Directory.CreateDirectory(AppDomain.CurrentDomain.BaseDirectory + $"output\\{twoLetterCode}");
            }

            ExportAircrafts(twoLetterCode);
        }
        private static void ExportAircrafts(string twoLetterCode)
        {
            StringBuilder sb = new StringBuilder();
            // Print the header
            sb.AppendLine(
                "ID; " +
                "Category; " +
                "Type; " +
                "Name; " +
                "Comments; " +
                "Country; " +
                "Service; " +
                "YearCommissioned; " +
                "YearDecommissioned; " +
                "Length; " +
                "Span; " +
                "Height; " +
                "WeightEmpty; " +
                "WeightMax; " +
                "WeightPayload; " +
                "Crew; " +
                "Agility; " +
                "ClimbRate; " +
                "AutonomousControlLevel; " +
                "CockpitGen; " +
                "Ergonomics; " +
                "OADADetectionCycle; " +
                "OADATargetingCycle; " +
                "OADAEvasiveCycle; " +
                "TotalEndurance; " +
                "PhysicalSizeCode; " +
                "RunwayLengthCode; " +
                "Hypothetical; " +
                "Cost; " +
                "DamagePoints; " +
                "AircraftEngineArmor; " +
                "AircraftFuselageArmor; " +
                "AircraftCockpitArmor; " +
                "Visibility; " +
                "FuelOffloadRate; " +
                "Deprecated");

            // Print the aircraft names and countries
            var entries = DataAircraft.DataEntries.OfType<DataAircraft>().ToList();
            // Sort by country two letter code, and then by service.
            entries = entries.OrderBy(x => x.OperatorCountry.TwoLetterCode).ThenBy(x => x.OperatorService.Description).ThenBy(x => x.Name).ThenBy(x => x.YearCommissioned).ToList();

            foreach (DataAircraft aircraft in entries)
            {
                if (aircraft.OperatorCountry.TwoLetterCode != twoLetterCode)
                {
                    continue;
                }

                sb.AppendLine(
                    $"{aircraft.ID}; " +
                    $"{aircraft.Category.Description}; " +
                    $"{aircraft.Type.Description}; " +
                    $"{aircraft.Name}; " +
                    $"{aircraft.Comments}; " +
                    $"{aircraft.OperatorCountry.TwoLetterCode}; " +
                    $"{aircraft.OperatorService.Description}; " +
                    $"{aircraft.YearCommissioned}; " +
                    $"{aircraft.YearDecommissioned}; " +
                    $"{aircraft.Length}; " +
                    $"{aircraft.Span}; " +
                    $"{aircraft.Height}; " +
                    $"{aircraft.WeightEmpty}; " +
                    $"{aircraft.WeightMax}; " +
                    $"{aircraft.WeightPayload}; " +
                    $"{aircraft.Crew}; " +
                    $"{aircraft.Agility}; " +
                    $"{aircraft.ClimbRate}; " +
                    $"{aircraft.AutonomousControlLevel.Description}; " +
                    $"{aircraft.CockpitGen.Description}; " +
                    $"{aircraft.Ergonomics.Description}; " +
                    $"{aircraft.OADADetectionCycle}; " +
                    $"{aircraft.OADATargetingCycle}; " +
                    $"{aircraft.OADAEvasiveCycle}; " +
                    $"{aircraft.TotalEndurance}; " +
                    $"{aircraft.PhysicalSizeCode.Description}; " +
                    $"{aircraft.RunwayLengthCode.Description}; " +
                    $"{aircraft.Hypothetical}; " +
                    $"{aircraft.Cost}; " +
                    $"{aircraft.DamagePoints}; " +
                    $"{aircraft.AircraftEngineArmor.Description}; " +
                    $"{aircraft.AircraftFuselageArmor.Description}; " +
                    $"{aircraft.AircraftCockpitArmor.Description}; " +
                    $"{aircraft.Visibility.Description}; " +
                    $"{aircraft.FuelOffloadRate}; " +
                    $"{aircraft.Deprecated}");
            }

            File.WriteAllText(AppDomain.CurrentDomain.BaseDirectory + $"output\\{twoLetterCode}\\aircrafts.csv", sb.ToString());
        }
    }
}
