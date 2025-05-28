using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cmo_db_parser.Models
{
    public class DataMount : IData, IDataTable
    {
        public string TableName { get; } = "DataMount";

        public static Dictionary<int, IData> DataEntries { get; set; } = new Dictionary<int, IData>();

        public List<(Type, string)> Properties { get; } = new List<(Type, string)>()
        {
            (typeof(int), nameof(ID)),
            (typeof(string), nameof(Name)),
            (typeof(string), nameof(Comments)),
            (typeof(EnumArmorType), nameof(ArmorGeneral)),
            (typeof(int), nameof(ROF)),
            (typeof(int), nameof(Capacity)),
            (typeof(int), nameof(MagazineROF)),
            (typeof(int), nameof(MagazineCapacity)),
            (typeof(float), nameof(DamagePoints)),
            (typeof(int), nameof(Logistic)),
            (typeof(int), nameof(ReserveTarget)),
            (typeof(int), nameof(CanHotReload)),
            (typeof(int), nameof(Availability)),
            (typeof(int), nameof(Trainable)),
            (typeof(int), nameof(Autonomous)),
            (typeof(int), nameof(LocalControl)),
            (typeof(int), nameof(Hypothetical)),
            (typeof(EnumCargoType), nameof(Cargo_Type)),
            (typeof(float), nameof(Cargo_Mass)),
            (typeof(float), nameof(Cargo_Area)),
            (typeof(float), nameof(Cargo_Crew)),
            (typeof(int), nameof(Cargo_ParadropCapable)),
            (typeof(int), nameof(MobileUnitCategory)),
            (typeof(int), nameof(Deprecated))

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

        /// <summary>
        /// Represents the general armor rating.
        /// </summary>
        public EnumArmorType ArmorGeneral { get; set; }

        /// <summary>
        /// Represents the rate of fire.
        /// </summary>
        public int ROF { get; set; }

        /// <summary>
        /// Represents the capacity of this mount (e.g., ammunition capacity).
        /// </summary>
        public int Capacity { get; set; }

        /// <summary>
        /// Represents the rate of fire when using the magazine.
        /// </summary>
        public int MagazineROF { get; set; }

        /// <summary>
        /// Represents the capacity of the magazine.
        /// </summary>
        public int MagazineCapacity { get; set; }

        /// <summary>
        /// Represents damage points (often used in game or sim contexts).
        /// </summary>
        public float DamagePoints { get; set; }

        /// <summary>
        /// Represents logistic-related value or status.
        /// </summary>
        public int Logistic { get; set; }

        /// <summary>
        /// Represents a reserve target value (context depends on your application).
        /// </summary>
        public int ReserveTarget { get; set; }

        /// <summary>
        /// Indicates if the mount can be hot reloaded (1 = true, 0 = false).
        /// </summary>
        public int CanHotReload { get; set; }

        /// <summary>
        /// Represents availability status (context depends on your application).
        /// </summary>
        public int Availability { get; set; }

        /// <summary>
        /// Indicates if the mount is trainable (can rotate, etc.) (1 = true, 0 = false).
        /// </summary>
        public int Trainable { get; set; }

        /// <summary>
        /// Indicates if this mount is autonomous (1 = true, 0 = false).
        /// </summary>
        public int Autonomous { get; set; }

        /// <summary>
        /// Indicates if the mount is under local control (1 = true, 0 = false).
        /// </summary>
        public int LocalControl { get; set; }

        /// <summary>
        /// Indicates if this mount is hypothetical (1 = true, 0 = false).
        /// </summary>
        public int Hypothetical { get; set; }

        /// <summary>
        /// Represents the type of cargo (if used to store cargo).
        /// </summary>
        public EnumCargoType Cargo_Type { get; set; }

        /// <summary>
        /// Represents the mass of cargo (if applicable).
        /// </summary>
        public float Cargo_Mass { get; set; }

        /// <summary>
        /// Represents the area of cargo (if applicable).
        /// </summary>
        public float Cargo_Area { get; set; }

        /// <summary>
        /// Represents the crew capacity or number of personnel carried as cargo.
        /// </summary>
        public float Cargo_Crew { get; set; }

        /// <summary>
        /// Indicates if this unit is capable of paradropping cargo (1 = true, 0 = false).
        /// </summary>
        public int Cargo_ParadropCapable { get; set; }

        /// <summary>
        /// Represents the mobile unit category (context depends on your application).
        /// </summary>
        public int MobileUnitCategory { get; set; }

        /// <summary>
        /// Indicates if this data entry is deprecated (1 = true, 0 = false).
        /// </summary>
        public int Deprecated { get; set; }

        public List<DataWeaponRecord> Weapons { get; set; } = new List<DataWeaponRecord>();

    }
}
