using System;
using System.Collections.Generic;

namespace cmo_db_viewer.Models
{
    public class EnumAircraftAutonomousControlLevel : DataEnum
    {
        public new static Dictionary<int,IData> DataEntries { get; set; } = new Dictionary<int,IData>();

        public override string TableName { get; } = "EnumAircraftAutonomousControlLevel";

        public override List<(Type, string)> Properties { get; } = new List<(Type, string)>()
        {
            (typeof(int), nameof(ID)), // ID
            (typeof(string), nameof(Description)), // Description
            (typeof(string), nameof(OnSignalLoss)), // OnSignalLoss
        };

        /// <summary>
        /// What the aircraft should do when it loses signal.
        /// </summary>
        public string OnSignalLoss { get; set; }
    }
}
