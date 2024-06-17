using System;
using System.Collections.Generic;

namespace cmo_db_parser.Models
{
    public class EnumOperatorCountry : DataEnum
    {
        public new static List<IData> DataEntries { get; set; } = new List<IData>();

        public override string TableName { get; } = "EnumOperatorCountry";

        public override List<(Type, string)> Properties { get; } = new List<(Type, string)>()
        {
            (typeof(int), nameof(ID)), // ID
            (typeof(string), nameof(Description)), // Description
            (typeof(int), nameof(YearStart)), // YearStart
            (typeof(int), nameof(YearEnd)) // YearEnd
        };

        /// <summary>
        /// Represents the year the country was founded.
        /// </summary>
        public int YearStart { get; set; }

        /// <summary>
        /// Represents the year the country was dissolved.
        /// </summary>
        public int YearEnd { get; set; }
    }
}
