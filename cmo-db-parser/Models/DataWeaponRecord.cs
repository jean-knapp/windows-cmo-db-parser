using System;
using System.Collections.Generic;

namespace cmo_db_parser.Models
{
    public class DataWeaponRecord : IData, IDataTable
    {
        public string TableName { get; } = "DataWeaponRecord";

        public static Dictionary<int, IData> DataEntries { get; set; } = new Dictionary<int, IData>();

        public List<(Type, string)> Properties { get; } = new List<(Type, string)>()
        {
            (typeof(int), nameof(ID)),
            (typeof(DataWeapon), nameof(Weapon)),
            (typeof(int), nameof(DefaultLoad))
        };

        /// <summary>
        /// Represents the unique identifier for the data.
        /// </summary>
        public int ID { get; set; }

        public DataWeapon Weapon { get; set; }

        public int DefaultLoad { get; set; }

        public int MaxLoad { get; set; }

        public int ROF { get; set; }

        public int Multiple { get; set; }

        public bool Deprecated { get; set; }
    }
}
