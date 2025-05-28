using System;
using System.Collections.Generic;

namespace cmo_db_viewer.Models
{
    public class DataWeapon : IData, IDataTable
    {
        public string TableName { get; } = "DataWeapon";

        public static Dictionary<int,IData> DataEntries { get; set; } = new Dictionary<int,IData>();

        public List<(Type, string)> Properties { get; } = new List<(Type, string)>()
        {
            (typeof(int), nameof(ID)),
            (typeof(string), nameof(Name)),
            (typeof(string), nameof(Comments)),
            (typeof(EnumWeaponType), nameof(Type)),
            (typeof(EnumWeaponGeneration), nameof(Generation)),
            (typeof(double), nameof(Length)),
            (typeof(double), nameof(Span)),
            (typeof(double), nameof(Diameter)),
            (typeof(double), nameof(Weight)),
            (typeof(double), nameof(BurnoutTime)),
            (typeof(double), nameof(BurnoutWeight)),
            (typeof(double), nameof(CruiseAltitude)),
            (typeof(double), nameof(CruiseAltitudeASL)),
            (typeof(int), nameof(WaypointNumber)),
            (typeof(int), nameof(IlluminationTime)),
            (typeof(int), nameof(CEP)),
            (typeof(int), nameof(CEPSurface)),
            (typeof(double), nameof(AirPoK)),
            (typeof(double), nameof(SurfacePoK)),
            (typeof(double), nameof(LandPoK)),
            (typeof(double), nameof(SubsurfacePoK)),
            (typeof(double), nameof(ClimbRate)),
            (typeof(double), nameof(AirRangeMax)),
            (typeof(double), nameof(AirRangeMin)),
            (typeof(double), nameof(SurfaceRangeMax)),
            (typeof(double), nameof(SurfaceRangeMin)),
            (typeof(double), nameof(LandRangeMax)),
            (typeof(double), nameof(LandRangeMin)),
            (typeof(double), nameof(SubsurfaceRangeMax)),
            (typeof(double), nameof(SubsurfaceRangeMin)),
            (typeof(int), nameof(LaunchSpeedMax)),
            (typeof(int), nameof(LaunchSpeedMin)),
            (typeof(double), nameof(LaunchAltitudeMax)),
            (typeof(double), nameof(LaunchAltitudeMin)),
            (typeof(double), nameof(LaunchAltitudeMaxASL)),
            (typeof(double), nameof(LaunchAltitudeMinASL)),
            (typeof(int), nameof(TargetSpeedMax)),
            (typeof(int), nameof(TargetSpeedMin)),
            (typeof(double), nameof(TargetAltitudeMax)),
            (typeof(double), nameof(TargetAltitudeMin)),
            (typeof(double), nameof(TargetAltitudeMaxASL)),
            (typeof(double), nameof(TargetAltitudeMinASL)),
            (typeof(double), nameof(SnapUpDownAltitude)),
            (typeof(int), nameof(CanActAsSensor)),
            (typeof(int), nameof(MaxFlightTime)),
            (typeof(int), nameof(DetonationDelay)),
            (typeof(int), nameof(TorpedoSpeedCruise)),
            (typeof(double), nameof(TorpedoRangeCruise)),
            (typeof(int), nameof(TorpedoFullSpeed)),
            (typeof(double), nameof(TorpedoRangeFull)),
            (typeof(bool), nameof(Hypothetical)),
            (typeof(bool), nameof(BuddyIlluminationForCEC)),
            (typeof(EnumCargoType), nameof(CargoType)),
            (typeof(double), nameof(CargoMass)),
            (typeof(double), nameof(CargoVolume)),
            (typeof(double), nameof(CargoCrew)),
            (typeof(bool), nameof(CargoParadropCapable)),
            (typeof(int), nameof(Cost)),
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

        public EnumWeaponType Type { get; set; }

        public EnumWeaponGeneration Generation { get; set; }

        public double Length { get; set; }

        public double Span { get; set; }

        public double Diameter { get; set; }

        public double Weight { get; set; }

        public double BurnoutTime { get; set; }

        public double BurnoutWeight { get; set; }

        public double CruiseAltitude { get; set; }

        public double CruiseAltitudeASL { get; set; }

        public int WaypointNumber { get; set; }

        public int IlluminationTime { get; set; }

        public int CEP { get; set; }

        public int CEPSurface { get; set; }

        public double AirPoK { get; set; }

        public double SurfacePoK { get; set; }

        public double LandPoK { get; set; }

        public double SubsurfacePoK { get; set; }

        public double ClimbRate { get; set; }

        public double AirRangeMax { get; set; }

        public double AirRangeMin { get; set; }

        public double SurfaceRangeMax { get; set; }

        public double SurfaceRangeMin { get; set; }

        public double LandRangeMax { get; set; }

        public double LandRangeMin { get; set; }

        public double SubsurfaceRangeMax { get; set; }

        public double SubsurfaceRangeMin { get; set; }

        public int LaunchSpeedMax { get; set; }

        public int LaunchSpeedMin { get; set; }

        public double LaunchAltitudeMax { get; set; }

        public double LaunchAltitudeMin { get; set; }

        public double LaunchAltitudeMaxASL { get; set; }

        public double LaunchAltitudeMinASL { get; set; }

        public int TargetSpeedMax { get; set; }

        public int TargetSpeedMin { get; set; }
        
        public double TargetAltitudeMax { get; set; }

        public double TargetAltitudeMin { get; set; }

        public double TargetAltitudeMaxASL { get; set; }
        
        public double TargetAltitudeMinASL { get; set; }

        public double SnapUpDownAltitude { get; set; }

        public int CanActAsSensor { get; set; }

        public int MaxFlightTime { get; set; }

        public int DetonationDelay { get; set; }

        public int TorpedoSpeedCruise { get; set; }

        public double TorpedoRangeCruise { get; set; }

        public int TorpedoFullSpeed { get; set; }

        public double TorpedoRangeFull { get; set; }

        public bool Hypothetical { get; set; }

        public bool BuddyIlluminationForCEC { get; set; }

        public EnumCargoType CargoType { get; set; }

        public double CargoMass { get; set; }

        public double CargoVolume { get; set; }

        public double CargoCrew { get; set; }

        public bool CargoParadropCapable { get; set; }

        public int Cost { get; set; }

        public bool Deprecated { get; set; }

        public DataWarhead Warhead { get; set; } = null;

}
}
