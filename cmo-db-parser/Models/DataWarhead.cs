using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cmo_db_parser.Models
{
    public class DataWarhead : IData, IDataTable
{
        public string TableName { get; } = "DataWarhead";

        public static Dictionary<int, IData> DataEntries { get; set; } = new Dictionary<int, IData>();

        public List<(Type, string)> Properties { get; } = new List<(Type, string)>()
        {
            (typeof(int), nameof(ID)),
            (typeof(string), nameof(Name)),
            (typeof(string), nameof(Comments)),
            (typeof(int), nameof(Type)),
            (typeof(double), nameof(DamagePoints)),
            (typeof(int), nameof(ProjectileCaliber)),
            (typeof(EnumWarheadExplosivesType), nameof(ExplosiveType)),
            (typeof(double), nameof(ExplosiveWeight)),
            (typeof(int), nameof(NumberOfWarheads)),
            (typeof(int), nameof(ClusterBombDispersionAreaLength)),
            (typeof(int), nameof(ClusterBombDispersionAreaWidth)),
            (typeof(bool), nameof(Hypothetical)),
            (typeof(bool), nameof(Deprecated)),
        };

        /// <summary>
        /// Represents the unique identifier for the data.
        /// </summary>
        public int ID { get; set; }

        public string Name { get; set; }

        public string Comments { get; set; }

        public int Type { get; set; }

        public double DamagePoints { get; set; }

        public int ProjectileCaliber { get; set; }

        public EnumWarheadExplosivesType ExplosiveType { get; set; }

        public double ExplosiveWeight { get; set; }

        public int NumberOfWarheads { get; set; }

        public int ClusterBombDispersionAreaLength { get; set; }

        public int ClusterBombDispersionAreaWidth { get; set; }

        public bool Hypothetical { get; set; }

        public bool Deprecated { get; set; }
    }
}
