using System.Collections.Generic;
using System.Xml.Linq;
using System;

namespace cmo_db_parser.Models
{
    internal class DataAircraftLoadouts : IListItem, IDataTable
    {
        /// <summary>
        /// Represents the name of the table in the database.
        /// </summary>
        public string TableName { get; }

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

            // Find the aircraft with the ID equal to ID.
            foreach(IData data in DataAircraft.DataEntries)
            {
                if (data.ID ==  ID)
                {
                    aircraft = (DataAircraft)data;
                    break;
                }
            }

            // Find the loadout with the ID equal to ID.
            foreach(IData data in DataLoadout.DataEntries)
            {
                if (data.ID == ComponentID)
                {
                    loadout = (DataLoadout)data;
                    break;
                }
            }

            if (aircraft != null && aircraft.Name == "A-29A Super Tucano [EMB-314]")
            {

            }
        }
    }
}
