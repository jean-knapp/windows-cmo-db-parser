using System.Collections.Generic;
using System;

namespace cmo_db_viewer.Models
{
    internal class DataShipMounts : IListItem, IDataTable
    {
        /// <summary>
        /// Represents the name of the table in the database.
        /// </summary>
        public string TableName { get; } = "DataShipMounts";

        public List<(Type, string)> Properties { get; } = new List<(Type, string)>()
        {
            (typeof(int), nameof(ID)),
            (typeof(int), nameof(ComponentID)),
            (typeof(int), nameof(SB1)),
            (typeof(int), nameof(SB2)),
            (typeof(int), nameof(SMF1)),
            (typeof(int), nameof(SMF2)),
            (typeof(int), nameof(SMA1)),
            (typeof(int), nameof(SMA2)),
            (typeof(int), nameof(SS1)),
            (typeof(int), nameof(SS2)),
            (typeof(int), nameof(PB1)),
            (typeof(int), nameof(PB2)),
            (typeof(int), nameof(PMF1)),
            (typeof(int), nameof(PMF2)),
            (typeof(int), nameof(PMA1)),
            (typeof(int), nameof(PMA2)),
            (typeof(int), nameof(PS1)),
            (typeof(int), nameof(PS2)),
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
            DataShip ship = null;
            DataMount mount = null;

            if (DataShip.DataEntries.ContainsKey(ID))
            {
                ship = DataShip.DataEntries[ID] as DataShip;
            }

            if (DataMount.DataEntries.ContainsKey(ComponentID))
            {
                mount = DataMount.DataEntries[ComponentID] as DataMount;
            }

            if (ship != null && mount != null)
            {
                ship.Mounts.Add(mount);
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
