using System;
using System.Collections.Generic;
using StarCitizenAPIWrapper.Models.Attributes;

namespace StarCitizenAPIWrapper.Models.Starmap.Systems
{
    /// <summary>
    /// The information about a starmap system from RSI.
    /// </summary>
    public class StarmapSystem 
    {
        /// <summary>
        /// The different affiliations of this system.
        /// </summary>
        [ApiName("affiliation")]
        public List<StarmapSystemAffiliation> Affiliations { get; set; }
        /// <summary>
        /// The aggregated danger of this system.
        /// </summary>
        [ApiName("aggregated_danger")]
        public double AggregatedDanger { get; set; }
        /// <summary>
        /// The aggregated economy of this system.
        /// </summary>
        [ApiName("aggregated_economy")]
        public double AggregatedEconomy { get; set; }
        /// <summary>
        /// The aggregated population of this system.
        /// </summary>
        [ApiName("aggregated_population")]
        public double AggregatedPopulation { get; set; }
        /// <summary>
        /// The aggregated size of this system.
        /// </summary>
        [ApiName("aggregated_size")]
        public double AggregatedSize { get; set; }
        /// <summary>
        /// The code of this system.
        /// </summary>
        public string Code { get; set; }
        /// <summary>
        /// The description of this system.
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// The id of this system.
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// The info url of this system.
        /// </summary>
        [ApiName("info_url")]
        public string InfoUrl { get; set; }
        /// <summary>
        /// The name of this system.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// The x position of this system in the verse.
        /// </summary>
        [ApiName("position_x")]
        public double PositionX { get; set; }
        /// <summary>
        /// The y position of this system in the verse.
        /// </summary>
        [ApiName("position_y")]
        public double PositionY { get; set; }
        /// <summary>
        /// The z position of this system in the verse.
        /// </summary>
        [ApiName("position_z")]
        public double PositionZ { get; set; }
        /// <summary>
        /// The status of this system.
        /// </summary>
        public char Status { get; set; }
        /// <summary>
        /// The thumbnail information of this system.
        /// </summary>
        public StarmapSystemThumbnail Thumbnail { get; set; }
        /// <summary>
        /// The last time this system was modified.
        /// </summary>
        [ApiName("time_modified")]  
        public DateTime TimeModified { get; set; }
        /// <summary>
        /// The system type.
        /// </summary>
        public string Type { get; set; }
    }
}
