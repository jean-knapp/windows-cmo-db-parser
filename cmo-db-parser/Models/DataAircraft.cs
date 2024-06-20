using System;
using System.Collections.Generic;

namespace cmo_db_parser.Models
{
    public class DataAircraft : IData, IDataTable
    {
        public string TableName { get; } = "DataAircraft";

        public static Dictionary<int,IData> DataEntries { get; set; } = new Dictionary<int,IData>();

        public List<(Type, string)> Properties { get; } = new List<(Type, string)>()
        {
            (typeof(int), nameof(ID)), // ID
            (typeof(EnumAircraftCategory), nameof(Category)), // Category
            (typeof(EnumAircraftType), nameof(Type)), // Type
            (typeof(string), nameof(Name)), // Name
            (typeof(string), nameof(Comments)), // Comments
            (typeof(EnumOperatorCountry), nameof(OperatorCountry)), // OperatorCountry
            (typeof(EnumOperatorService), nameof(OperatorService)), // OperatorService
            (typeof(int), nameof(YearCommissioned)), // YearCommissioned
            (typeof(int), nameof(YearDecommissioned)), // YearDecommissioned
            (typeof(double), nameof(Length)), // Length
            (typeof(double), nameof(Span)), // Span
            (typeof(double), nameof(Height)), // Height
            (typeof(int), nameof(WeightEmpty)), // WeightEmpty
            (typeof(int), nameof(WeightMax)), // WeightMax
            (typeof(int), nameof(WeightPayload)), // WeightPayload
            (typeof(int), nameof(Crew)), // Crew
            (typeof(double), nameof(Agility)), // Agility
            (typeof(double), nameof(ClimbRate)), // ClimbRate
            (typeof(EnumAircraftAutonomousControlLevel), nameof(AutonomousControlLevel)), // AutonomousControlLevel
            (typeof(EnumAircraftCockpitGen), nameof(CockpitGen)), // CockpitGen
            (typeof(EnumErgonomics), nameof(Ergonomics)), // Ergonomics
            (typeof(int), nameof(OADADetectionCycle)), // OADADetectionCycle
            (typeof(int), nameof(OADATargetingCycle)), // OADATargetingCycle
            (typeof(int), nameof(OADAEvasiveCycle)), // OADAEvasiveCycle
            (typeof(int), nameof(TotalEndurance)), // TotalEndurance
            (typeof(EnumAircraftPhysicalSize), nameof(PhysicalSizeCode)), // PhysicalSizeCode
            (typeof(EnumRunwayLength), nameof(RunwayLengthCode)), // RunwayLengthCode
            (typeof(bool), nameof(Hypothetical)), // Hypothetical
            (typeof(int), nameof(Cost)), // Cost
            (typeof(double), nameof(DamagePoints)), // DamagePoints
            (typeof(EnumArmorType), nameof(AircraftEngineArmor)), // AircraftEngineArmor
            (typeof(EnumArmorType), nameof(AircraftFuselageArmor)), // AircraftFuselageArmor
            (typeof(EnumArmorType), nameof(AircraftCockpitArmor)), // AircraftCockpitArmor
            (typeof(EnumAircraftCockpitVisibility), nameof(Visibility)), // Visibility
            (typeof(int), nameof(FuelOffloadRate)), // FuelOffloadRate
            (typeof(bool), nameof(Deprecated)) // Deprecated
        };

        /// <summary>
        /// Represents the unique identifier for the data.
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// Represents the category of the aircraft.
        /// </summary>
        public EnumAircraftCategory Category { get; set; }

        /// <summary>
        /// Represents the type of the aircraft.
        /// </summary>
        public EnumAircraftType Type { get; set; }

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

        /// <summary>
        /// Represents the length of the aircraft.
        /// </summary>
        public double Length { get; set; }

        /// <summary>
        /// Represents the span of the aircraft.
        /// </summary>
        public double Span { get; set; }

        /// <summary>
        /// Represents the height of the aircraft.
        /// </summary>
        public double Height { get; set; }

        /// <summary>
        /// Represents the empty weight of the aircraft.
        /// </summary>
        public int WeightEmpty { get; set; }

        /// <summary>
        /// Represents the maximum weight of the aircraft.
        /// </summary>
        public int WeightMax { get; set; }

        /// <summary>
        /// Represents the maximum payload weight of the aircraft.
        /// </summary>
        public int WeightPayload { get; set; }

        /// <summary>
        /// Represents the crew required for the aircraft.
        /// </summary>
        public int Crew { get; set; }

        /// <summary>
        /// Represents the agility of the aircraft.
        /// </summary>
        public double Agility { get; set; }

        /// <summary>
        /// Represents the climb rate of the aircraft.
        /// </summary>
        public double ClimbRate { get; set; }

        /// <summary>
        /// Represents the autonomous control level of the aircraft.
        /// </summary>
        public EnumAircraftAutonomousControlLevel AutonomousControlLevel { get; set; }

        /// <summary>
        /// Represents the generation of the cockpit.
        /// </summary>
        public EnumAircraftCockpitGen CockpitGen { get; set; }

        /// <summary>
        /// Represents the ergonomics of the aircraft.
        /// </summary>
        public EnumErgonomics Ergonomics { get; set; }

        /// <summary>
        /// Represents the OADA detection cycle of the aircraft.
        /// </summary>
        public int OADADetectionCycle { get; set; }

        /// <summary>
        /// Represents the OADA targeting cycle of the aircraft.
        /// </summary>
        public int OADATargetingCycle { get; set; }

        /// <summary>
        /// Represents the OADA evasive cycle of the aircraft.
        /// </summary>
        public int OADAEvasiveCycle { get; set; }

        /// <summary>
        /// Represents the total endurance of the aircraft.
        /// </summary>
        public int TotalEndurance { get; set; }

        /// <summary>
        /// Represents the physical size code of the aircraft.
        /// </summary>
        public EnumAircraftPhysicalSize PhysicalSizeCode { get; set; }

        /// <summary>
        /// Represents the runway length code of the aircraft.
        /// </summary>
        public EnumRunwayLength RunwayLengthCode { get; set; }

        /// <summary>
        /// Indicates whether the aircraft is hypothetical.
        /// </summary>
        public bool Hypothetical { get; set; }

        /// <summary>
        /// Represents the cost of the aircraft.
        /// </summary>
        public int Cost { get; set; }

        /// <summary>
        /// Represents the damage points of the aircraft.
        /// </summary>
        public double DamagePoints { get; set; }

        /// <summary>
        /// Represents the armor rating of the aircraft's engine.
        /// </summary>
        public EnumArmorType AircraftEngineArmor { get; set; }

        /// <summary>
        /// Represents the armor rating of the aircraft's fuselage.
        /// </summary>
        public EnumArmorType AircraftFuselageArmor { get; set; }

        /// <summary>
        /// Represents the armor rating of the aircraft's cockpit.
        /// </summary>
        public EnumArmorType AircraftCockpitArmor { get; set; }

        /// <summary>
        /// Represents the visibility rating of the aircraft.
        /// </summary>
        public EnumAircraftCockpitVisibility Visibility { get; set; }

        /// <summary>
        /// Represents the fuel offload rate of the aircraft.
        /// </summary>
        public int FuelOffloadRate { get; set; }

        /// <summary>
        /// Indicates whether the aircraft is deprecated.
        /// </summary>
        public bool Deprecated { get; set; }

        public List<DataLoadout> Loadouts { get; set; } = new List<DataLoadout>();
    }
}