using System;
using System.Collections.Generic;
using StarCitizenAPIWrapper.Models.Attributes;
using StarCitizenAPIWrapper.Models.Ships.Compiled;
using StarCitizenAPIWrapper.Models.Ships.Manufacturer;
using StarCitizenAPIWrapper.Models.Ships.Media;

namespace StarCitizenAPIWrapper.Models.Ships
{
    /// <summary>
    /// Interface for the information about a ship.
    /// </summary>
    public class StarCitizenShip
    {
        /// <summary>
        /// The after burner speed of this ship.
        /// </summary>
        [ApiName("afterburner_speed")]
        public int AfterburnerSpeed { get; set; }
        /// <summary>
        /// The beam of this ship.
        /// </summary>
        public double Beam { get; set; }
        /// <summary>
        /// The cargo capacity of this ship.
        /// </summary>
        public int CargoCapacity { get; set; }
        /// <summary>
        /// The id of the chassis of this ship.
        /// </summary>
        [ApiName("chassis_id")]
        public int ChassisId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<KeyValuePair<ShipCompiledClasses, List<KeyValuePair<string, RsiShipComponent>>>> Compiled { get; set; }
        /// <summary>
        /// The description of this ship.
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// The focus of this ship.
        /// </summary>
        public string Focus { get; set; }
        /// <summary>
        /// The height of this ship.
        /// </summary>
        public double Height { get; set; }
        /// <summary>
        /// The id of this ship on the API database.
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// The length of this ship.
        /// </summary>
        public double Length { get; set; }
        /// <summary>
        /// The manufacturer of this ship.
        /// </summary>
        public ShipManufacturer Manufacturer { get; set; }
        /// <summary>
        /// The id of the manufacturer of this ship.
        /// </summary>
        public int ManufacturerId { get; set; }
        /// <summary>
        /// The mass of this ship.
        /// </summary>
        public int Mass { get; set; }
        /// <summary>
        /// The maximal amount of crew members for this ship.
        /// </summary>
        [ApiName("max_crew")]
        public int MaxCrew { get; set; }
        /// <summary>
        /// Array of urls of images for this ship.
        /// </summary>
        public ApiMedia[] Media { get; set; }
        /// <summary>
        /// The minimal amount of crew members for this ship.
        /// </summary>
        [ApiName("min_crew")]
        public int MinCrew { get; set; }
        /// <summary>
        /// The name of this ship.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// The maximal amount of pitch this ship has.
        /// </summary>
        [ApiName("pitch_max")]
        public double PitchMax { get; set; }
        /// <summary>
        /// The price of this ship.
        /// </summary>
        public double Price { get; set; }
        /// <summary>
        /// The production note of this ship.
        /// </summary>
        [ApiName("production_note")]
        public string ProductionNote { get; set; }
        /// <summary>
        /// The current status of the production of this ship.
        /// </summary>
        [ApiName("production_status")]
        public ProductionStatusTypes ProductionStatus { get; set; }
        /// <summary>
        /// The maximal amount of roll this ship has.
        /// </summary>
        [ApiName("roll_max")]
        public double RollMax { get; set; }
        /// <summary>
        /// The scm speed of this ship.
        /// </summary>
        [ApiName("scm_speed")]
        public int ScmSpeed { get; set; }
        /// <summary>
        /// The size of this ship.
        /// </summary>
        public ShipSizes Size { get; set; }
        /// <summary>
        /// The last time this ship was modified.
        /// </summary>
        public DateTime TimeModified { get; set; }
        /// <summary>
        /// The type of this ship.
        /// </summary>
        public ShipTypes Type { get; set; }
        /// <summary>
        /// The url of this ship on the RSI website.
        /// </summary>
        public string Url { get; set; }
        /// <summary>
        /// The acceleration on the x-axis of this ship.
        /// </summary>
        [ApiName("xaxis_acceleration")]
        public double XAxisAcceleration { get; set; }
        /// <summary>
        /// The maximal amount of yaw of this ship.
        /// </summary>
        [ApiName("yaw_max")]
        public double YawMax { get; set; }
        /// <summary>
        /// The acceleration on the y-axis of this ship.
        /// </summary>
        [ApiName("yaxis_acceleration")]
        public double YAxisAcceleration { get; set; }
        /// <summary>
        /// The acceleration on the z-axis of this ship.
        /// </summary>
        [ApiName("zaxis_acceleration")]
        public double ZAxisAcceleration { get; set; }
    }

    #region Helper enums

    /// <summary>
    /// The different types of production status for ships.
    /// </summary>
    public enum ProductionStatusTypes
    {
#pragma warning disable 1591
        FlightReady,
        InConcept,
        InProduction,
        Undefined
    }

    /// <summary>
    /// The different sizes of ships.
    /// </summary>
    public enum ShipSizes
    {
        Snub,
        Small,
        Medium,
        Vehicle,
        Large,
        Capital,
        Undefined
    }

    /// <summary>
    /// The different types of ships.
    /// </summary>
    public enum ShipTypes
    {
        Multi,
        Combat,
        Transport,
        Exploration,
        Industrial,
        Support,
        Competition,
        Ground,
        Undefined

    }

    /// <summary>
    /// The different classes of components of a ship.
    /// </summary>
    public enum ShipCompiledClasses
    {
        RSIAvionic,
        RSIModular,
        RSIPropulsion,
        RSIThruster,
        RSIWeapon
#pragma warning restore 1591
    }

    #endregion
}
