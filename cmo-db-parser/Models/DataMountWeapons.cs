using System.Collections.Generic;
using System;

namespace cmo_db_parser.Models
{
    internal class DataMountWeapons : IListItem, IDataTable
    {
        /// <summary>
        /// Represents the name of the table in the database.
        /// </summary>
        public string TableName { get; } = "DataMountWeapons";

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

        public int ComponentNumber { get; set; }

        /// <summary>
        /// Represents the unique identifier for the data.
        /// </summary>
        public int ComponentID { get; set; }

        public void AssignComponents()
        {
            DataMount loadout = null;
            DataWeaponRecord weapon = null;

            if (DataMount.DataEntries.ContainsKey(ID))
            {
                loadout = DataMount.DataEntries[ID] as DataMount;
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
