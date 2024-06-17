using System;
using System.Collections.Generic;

namespace cmo_db_parser.Models
{
    public class DataEnum : IData
    {
        public virtual string TableName { get; }

        public static List<IData> DataEntries { get; set; } = new List<IData>();

        public virtual List<(Type, string)> Properties { get; } = new List<(Type, string)>()
        {
            (typeof(int), nameof(ID)), // ID
            (typeof(string), nameof(Description)), // Description
        };

        /// <summary>
        /// Represents the unique identifier for the data.
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// Represents the name of the country.
        /// </summary>
        public string Description { get; set; }
    }
}
