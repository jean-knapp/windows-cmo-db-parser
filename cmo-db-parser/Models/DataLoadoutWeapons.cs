using System.Collections.Generic;
using System.Xml.Linq;
using System;
using System.Runtime.InteropServices;
using System.ComponentModel;

namespace cmo_db_parser.Models
{
    internal class DataLoadoutWeapons : IListItem, IDataTable
    {
        /// <summary>
        /// Represents the name of the table in the database.
        /// </summary>
        public string TableName { get; } = "DataLoadoutWeapons";

        public List<(Type, string)> Properties { get; } = new List<(Type, string)>()
        {
            (typeof(int), nameof(ID)),
            (typeof(int), nameof(ComponentNumber)),
            (typeof(int), nameof(ComponentID)),
            (typeof(bool), nameof(Optional)),
            (typeof(bool), nameof(Internal))
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

        public bool Optional { get; set; }

        public bool Internal { get; set; }

        public void AssignComponents()
        {
            DataLoadout loadout = null;
            DataWeaponRecord weapon = null;

            if (DataLoadout.DataEntries.ContainsKey(ID))
            {
                loadout = DataLoadout.DataEntries[ID] as DataLoadout;
            }

            if (DataWeaponRecord.DataEntries.ContainsKey(ComponentID))
            {
                weapon = DataWeaponRecord.DataEntries[ComponentID] as DataWeaponRecord;
            }

            if (loadout != null && weapon != null)
            {
                loadout.Weapons.Add(weapon);
            }
        }
    }
}
