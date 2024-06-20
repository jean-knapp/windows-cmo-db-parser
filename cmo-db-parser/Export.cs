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
            //Console.WriteLine("Insert the two letter country code defined in the ISO 3166-1.");
            //string twoLetterCode = Console.ReadLine().ToUpper();
            Console.Clear();

            /*if (!Directory.Exists(AppDomain.CurrentDomain.BaseDirectory + $"output\\{twoLetterCode}"))
            {
                Directory.CreateDirectory(AppDomain.CurrentDomain.BaseDirectory + $"output\\{twoLetterCode}");
            }*/

            TestExport();
            //ExportExplosiveTypes();
            //ExportLoadouts();
            //ExportWeapons();
            //ExportAircrafts(twoLetterCode);
        }

        public static void ExportExplosiveTypes()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(
                "ID; " +
                "Name; " +
                "TNTEquivalent; " +
                "Comment");

            var entries2 = EnumWarheadExplosivesType.DataEntries;
            var entries = entries2.Values.OfType<EnumWarheadExplosivesType>().OrderBy(x => x.Description).ToList();

            foreach (EnumWarheadExplosivesType warhead_explosive in entries)
            {
                sb.AppendLine(
                    $"{warhead_explosive.ID};" +
                    $"{warhead_explosive.Description}; " +
                    $"{warhead_explosive.TNTEquivalent}; " +
                    $"{warhead_explosive.Comment.Replace("\r\n", " ")}; ");
            }

            File.WriteAllText(AppDomain.CurrentDomain.BaseDirectory + $"output\\explosive_types.csv", sb.ToString());
        }

        public static void TestExport()
        {
            DataAircraft dataAircraft = null;
            foreach(var item in DataAircraft.DataEntries.Values)
            {
                if ((item as DataAircraft).Name == "A-29B Super Tucano [EMB-314]")
                {
                    dataAircraft = (DataAircraft)item;
                    break;
                }
            }

            foreach(DataLoadout dataLoadout in dataAircraft.Loadouts)
            {
                Console.WriteLine($"{dataLoadout.Name} ({dataLoadout.ID})");

                foreach(DataWeaponRecord dataWeapon in dataLoadout.Weapons)
                {
                    Console.WriteLine($"{dataWeapon.Weapon.Name} - {dataWeapon.DefaultLoad}x - {dataWeapon.Weapon.Type.Description} - CEP {dataWeapon.Weapon.CEP}/{dataWeapon.Weapon.CEPSurface} ({dataWeapon.ID})");
                }
                Console.WriteLine("===============");
            }
        }

        public static void ExportWeapons()
        {
            StringBuilder sb = new StringBuilder();
            // Print the header
            sb.AppendLine(
                "ID; " +
                "Name; " +
                "Comments; " +
                "Type; " +
                "Generation; " +
                "ExplosiveType; " +
                "ExplosiveWeight; " +
                "Length; " +
                "Span; " +
                "Diameter; " +
                "Weight; " +
                "BurnoutTime; " +
                "BurnoutWeight; " +
                "CruiseAltitude; " +
                "CruiseAltitudeASL; " +
                "WaypointNumber; " +
                "IlluminationTime; " +
                "CEP; " +
                "CEPSurface; " +
                "AirPoK; " +
                "SurfacePoK; " +
                "LandPoK; " +
                "SubsurfacePoK; " +
                "ClimbRate; " +
                "AirRangeMax; " +
                "AirRangeMin; " +
                "SurfaceRangeMax; " +
                "SurfaceRangeMin; " +
                "LandRangeMax; " +
                "LandRangeMin; " +
                "SubsurfaceRangeMax; " +
                "SubsurfaceRangeMin; " +
                "LaunchSpeedMax; " +
                "LaunchSpeedMin; " +
                "LaunchAltitudeMax; " +
                "LaunchAltitudeMin; " +
                "LaunchAltitudeMaxASL; " +
                "LaunchAltitudeMinASL; " +
                "TargetSpeedMax; " +
                "TargetSpeedMin; " +
                "TargetAltitudeMax; " +
                "TargetAltitudeMin; " +
                "TargetAltitudeMaxASL; " +
                "TargetAltitudeMinASL; " +
                "SnapUpDownAltitude; " +
                "CanActAsSensor; " +
                "MaxFlightTime; " +
                "DetonationDelay; " +
                "TorpedoSpeedCruise; " +
                "TorpedoRangeCruise; " +
                "TorpedoFullSpeed; " +
                "TorpedoRangeFull; " +
                "Hypothetical; " +
                "BuddyIlluminationForCEC; " +
                "CargoType; " +
                "CargoMass; " +
                "CargoVolume; " +
                "CargoCrew; " +
                "CargoParadropCapable; " +
                "Cost; " +
                "Deprecated");

            // Print the weapon data
            var entries2 = DataWeapon.DataEntries;
            var entries = entries2.Values.OfType<DataWeapon>().OrderBy(x => x.Name).ThenBy(x => x.Type.Description).ToList();

            foreach (DataWeapon weapon in entries)
            {
                sb.AppendLine(
                    $"{weapon.ID}; " +
                    $"{weapon.Name}; " +
                    $"{weapon.Comments}; " +
                    $"{weapon.Type.Description}; " +
                    $"{weapon.Generation.Description}; " +
                    $"{weapon.Warhead?.ExplosiveType.Description ?? "-"}; " +
                    $"{weapon.Warhead?.ExplosiveWeight ?? 0}; " +
                    $"{weapon.Length}; " +
                    $"{weapon.Span}; " +
                    $"{weapon.Diameter}; " +
                    $"{weapon.Weight}; " +
                    $"{weapon.BurnoutTime}; " +
                    $"{weapon.BurnoutWeight}; " +
                    $"{weapon.CruiseAltitude}; " +
                    $"{weapon.CruiseAltitudeASL}; " +
                    $"{weapon.WaypointNumber}; " +
                    $"{weapon.IlluminationTime}; " +
                    $"{weapon.CEP}; " +
                    $"{weapon.CEPSurface}; " +
                    $"{weapon.AirPoK}; " +
                    $"{weapon.SurfacePoK}; " +
                    $"{weapon.LandPoK}; " +
                    $"{weapon.SubsurfacePoK}; " +
                    $"{weapon.ClimbRate}; " +
                    $"{weapon.AirRangeMax}; " +
                    $"{weapon.AirRangeMin}; " +
                    $"{weapon.SurfaceRangeMax}; " +
                    $"{weapon.SurfaceRangeMin}; " +
                    $"{weapon.LandRangeMax}; " +
                    $"{weapon.LandRangeMin}; " +
                    $"{weapon.SubsurfaceRangeMax}; " +
                    $"{weapon.SubsurfaceRangeMin}; " +
                    $"{weapon.LaunchSpeedMax}; " +
                    $"{weapon.LaunchSpeedMin}; " +
                    $"{weapon.LaunchAltitudeMax}; " +
                    $"{weapon.LaunchAltitudeMin}; " +
                    $"{weapon.LaunchAltitudeMaxASL}; " +
                    $"{weapon.LaunchAltitudeMinASL}; " +
                    $"{weapon.TargetSpeedMax}; " +
                    $"{weapon.TargetSpeedMin}; " +
                    $"{weapon.TargetAltitudeMax}; " +
                    $"{weapon.TargetAltitudeMin}; " +
                    $"{weapon.TargetAltitudeMaxASL}; " +
                    $"{weapon.TargetAltitudeMinASL}; " +
                    $"{weapon.SnapUpDownAltitude}; " +
                    $"{weapon.CanActAsSensor}; " +
                    $"{weapon.MaxFlightTime}; " +
                    $"{weapon.DetonationDelay}; " +
                    $"{weapon.TorpedoSpeedCruise}; " +
                    $"{weapon.TorpedoRangeCruise}; " +
                    $"{weapon.TorpedoFullSpeed}; " +
                    $"{weapon.TorpedoRangeFull}; " +
                    $"{weapon.Hypothetical}; " +
                    $"{weapon.BuddyIlluminationForCEC}; " +
                    $"{weapon.CargoType.Description}; " +
                    $"{weapon.CargoMass}; " +
                    $"{weapon.CargoVolume}; " +
                    $"{weapon.CargoCrew}; " +
                    $"{weapon.CargoParadropCapable}; " +
                    $"{weapon.Cost}; " +
                    $"{weapon.Deprecated}");
            }

            File.WriteAllText(AppDomain.CurrentDomain.BaseDirectory + $"output\\weapons.csv", sb.ToString());
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
            var entries2 = DataAircraft.DataEntries;
            // Sort by country two letter code, and then by service.
            var entries = entries2.Values.OfType<DataAircraft>().OrderBy(x => x.OperatorCountry.TwoLetterCode).ThenBy(x => x.OperatorService.Description).ThenBy(x => x.Name).ThenBy(x => x.YearCommissioned).ToList();

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
