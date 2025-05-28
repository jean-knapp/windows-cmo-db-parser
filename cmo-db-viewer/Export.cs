using cmo_db_viewer.Models;
using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;

namespace cmo_db_viewer
{
    internal class Export
    {
        internal static void ExportCSVs()
        {
            //TestExport();
            ExportCountries();
            //ExportExplosiveTypes();
            //ExportWeapons();

            // Query the user to type a string of two characters matching the TwoLetterCode of the ISO.
            Console.WriteLine("Insert the two letter country code defined in the ISO 3166-1.");
            string twoLetterCode = Console.ReadLine().ToUpper();
            Console.Clear();

            if (!Directory.Exists(AppDomain.CurrentDomain.BaseDirectory + $"output\\{twoLetterCode}"))
            {
                Directory.CreateDirectory(AppDomain.CurrentDomain.BaseDirectory + $"output\\{twoLetterCode}");
            }

            ExportAircraftLoadouts(twoLetterCode);
            ExportAircrafts(twoLetterCode);
            ExportShips(twoLetterCode);
            ExportShipMounts(twoLetterCode);
        }

        public static void ExportCountries()
        {
            // Export the two letter, three letter, name, latitude, longitude and continent.

            StringBuilder sb = new StringBuilder();

            sb.AppendLine("using System.Collections.Generic;\r\n\r\nnamespace cmo_db_viewer\r\n{\r\n    internal class ISO3166Countries\r\n    {\r\n        public static List<(string TwoLetterCode, string ThreeLetterCode, string CountryName, string OSMCountryName, double Latitude, double Longitude, string Continent)> Entries = new List<(string TwoLetterCode, string ThreeLetterCode, string CountryName, double Latitude, double Longitude, string Continent)>\r\n        {");

            foreach(var dataEntry in EnumOperatorCountry.DataEntries)
            {
                EnumOperatorCountry country = dataEntry.Value as EnumOperatorCountry;

                // ("AR", "ARG", "Argentina", -34.6037, -58.3816, "South America"),
                sb.AppendLine($"(" +
                    $"\"{country.TwoLetterCode}\", " +
                    $"\"{country.ThreeLetterCode}\", " +
                    $"\"{country.Description}\", " +
                    $"\"{country.OSMCountryName}\", " +
                    $"{(country.Latitude != 0 ? country.Latitude.ToString() : "")}, " +
                    $"{(country.Longitude != 0 ? country.Longitude.ToString() : "")}, " +
                    $"\"{country.Continent}\"" +
                    $"),"
                    );
            }

            sb.AppendLine("        };\r\n\r\n       \r\n    }\r\n}");

            File.WriteAllText(AppDomain.CurrentDomain.BaseDirectory + $"output\\ISO3166Countries.cs", sb.ToString());
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
            foreach (var item in DataAircraft.DataEntries.Values)
            {
                if ((item as DataAircraft).Name == "A-29B Super Tucano [EMB-314]")
                {
                    dataAircraft = (DataAircraft)item;
                    break;
                }
            }

            foreach (DataLoadout dataLoadout in dataAircraft.Loadouts)
            {
                Console.WriteLine($"{dataLoadout.Name} ({dataLoadout.ID})");

                foreach (DataWeaponRecord dataWeapon in dataLoadout.Weapons)
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
                "Deprecated; " +
                "Description");

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
                    $"{aircraft.AutonomousControlLevel?.Description ?? ""}; " +
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
                    $"{aircraft.Deprecated}; " +
                    $"{aircraft.Description?.Replace("\n", "\\n").Replace("\r", "\\r") ?? ""}");
            }

