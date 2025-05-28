using System.Collections.Generic;
using System;

namespace cmo_db_viewer.Models
{
    internal class DataShipAircraftFacilities : IListItem, IDataTable
    {
        /// <summary>
        /// Represents the name of the table in the database.
        /// </summary>
        public string TableName { get; } = "DataShipAircraftFacilities";

        public List<(Type, string)> Properties { get; } = new List<(Type, string)>()
        {
            (typeof(int), nameof(ID)),
            (typeof(int), nameof(ComponentNumber)),
            (typeof(int), nameof(ComponentID))
        };

        /// <summary>
        /// Represents the unique identifier for the data.
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// Represents the unique identifier for the data.
        /// </summary>
        public int ComponentID { get; set; }

        /// <summary>
        /// The number of the component.
        /// </summary>
        public int ComponentNumber { get; set; }

        public void AssignComponents()
        {
            DataShip ship = null;
            DataAircraftFacility mount = null;

            if (DataShip.DataEntries.ContainsKey(ID))
            {
                ship = DataShip.DataEntries[ID] as DataShip;
            }

            if (DataAircraftFacility.DataEntries.ContainsKey(ComponentID))
            {
                mount = DataAircraftFacility.DataEntries[ComponentID] as DataAircraftFacility;
            }

            if (ship != null && mount != null)
            {
                ship.AircraftFacilities.Add(mount);
            }
        }

        public int SB1 { get; set; }
        public int SB2 { get; set; }
        public int SMF1 { get; set; }
        public int SMF2 { get; set; }
        public int SMA1 { get; set; }
        public int SMA2 { get; set; }
        public int SS1 { get; set; }
        public int SS2 { get; set; }
        public int PB1 { get; set; }
        public int PB2 { get; set; }
        public int PMF1 { get; set; }
        public int PMF2 { get; set; }
        public int PMA1 { get; set; }
        public int PMA2 { get; set; }
        public int PS1 { get; set; }
        public int PS2 { get; set; }
    }
}
