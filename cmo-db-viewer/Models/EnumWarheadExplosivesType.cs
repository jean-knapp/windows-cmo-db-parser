using System;
using System.Collections.Generic;

namespace cmo_db_viewer.Models
{
    public class EnumWarheadExplosivesType : DataEnum
    {
        public new static Dictionary<int, IData> DataEntries { get; set; } = new Dictionary<int, IData>();

        public override string TableName { get; } = "EnumWarheadExplosivesType";

        public override List<(Type, string)> Properties { get; } = new List<(Type, string)>()
        {
            (typeof(int), nameof(ID)), // ID
            (typeof(string), nameof(Description)), // Description
            (typeof(double), nameof(TNTEquivalent)),
            (typeof(string), nameof(Comment))
        };

        public double TNTEquivalent { get; set; }

        public string Comment { get; set; } = "";
    
    }
}
