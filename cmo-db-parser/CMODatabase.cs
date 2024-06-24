using cmo_db_parser.Models;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace cmo_db_parser
{
    internal class CMODatabase
    {
        /// <summary>
        /// Represents the connection to the SQLite database
        /// </summary>
        static SQLiteConnection connection = null;

        /// <summary>
        /// Represents the list of tables in the database
        /// </summary>
        public static List<(string Name, Type DataType)> DataTables = new List<(string Name, Type DataType)>()
        {
            ("EnumOperatorCountry", typeof(EnumOperatorCountry)),
            ("EnumOperatorService", typeof(EnumOperatorService)),
            ("EnumAircraftType", typeof(EnumAircraftType)),
            ("EnumAircraftAutonomousControlLevel", typeof(EnumAircraftAutonomousControlLevel)),
            ("EnumAircraftCockpitGen", typeof(EnumAircraftCockpitGen)),
            ("EnumErgonomics", typeof(EnumErgonomics)),
            ("EnumAircraftPhysicalSize", typeof(EnumAircraftPhysicalSize)),
            ("EnumRunwayLength", typeof(EnumRunwayLength)),
            ("EnumArmorType", typeof(EnumArmorType)),
            ("EnumAircraftCockpitVisibility", typeof(EnumAircraftCockpitVisibility)),
            ("EnumAircraftCategory", typeof(EnumAircraftCategory)),
            ("EnumWeaponGeneration", typeof(EnumWeaponGeneration)),
            ("EnumWeaponType", typeof(EnumWeaponType)),
            ("DataAircraft", typeof(DataAircraft)),
            ("EnumWarheadExplosivesType", typeof(EnumWarheadExplosivesType)),
            ("EnumCargoType", typeof(EnumCargoType)),
            ("DataWarhead", typeof(DataWarhead)),
            ("DataWeapon", typeof(DataWeapon)),
            ("DataWeaponRecord", typeof(DataWeaponRecord)),
            ("DataLoadout", typeof(DataLoadout)),
            ("DataAircraftLoadouts", typeof(DataAircraftLoadouts)),
            ("DataLoadoutWeapons", typeof(DataLoadoutWeapons)),
            ("DataWeaponWarheads", typeof(DataWeaponWarheads))
        };

        /// <summary>
        /// Open the database file
        /// </summary>
        /// <param name="sqlFilePath"></param>
        /// <returns></returns> 
        private static bool OpenDatabase(string sqlFilePath)
        {
            if (!System.IO.File.Exists(sqlFilePath))
            {
                Console.WriteLine("The specified file does not exist.");

                ConsoleExtensions.Pause();
                return false;
            }

            string connectionString = $"Data Source={sqlFilePath};Version=3;";

            connection = new SQLiteConnection(connectionString);
            connection.Open();

            return true;
        }

        private static IData GetEntryById(int id, Type type)
        {
            var entriesList = GetEntriesList(type);

            if (entriesList.ContainsKey(id))
            {
                return entriesList[id];
            }

            return null;
        }

        private static Dictionary<int, IData> GetEntriesList(Type type)
        {
            var entriesType = type;
            dynamic entriesField = entriesType.GetProperty("DataEntries"); // Assuming there's a public field named "Entries"
            var entriesList = entriesField.GetValue(null) as Dictionary<int, IData>;

            return entriesList;
        }

        /// <summary>
        /// Read the tables in the database
        /// </summary>
        internal static void ReadTables(string sqlFilePath)
        {
            // Check if the database file exists. If it does, open it.
            if (!OpenDatabase(sqlFilePath))
                return;

            foreach (var table in DataTables)
            {
                Console.WriteLine($"Reading table {table.Name}");
                string query = $"SELECT * FROM {table.Name}";
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            if (table.DataType.GetInterface("IListItem") != null)
                            {
                                // Create a new instance of the IData implementation
                                IListItem dataInstance = (IListItem)Activator.CreateInstance(table.DataType);

                                // Loop through the properties list and set the values dynamically
                                for (int i = 0; i < dataInstance.Properties.Count; i++)
                                {
                                    var property = dataInstance.Properties[i];
                                    var propertyType = property.Item1;
                                    var propertyName = property.Item2;

                                    if (propertyName != null)
                                    {
                                        if (reader.IsDBNull(i))
                                            continue;

                                        // Use reflection to set the property value
                                        var propertyInfo = table.DataType.GetProperty(propertyName);

                                        if (propertyType == typeof(int))
                                        {
                                            int value = reader.GetInt32(i);
                                            propertyInfo.SetValue(dataInstance, value);
                                        }
                                        else if (propertyType == typeof(double))
                                        {
                                            double value = reader.GetDouble(i);
                                            propertyInfo.SetValue(dataInstance, value);
                                        }
                                        else if (propertyType == typeof(string))
                                        {
                                            string value = reader.GetString(i).Trim();
                                            propertyInfo.SetValue(dataInstance, value);
                                        }
                                        else if (propertyType == typeof(bool))
                                        {
                                            bool value = reader.GetBoolean(i);
                                            propertyInfo.SetValue(dataInstance, value);
                                        }
                                    }
                                }

                                dataInstance.AssignComponents();
                            }
                            else
                            {


                                // Create a new instance of the IData implementation
                                IData dataInstance = (IData)Activator.CreateInstance(table.DataType);

                                // Loop through the properties list and set the values dynamically
                                for (int i = 0; i < dataInstance.Properties.Count; i++)
                                {
                                    var property = dataInstance.Properties[i];
                                    var propertyType = property.Item1;
                                    var propertyName = property.Item2;

                                    if (propertyName != null)
                                    {
                                        if (reader.IsDBNull(i))
                                            continue;

                                        // Use reflection to set the property value
                                        var propertyInfo = table.DataType.GetProperty(propertyName);

                                        // Check if the property type is a class that inherits IData
                                        if (propertyType.GetInterface("IData") != null)
                                        {
                                            if (propertyType == typeof(EnumAircraftCockpitVisibility))
                                            {
                                                string value = reader.GetString(i).Trim();
                                                var entry = EnumAircraftCockpitVisibility.GetEntryById(value);
                                                if (entry == null)
                                                {

                                                }
                                                propertyInfo.SetValue(dataInstance, entry);
                                            }
                                            else
                                            {
                                                var entry = GetEntryById(reader.GetInt32(i), propertyType);

                                                if (entry == null && GetEntriesList(propertyType).Count == 0)
                                                {
                                                    Console.WriteLine("Could not read data from table '{0}' for the entry ID '{1}.{2}'. Make sure '{3}' is loaded before table '{4}'",
                                                        propertyName, table.Name, dataInstance.ID, propertyName, table.Name);
                                                    ConsoleExtensions.Pause();
                                                    return;
                                                }

                                                propertyInfo.SetValue(dataInstance, entry);
                                            }
                                        }
                                        else if (propertyType == typeof(int))
                                        {
                                            int value = reader.GetInt32(i);
                                            propertyInfo.SetValue(dataInstance, value);
                                        }
                                        else if (propertyType == typeof(double))
                                        {
                                            double value = reader.GetDouble(i);
                                            propertyInfo.SetValue(dataInstance, value);
                                        }
                                        else if (propertyType == typeof(string))
                                        {
                                            string value = reader.GetString(i);
                                            propertyInfo.SetValue(dataInstance, value);
                                        }
                                        else if (propertyType == typeof(bool))
                                        {
                                            bool value = reader.GetBoolean(i);
                                            propertyInfo.SetValue(dataInstance, value);
                                        }
                                    }
                                }

                                // Add the datainstance to the respective Entries list
                                var entriesType = table.DataType;
                                dynamic entriesField = entriesType.GetProperty("DataEntries"); // Assuming there's a public field named "Entries"
                                var entriesList = entriesField.GetValue(null) as Dictionary<int, IData>;

                                entriesList[dataInstance.ID] = dataInstance;
                            }
                        }
                    }
                }
            }

            CloseDatabase();
        }

        /// <summary>
        /// Close the database file
        /// </summary>
        private static void CloseDatabase()
        {
            connection.Close();
        }
    }
}
