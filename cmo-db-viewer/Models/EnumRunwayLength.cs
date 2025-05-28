using System;
using System.Collections.Generic;

namespace cmo_db_viewer.Models
{
    public class EnumRunwayLength : DataEnum
    {
        public new static Dictionary<int,IData> DataEntries { get; set; } = new Dictionary<int,IData>();

        public override string TableName { get; } = "EnumRunwayLength";
    }
}
