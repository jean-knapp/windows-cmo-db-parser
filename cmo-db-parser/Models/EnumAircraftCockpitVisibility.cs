using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Security.Policy;

namespace cmo_db_parser.Models
{
    public class EnumAircraftCockpitVisibility : IData
    {
        public string TableName { get; } = "EnumAircraftCockpitVisibility";

        public static Dictionary<int,IData> DataEntries { get; set; } = new Dictionary<int,IData>();

        public virtual List<(Type, string)> Properties { get; } = new List<(Type, string)>()
        {
            (typeof(string), nameof(CMO_ID)), // ID
            (typeof(string), nameof(Description)), // Description
        };

        /// <summary>
        /// Represents the unique identifier for the data.
        /// </summary>
        public int ID { get; set; }

        public string CMO_ID { get; set; }

        /// <summary>
        /// Represents the name of the country.
        /// </summary>
        public string Description { get; set; }
        

        internal static EnumAircraftCockpitVisibility GetEntryById(string v)
        {
            foreach(var entry in DataEntries.Values)
            {
                if ((entry as EnumAircraftCockpitVisibility).CMO_ID == v)
                {
                    return entry as EnumAircraftCockpitVisibility;
                }
            }

            return null;
        }
    }
}