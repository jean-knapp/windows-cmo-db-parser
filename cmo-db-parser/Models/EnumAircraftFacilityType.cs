﻿using System;
using System.Collections.Generic;

namespace cmo_db_parser.Models
{
    public class EnumAircraftFacilityType : DataEnum
    {
        public new static Dictionary<int, IData> DataEntries { get; set; } = new Dictionary<int, IData>();

        public override string TableName { get; } = "EnumAircraftFacilityType";
    }
}
