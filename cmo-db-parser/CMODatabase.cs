using cmo_db_parser.Models;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
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
            ("DataAircraft", typeof(Aircraft)),
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
            return entriesList.FirstOrDefault(x => x.ID == id);
        }

        private static List<IData> GetEntriesList(Type type)
        {
            var entriesType = type;
            dynamic entriesField = entriesType.GetProperty("DataEntries"); // Assuming there's a public field named "Entries"
            var entriesList = entriesField.GetValue(null) as List<IData>;

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
                // Create an instance of the IData implementation using reflection
                IData dataInstance = (IData)Activator.CreateInstance(table.DataType);

                string query = $"SELECT * FROM {dataInstance.TableName}";
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Create a new instance of the IData implementation
                            dataInstance = (IData)Activator.CreateInstance(table.DataType);

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
                                        var entry = GetEntryById(reader.GetInt32(i), propertyType);

                                        if (entry == null && GetEntriesList(propertyType).Count == 0)
                                        {
                                            Console.WriteLine("Could not read data from table '{0}' for the entry ID '{1}.{2}'. Make sure '{3}' is loaded before table '{4}'",
                                                propertyName, dataInstance.TableName, dataInstance.ID, propertyName, dataInstance.TableName);
                                            ConsoleExtensions.Pause();
                                            return;
                                        }

                                        propertyInfo.SetValue(dataInstance, entry);

                                    }
                                    else if (propertyType == typeof(int))
                                    {
                                        propertyInfo.SetValue(dataInstance, reader.GetInt32(i));
                                    }
                                    else if (propertyType == typeof(double))
                                    {
                                        propertyInfo.SetValue(dataInstance, reader.GetDouble(i));
                                    }
                                    else if (propertyType == typeof(string))
                                    {
                                        propertyInfo.SetValue(dataInstance, reader.GetString(i));
                                    }
                                    else if (propertyType == typeof(bool))
                                    {
                                        propertyInfo.SetValue(dataInstance, reader.GetBoolean(i));
                                    }
                                }
                            }

                            /*
                             *     public class Aircraft : IData
                            {
                                public string TableName { get; } = "DataAircraft";

                                public static List<Aircraft> Entries { get; set; } = new List<Aircraft>();
                            */

                            // Add the datainstance to the respective Entries list
                            var entriesType = table.DataType;
                            dynamic entriesField = entriesType.GetProperty("DataEntries"); // Assuming there's a public field named "Entries"
                            var entriesList = entriesField.GetValue(null) as List<IData>;

                            entriesList.Add(dataInstance);
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
