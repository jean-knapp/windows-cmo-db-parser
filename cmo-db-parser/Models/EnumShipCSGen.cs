using System;
using System.Collections.Generic;

namespace cmo_db_parser.Models
{
    public class EnumShipCSGen : DataEnum
    {
        public new static Dictionary<int,IData> DataEntries { get; set; } = new Dictionary<int,IData>();

        public override string TableName { get; } = "EnumShipCSGen";

        public override List<(Type, string)> Properties { get; } = new List<(Type, string)>()
        {
            (typeof(int), nameof(ID)), // ID
            (typeof(string), nameof(Description)), // Description
            (typeof(string), nameof(Example)),
            (typeof(int), nameof(YearStart)), // YearStart
            (typeof(int), nameof(YearEnd)), // YearEnd
            (typeof(string), nameof(Architecture)),
            (typeof(int), nameof(OODADetectionCycle)),
            (typeof(int), nameof(OODATargetingCycle)),
            (typeof(int), nameof(OODAEvasiveCycle)),
            (typeof(int), nameof(TrackCap)),
        };

        public string Example { get; set; }

        public int YearStart { get; set; }

        public int YearEnd { get; set;}

        public string Architecture { get; set; }

        public int OODADetectionCycle { get; set; }

        public int OODATargetingCycle { get; set; }

        public int OODAEvasiveCycle { get; set; }

        public int TrackCap { get; set; }
    }
}
