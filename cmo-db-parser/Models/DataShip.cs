using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cmo_db_parser.Models
{
    public class DataShip : IData, IDataTable
    {
        public string TableName { get; } = "DataShip";

        public static Dictionary<int, IData> DataEntries { get; set; } = new Dictionary<int, IData>();

        public List<(Type, string)> Properties { get; } = new List<(Type, string)>()
        {
            (typeof(int), nameof(ID)), // ID
            (typeof(EnumShipCategory), nameof(Category)), // Category
            (typeof(EnumShipType), nameof(Type)), // Type
            (typeof(string), nameof(Name)), // Name
            (typeof(string), nameof(Comments)), // Comments
            (typeof(EnumOperatorCountry), nameof(OperatorCountry)), // OperatorCountry
            (typeof(EnumOperatorService), nameof(OperatorService)), // OperatorService
            (typeof(int), nameof(YearCommissioned)), // YearCommissioned
            (typeof(int), nameof(YearDecommissioned)), // YearDecommissioned
            (typeof(double), nameof(Length)), // Length
            (typeof(double), nameof(Beam)), // Beam
            (typeof(double), nameof(Draft)), // Draft
            (typeof(double), nameof(Height)), // Height
            (typeof(int), nameof(DisplacementEmpty)), // DisplacementEmpty
            (typeof(int), nameof(DisplacementStandard)), // DisplacementStandard
            (typeof(int), nameof(DisplacementFull)), // DisplacementFull
            (typeof(int), nameof(Crew)), // Crew
            (typeof(EnumArmorType), nameof(ArmorBelt)), // ArmorBelt
            (typeof(EnumArmorType), nameof(ArmorBulkheads)), // ArmorBulkheads
            (typeof(EnumArmorType), nameof(ArmorDeck)), // ArmorDeck
            (typeof(EnumArmorType), nameof(ArmorBridge)), // ArmorBridge
            (typeof(EnumArmorType), nameof(ArmorCIC)), // ArmorCIC
            (typeof(EnumArmorType), nameof(ArmorEngineering)), // ArmorEngineering
            (typeof(EnumArmorType), nameof(ArmorRudder)), // ArmorRudder
            (typeof(int), nameof(DamagePoints)), // DamagePoints
            (typeof(int), nameof(FOCSeaState)), // FOCSeaState
            (typeof(int), nameof(MaxSeaState)), // MaxSeaState
            (typeof(int), nameof(RepairCapacity)), // RepairCapacity
            (typeof(int), nameof(TroopCapacity)), // TroopCapacity
            (typeof(int), nameof(CargoCapacity)), // CargoCapacity
            (typeof(int), nameof(MissileDefense)), // MissileDefense
            (typeof(EnumShipCSGen), nameof(CSGen)), // CSGen
            (typeof(EnumErgonomics), nameof(Ergonomics)), // Ergonomics
            (typeof(int), nameof(OODADetectionCycle)), // OODADetectionCycle
            (typeof(int), nameof(OODATargetingCycle)), // OODATargetingCycle
            (typeof(int), nameof(OODAEvasiveCycle)), // OODAEvasiveCycle
            (typeof(EnumShipPhysicalSize), nameof(PhysicalSizeCode)), // PhysicalSizeCode
            (typeof(bool), nameof(Hypothetical)), // Hypothetical
            (typeof(EnumCargoType), nameof(CargoType)), // CargoType
            (typeof(double), nameof(CargoMass)), // CargoMass
            (typeof(double), nameof(CargoArea)), // CargoArea
            (typeof(double), nameof(CargoCrew)), // CargoCrew
            (typeof(int), nameof(CargoVolume)), // CargoVolume
            (typeof(int), nameof(Cost)), // Cost
            (typeof(bool), nameof(Deprecated)) // Deprecated
        };

        // <summary>
            /// Represents the unique identifier for the data.
            /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// Represents the category of the aircraft.
        /// </summary>
        public EnumShipCategory Category { get; set; }

        /// <summary>
        /// Represents the type of the aircraft.
        /// </summary>
        public EnumShipType Type { get; set; }

        /// <summary>
        /// Represents the name of the aircraft.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Represents any additional comments about the aircraft.
        /// </summary>
        public string Comments { get; set; }

        /// <summary>
        /// Represents the country of the operator.
        /// </summary>
        public EnumOperatorCountry OperatorCountry { get; set; }

        /// <summary>
        /// Represents the service of the operator.
        /// </summary>
        public EnumOperatorService OperatorService { get; set; }

        /// <summary>
        /// Represents the year the aircraft was commissioned.
        /// </summary>
        public int YearCommissioned { get; set; }

        /// <summary>
        /// Represents the year the aircraft was decommissioned.
        /// </summary>
        public int YearDecommissioned { get; set; }

        public double Length { get; set; }

        public double Beam { get; set; }

        public double Draft { get; set; }

        public double Height { get; set; }

        public int DisplacementEmpty { get; set; }

        public int DisplacementStandard { get; set; }

        public int DisplacementFull { get; set; }

        public int Crew { get; set; }

        public EnumArmorType ArmorBelt { get; set; }

        public EnumArmorType ArmorBulkheads { get; set; }

        public EnumArmorType ArmorDeck { get; set; }

        public EnumArmorType ArmorBridge { get; set; }

        public EnumArmorType ArmorCIC { get; set; }

        public EnumArmorType ArmorEngineering { get; set; }

        public EnumArmorType ArmorRudder { get; set; }

        public int DamagePoints { get; set; }

        public int FOCSeaState { get; set; }

        public int MaxSeaState { get; set; }

        public int RepairCapacity { get; set; }

        public int TroopCapacity { get; set; }

        public int CargoCapacity { get; set; }

        public int MissileDefense { get; set; }

        public EnumShipCSGen CSGen { get; set; }

        public EnumErgonomics Ergonomics { get; set; }

        public int OODADetectionCycle { get; set; }

        public int OODATargetingCycle { get; set; }

        public int OODAEvasiveCycle { get; set; }

        public EnumShipPhysicalSize PhysicalSizeCode { get; set; }

        public bool Hypothetical { get; set; }

        public EnumCargoType CargoType { get; set; }

        public double CargoMass { get; set; }

        public double CargoArea { get; set; }

        public double CargoCrew { get; set; }

        public int CargoVolume { get; set; }

        public int Cost { get; set; }

        public bool Deprecated { get; set; }

        public List<DataMount> Mounts { get; set; } = new List<DataMount>();

        public List<DataAircraftFacility> AircraftFacilities { get; set; } = new List<DataAircraftFacility>();
    }
}
