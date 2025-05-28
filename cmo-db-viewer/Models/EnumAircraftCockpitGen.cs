using System;
using System.Collections.Generic;

namespace cmo_db_viewer.Models
{
    public class EnumAircraftCockpitGen : DataEnum
    {
        public new static Dictionary<int,IData> DataEntries { get; set; } = new Dictionary<int,IData>();

        public override string TableName { get; } = "EnumAircraftCockpitGen";

        public override List<(Type, string)> Properties { get; } = new List<(Type, string)>()
        {
            (typeof(int), nameof(ID)), // ID
            (typeof(string), nameof(Description)), // Description
            (typeof(string), nameof(Example)), // Example
            (typeof(int), nameof(OODADetectionCycle)), // OODADetectionCycle
            (typeof(int), nameof(OODATargetingCycle)), // OODATargetingCycle
            (typeof(int), nameof(OODAEvasiveCycle)) // OODAEvasiveCycle
        };

        /// <summary>
        /// 
        /// </summary>
        public string Example { get; set; }

        public int OODADetectionCycle { get; set; }

        public int OODATargetingCycle { get; set; }

        public int OODAEvasiveCycle { get; set; }
    }
}
