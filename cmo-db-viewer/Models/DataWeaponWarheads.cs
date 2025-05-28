using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cmo_db_viewer.Models
{
    internal class DataWeaponWarheads : IListItem, IDataTable
    {
        /// <summary>
        /// Represents the name of the table in the database.
        /// </summary>
        public string TableName { get; } = "DataWeaponWarheads";

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
            DataWeapon weapon = null;
            DataWarhead warhead = null;

            if (DataWeapon.DataEntries.ContainsKey(ID))
            {
                weapon = DataWeapon.DataEntries[ID] as DataWeapon;
            }

            if (DataWarhead.DataEntries.ContainsKey(ComponentID))
            {
                warhead = DataWarhead.DataEntries[ComponentID] as DataWarhead;
            }

            if (weapon != null && warhead != null)
            {
                weapon.Warhead = warhead;
            }
        }
    }
}
