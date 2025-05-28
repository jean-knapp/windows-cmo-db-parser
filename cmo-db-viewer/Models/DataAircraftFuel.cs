using System.Collections.Generic;
using System;
using System.Security.Policy;

namespace cmo_db_viewer.Models
{
    internal class DataAircraftFuel : IListItem, IDataTable
    {
        /// <summary>
        /// Represents the name of the table in the database.
        /// </summary>
        public string TableName { get; } = "DataAircraftFuel";

        public List<(Type, string)> Properties { get; } = new List<(Type, string)>()
        {
            (typeof(int), nameof(ID)),
            (typeof(int), nameof(ComponentNumber)),
            (typeof(int), nameof(ComponentID)),
        };

        /// <summary>
        /// Represents the unique identifier for the data.
        /// </summary>
        public int ID { get; set; }
        public int ComponentNumber { get; set; }

        /// <summary>
        /// Represents the unique identifier for the data.
        /// </summary>
        public int ComponentID { get; set; }

        public void AssignComponents()
        {
            DataAircraft aircraft = null;
            DataFuel loadout = null;

            if (DataAircraft.DataEntries.ContainsKey(ID))
            {
                aircraft = DataAircraft.DataEntries[ID] as DataAircraft;
            }

            if (DataFuel.DataEntries.ContainsKey(ComponentID))
            {
                loadout = DataFuel.DataEntries[ComponentID] as DataFuel;
            }

            if (aircraft != null && loadout != null)
            {
                aircraft.Fuel.Add(loadout);
            }
        }
    }
}