            File.WriteAllText(AppDomain.CurrentDomain.BaseDirectory + $"output\\{twoLetterCode}\\aircrafts.csv", sb.ToString());
        }

        private static void ExportAircraftLoadouts(string twoLetterCode)
        {
            // Let's export a table with the aircraft name, country, service and comissioned year.
            // We will repeat the rows for as many loadouts as it have. So let's add another column for the loadout data.
            // And then we will also repeat the lines for as many weapons as the loadout have.

            StringBuilder sb = new StringBuilder();

            // Add a header to the csv
            sb.AppendLine(
                $"Aircraft;" +
                $"Country;" +
                $"Service;" +
                $"YearCommissioned;" +
                $"LoadoutID;" +
                $"LoadoutName;" +
                $"CombatRadius;" +
                $"Role;" +
                $"PayloadWeightDragModifier;" +
                $"ReadyTime;" +
                $"WeaponName;" +
                $"DefaultLoad;" +
                $"MaxLoad"

                );

            foreach (System.Collections.Generic.KeyValuePair<int, IData> aircraft in DataAircraft.DataEntries)
            {
                DataAircraft dataAircraft = aircraft.Value as DataAircraft;

                if (dataAircraft.OperatorCountry.TwoLetterCode != twoLetterCode)
                {
                    continue;
                }

                foreach (DataLoadout dataLoadout in dataAircraft.Loadouts)
                {
  
                    foreach(DataWeaponRecord dataWeaponRecord in dataLoadout.Weapons)
                    {
                        DataWeapon dataWeapon = dataWeaponRecord.Weapon;

                        sb.AppendLine(
                            // Aircraft
                            $"{dataAircraft.Name};" +
                            $"{dataAircraft.OperatorCountry.TwoLetterCode};" +
                            $"{dataAircraft.OperatorService.Description};" +
                            $"{dataAircraft.YearCommissioned};" +

                            // Loadout
                            $"{dataLoadout.ID};" +
                            $"{dataLoadout.Name};" +
                            $"{dataLoadout.DefaultCombatRadius};" +
                            $"{dataLoadout.LoadoutRole.Description};" +
                            $"{dataLoadout.PayloadWeightDragModifier.ToString().Replace(",", ".")};" +
                            $"{dataLoadout.ReadyTime};" +

                            // Weapon
                            $"{dataWeapon.Name};" +
                            $"{dataWeaponRecord.DefaultLoad};" +
                            $"{dataWeaponRecord.MaxLoad}"
                            );
                    }
                }
            }

            File.WriteAllText(AppDomain.CurrentDomain.BaseDirectory + $"output\\{twoLetterCode}\\loadouts.csv", sb.ToString());
        }

        internal static void CopyImages(string imagesFolder)
        {
            string[] files = Directory.GetFiles(imagesFolder, "*.jpg");
            string aircraftDir = AppDomain.CurrentDomain.BaseDirectory + $"output\\images\\aircrafts\\";
            Directory.CreateDirectory(aircraftDir);

            foreach (string file in files)
            {
                string filename = Path.GetFileNameWithoutExtension(file);

                if (filename.ToLower().StartsWith("aircraft_") && int.TryParse(filename.Substring(9), out int id) && DataAircraft.DataEntries.ContainsKey(id))
                {
                    DataAircraft dataAircraft = DataAircraft.DataEntries[id] as DataAircraft;

                    string imagekey = dataAircraft.Name;
                    // Remove invalid characters from imagekey, as it will be the file name
                    imagekey = string.Concat(imagekey.Split(Path.GetInvalidFileNameChars()));


                    File.Copy(file, aircraftDir + imagekey + ".jpg", true);
                }
            }
        }

        private static void ExportShips(string twoLetterCode)
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
                "Beam; " +
                "Draft; " +
                "Height; " +
                "DisplacementEmpty; " +
                "DisplacementStandard; " +
                "Crew; " +
                "ArmorBelt; " +
                "ArmorBulkheads; " +
                "ArmorDeck; " +
                "ArmorBridge; " +
                "ArmorCIC; " +
                "ArmorEngineering; " +
                "ArmorRudder; " +
                "DamagePoints; " +
                "FOCSeaState; " +
                "MaxSeaState; " +
                "RepairCapacity; " +
                "TroopCapacity; " +
                "CargoCapacity; " +
                "MissileDefense; " +
                "CSGen; " +
                "Ergonomics; " +
                "OODADetectionCycle; " +
                "OODATargetingCycle; " +
                "OODAEvasiveCycle; " +
                "PhysicalSizeCode; " +
                "Hypothetical; " +
                "CargoType; " +
                "CargoMass; " +
                "CargoArea; " +
                "CargoCrew; " +
                "CargoVolume; " +
                "Cost; " +
                "Deprecated");

            // Print the ship names and countries
            var entries2 = DataShip.DataEntries;
            // Sort by country two letter code, and then by service.
            var entries = entries2.Values.OfType<DataShip>().OrderBy(x => x.OperatorCountry.TwoLetterCode).ThenBy(x => x.OperatorService.Description).ThenBy(x => x.Name).ThenBy(x => x.YearCommissioned).ToList();

            foreach (DataShip ship in entries)
            {
                if (ship.OperatorCountry.TwoLetterCode != twoLetterCode)
                {
                    continue;
                }

                sb.AppendLine(
                    $"{ship.ID}; " +
                    $"{ship.Category.Description}; " +
                    $"{ship.Type.Description}; " +
                    $"{ship.Name}; " +
                    $"{ship.Comments}; " +
                    $"{ship.OperatorCountry.TwoLetterCode}; " +
                    $"{ship.OperatorService.Description}; " +
                    $"{ship.YearCommissioned}; " +
                    $"{ship.YearDecommissioned}; " +
                    $"{ship.Length}; " +
                    $"{ship.Beam}; " +
                    $"{ship.Draft}; " +
                    $"{ship.Height}; " +
                    $"{ship.DisplacementEmpty}; " +
                    $"{ship.DisplacementStandard}; " +
                    $"{ship.Crew}; " +
                    $"{ship.ArmorBelt.Description}; " +
                    $"{ship.ArmorBulkheads.Description}; " +
                    $"{ship.ArmorDeck.Description}; " +
                    $"{ship.ArmorBridge.Description}; " +
                    $"{ship.ArmorCIC.Description}; " +
                    $"{ship.ArmorEngineering.Description}; " +
                    $"{ship.ArmorRudder.Description}; " +
                    $"{ship.DamagePoints}; " +
                    $"{ship.FOCSeaState}; " +
                    $"{ship.MaxSeaState}; " +
                    $"{ship.RepairCapacity}; " +
                    $"{ship.TroopCapacity}; " +
                    $"{ship.CargoCapacity}; " +
                    $"{ship.MissileDefense}; " +
                    $"{ship.CSGen.Description}; " +
                    $"{ship.Ergonomics.Description}; " +
                    $"{ship.OODADetectionCycle}; " +
                    $"{ship.OODATargetingCycle}; " +
                    $"{ship.OODAEvasiveCycle}; " +
                    $"{ship.PhysicalSizeCode.Description}; " +
                    $"{ship.Hypothetical}; " +
                    $"{ship.CargoType.Description}; " +
                    $"{ship.CargoMass}; " +
                    $"{ship.CargoArea}; " +
                    $"{ship.CargoCrew}; " +
                    $"{ship.CargoVolume}; " +
                    $"{ship.Cost}; " +
                    $"{ship.Deprecated}");
            }

            File.WriteAllText(AppDomain.CurrentDomain.BaseDirectory + $"output\\{twoLetterCode}\\ships.csv", sb.ToString());
        }

        private static void ExportShipMounts(string twoLetterCode)
        {
            var sb = new StringBuilder();

            sb.AppendLine(
                $"Ship;" +
                $"Country;" +
                $"Service;" +
                $"YearCommissioned;" +

                $"MountID;" +
                $"MountName;" +
                $"ROF;" +
                $"Capacity;" +
                $"MagazineROF;" +
                $"MagazineCapacity;" +
                $"Availability;" +
                $"Autonomous;" +
                $"LocalControl;" +
                $"Hypothetical;" +
                $"CargoType;" +
                $"CargoMass;" +
                $"CargoArea;" +
                $"CargoCrew;" +
                $"CargoParadropCapable;" + 

                $"WeaponName;" +
                $"DefaultLoad;" +
                $"MaxLoad"
                );

            foreach (System.Collections.Generic.KeyValuePair<int, IData> ship in DataShip.DataEntries)
            {
                DataShip dataShip = ship.Value as DataShip;

                if (dataShip.OperatorCountry.TwoLetterCode != twoLetterCode)
                {
                    continue;
                }

                foreach (DataMount dataMount in dataShip.Mounts)
                {

                    foreach (DataWeaponRecord dataWeaponRecord in dataMount.Weapons)
                    {
                        DataWeapon dataWeapon = dataWeaponRecord.Weapon;

                        sb.AppendLine(
                            // Ship
                            $"{dataShip.Name};" +
                            $"{dataShip.OperatorCountry.TwoLetterCode};" +
                            $"{dataShip.OperatorService.Description};" +
                            $"{dataShip.YearCommissioned};" +

                            // Loadout
                            $"{dataMount.ID};" +
                            $"{dataMount.Name};" +
                            $"{dataMount.ROF};" +                              // ROF
                            $"{dataMount.Capacity};" +                         // Capacity
                            $"{dataMount.MagazineROF};" +                      // MagazineROF
                            $"{dataMount.MagazineCapacity};" +                 // MagazineCapacity
                            $"{dataMount.Availability};" +                     // Availability
                            $"{dataMount.Autonomous};" +                       // Autonomous
                            $"{dataMount.LocalControl};" +                     // LocalControl
                            $"{dataMount.Hypothetical};" +                     // Hypothetical
                            $"{dataMount.Cargo_Type};" +                       // CargoType
                            $"{dataMount.Cargo_Mass};" +                       // CargoMass
                            $"{dataMount.Cargo_Area};" +                       // CargoArea
                            $"{dataMount.Cargo_Crew};" +                       // CargoCrew
                            $"{dataMount.Cargo_ParadropCapable};" +            // CargoParadropCapable

                            // Weapon
                            $"{dataWeapon.Name};" +
                            $"{dataWeaponRecord.DefaultLoad};" +
                            $"{dataWeaponRecord.MaxLoad}"
                            );
                    }
                }
            }

            File.WriteAllText(AppDomain.CurrentDomain.BaseDirectory + $"output\\{twoLetterCode}\\ship_mounts.csv", sb.ToString());
        }

    }
}
