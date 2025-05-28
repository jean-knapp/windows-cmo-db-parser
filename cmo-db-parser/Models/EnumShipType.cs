using System;
using System.Collections.Generic;

namespace cmo_db_parser.Models
{
    public class EnumShipType : DataEnum
    {
        public new static Dictionary<int,IData> DataEntries { get; set; } = new Dictionary<int,IData>();

        public override string TableName { get; } = "EnumShipType";

        public override List<(Type, string)> Properties { get; } = new List<(Type, string)>()
        {
            (typeof(int), nameof(ID)), // ID
            (typeof(string), nameof(Description)), // Description
            (typeof(int), nameof(YearStart)), // YearStart
            (typeof(int), nameof(YearEnd)) // YearEnd
        };

        public int YearStart { get; set; }

        public int YearEnd { get; set;}
    }
}
