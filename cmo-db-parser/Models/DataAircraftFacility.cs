using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace cmo_db_parser.Models
{
    public class DataAircraftFacility : IData, IDataTable
    {
        public string TableName { get; } = "DataAircraftFacility";

        public static Dictionary<int, IData> DataEntries { get; set; } = new Dictionary<int, IData>();

        public List<(Type, string)> Properties { get; } = new List<(Type, string)>()
        {
            (typeof(int), nameof(ID)), // ID
            (typeof(EnumAircraftFacilityType), nameof(Type)),
            (typeof(EnumAircraftPhysicalSize), nameof(PhysicalSize)),
            (typeof(int), nameof(Capacity)),
            (typeof(EnumRunwayLength), nameof(RunwayLength))
        };

        /// <summary>
        /// Represents the unique identifier for the data.
        /// </summary>
        public int ID { get; set; }

        public EnumAircraftFacilityType Type { get; set; }

        public EnumAircraftPhysicalSize PhysicalSize { get; set; }

        public int Capacity { get; set; }

        public EnumRunwayLength RunwayLength { get; set; }
    }
}
