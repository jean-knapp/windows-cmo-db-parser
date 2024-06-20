using System.Collections.Generic;
using System;

namespace cmo_db_parser.Models
{
    internal class DataAircraftLoadouts : IListItem, IDataTable
    {
        /// <summary>
        /// Represents the name of the table in the database.
        /// </summary>
        public string TableName { get; } = "DataAircraftLoadouts";

        public List<(Type, string)> Properties { get; } = new List<(Type, string)>()
        {
            (typeof(int), nameof(ID)),
            (typeof(int), nameof(ComponentID)),
        };

        /// <summary>
        /// Represents the unique identifier for the data.
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// Represents the unique identifier for the data.
        /// </summary>
        public int ComponentID { get; set; }

        public void AssignComponents()
        {
            DataAircraft aircraft = null;
            DataLoadout loadout = null;

            if (DataAircraft.DataEntries.ContainsKey(ID))
            {
                aircraft = DataAircraft.DataEntries[ID] as DataAircraft;
            }

            if (DataLoadout.DataEntries.ContainsKey(ComponentID))
            {
                loadout = DataLoadout.DataEntries[ComponentID] as DataLoadout;
            }

            if (aircraft != null && loadout != null)
            {
                    aircraft.Loadouts.Add(loadout);
            }
        }
    }
}
