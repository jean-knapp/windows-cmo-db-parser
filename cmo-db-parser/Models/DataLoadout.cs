using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cmo_db_parser.Models
{
    public class DataLoadout : IData, IDataTable
    {
        public string TableName { get; } = "DataLoadout";

        public static Dictionary<int,IData> DataEntries { get; set; } = new Dictionary<int,IData>();

        public List<(Type, string)> Properties { get; } = new List<(Type, string)>()
        {
            (typeof(int), nameof(ID)),
            (typeof(string), nameof(Name)),
            (typeof(string), nameof(Comments)),
            (typeof(int), nameof(ROF)),
            (typeof(int), nameof(Capacity)),
            (typeof(int), nameof(ReadyTime)),
            (typeof(int), nameof(ReadyTimeSustained)),
            (typeof(int), nameof(LoadoutRole)),
            (typeof(int), nameof(TimeOfDay)),
            (typeof(int), nameof(Weather)),
            (typeof(double), nameof(PayloadWeightDragModifier)),
            (typeof(int), nameof(DefaultCombatRadius)),
            (typeof(int), nameof(DefaultTimeOnStation)),
            (typeof(int), nameof(DefaultMissionProfile)),
            (typeof(bool), nameof(RequiresBuddyIllumination)),
            (typeof(bool), nameof(Hipothetical)),
            (typeof(bool), nameof(QuickTurnaround)),
            (typeof(int), nameof(QuickTurnaroundReadyTime)),
            (typeof(int), nameof(QuickTurnaroundMaxSorties)),
            (typeof(int), nameof(QuickTurnaroundAdditionalTimePenalty)),
            (typeof(int), nameof(QuickTurnaroundAirborneTime)),
            (typeof(int), nameof(QuickTurnaroundTimeOfDay)),
            (typeof(int), nameof(WinchesterShotgun)),
            (typeof(int), nameof(CargoType)),
            (typeof(double), nameof(CargoMass)),
            (typeof(double), nameof(CargoArea)),
            (typeof(double), nameof(CargoCrew)),
            (typeof(bool), nameof(CargoParadropCapable)),
            (typeof(int), nameof(CargoVolume)),
            (typeof(bool), nameof(Deprecated))
        };

        /// <summary>
        /// Represents the unique identifier for the data.
        /// </summary>
        public int ID { get; set; }
        
        /// <summary>
        /// Represents the name of the aircraft.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Represents any additional comments about the aircraft.
        /// </summary>
        public string Comments { get; set; }

        public int ROF { get; set; }

        public int Capacity { get; set; }

        public int ReadyTime { get; set; }

        public int ReadyTimeSustained { get; set; }

        public int LoadoutRole { get; set; }

        public int TimeOfDay { get; set; }

        public int Weather { get; set; }

        public double PayloadWeightDragModifier { get; set; }

        public int DefaultCombatRadius { get; set; }

        public int DefaultTimeOnStation { get; set; }

        public int DefaultMissionProfile { get; set; }

        public bool RequiresBuddyIllumination { get; set; }

        public bool Hipothetical { get; set; }

        public bool QuickTurnaround { get; set; }

        public int QuickTurnaroundReadyTime { get; set; }

        public int QuickTurnaroundMaxSorties { get; set; }

        public int QuickTurnaroundAdditionalTimePenalty { get; set; }

        public int QuickTurnaroundAirborneTime { get; set; }

        public int QuickTurnaroundTimeOfDay { get; set; }

        public int WinchesterShotgun { get; set; }

        public int CargoType { get; set; }

        public double CargoMass { get; set; }

        public double CargoArea { get; set; }

        public double CargoCrew { get; set; }

        public bool CargoParadropCapable { get; set; }

        public int CargoVolume { get; set; }

        public bool Deprecated { get; set; }

        public List<DataWeaponRecord> Weapons { get; set; } = new List<DataWeaponRecord>();
    }
}
