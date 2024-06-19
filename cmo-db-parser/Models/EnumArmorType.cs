using System;
using System.Collections.Generic;

namespace cmo_db_parser.Models
{
    public class EnumArmorType : DataEnum
    {
        public new static List<IData> DataEntries { get; set; } = new List<IData>();

        public override string TableName { get; } = "EnumArmorType";
    }
}
