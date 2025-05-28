using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cmo_db_viewer.Models
{
    public class DataFuel : IData, IDataTable
    {
        public string TableName { get; } = "DataFuel";

        public static Dictionary<int, IData> DataEntries { get; set; } = new Dictionary<int, IData>();

        public List<(Type, string)> Properties { get; } = new List<(Type, string)>()
        {
            (typeof(int), nameof(ID)),
            (typeof(EnumFuelType), nameof(Type)),
            (typeof(int), nameof(Capacity))
        };

        /// <summary>
        /// Represents the unique identifier for the data.
        /// </summary>
        public int ID { get; set; }

        public EnumFuelType Type { get; set; }

        public int Capacity { get; set; }
    }
}
