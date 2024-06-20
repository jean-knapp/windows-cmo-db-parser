using System;
using System.Collections.Generic;

namespace cmo_db_parser.Models
{
    public class EnumErgonomics : DataEnum
    {
        public new static Dictionary<int,IData> DataEntries { get; set; } = new Dictionary<int,IData>();

        public override string TableName { get; } = "EnumErgonomics";

        public override List<(Type, string)> Properties { get; } = new List<(Type, string)>()
        {
            (typeof(int), nameof(ID)), // ID
            (typeof(string), nameof(Description)), // Description
            (typeof(int), nameof(OODADetectionModPercent)),
            (typeof(int), nameof(OODATargetingModPercent)),
            (typeof(int), nameof(OODAEvasiveModPercent))
        };


        public int OODADetectionModPercent { get; set; }

        public int OODATargetingModPercent { get; set; }

        public int OODAEvasiveModPercent { get; set; }
    }
}
