using StarCitizenAPIWrapper.Models.Attributes;
using System.Collections.Generic;
using StarCitizenAPIWrapper.Models.Starmap.Object;

namespace StarCitizenAPIWrapper.Models.Starmap.Systems
{
    /// <summary>
    /// The more detailed information about a specific star system.
    /// </summary>
    public class StarmapSystemDetail : StarmapSystem
    {
        /// <summary>
        /// All the objects inside this system.
        /// </summary>
        [ApiName("celestial_objects")]
        public List<StarCitizenStarMapObject> CelestialObjects { get; set; }
        /// <summary>
        /// The frost line of this system.
        /// </summary>
        [ApiName("frost_line")]
        public double FrostLine { get; set; }
        /// <summary>
        /// The habitable zone on the inner layer.
        /// </summary>
        [ApiName("habitable_zone_inner")]
        public double HabitableZoneInner { get; set; }
        /// <summary>
        /// The habitable zone on the outer layer.
        /// </summary>
        [ApiName("habitable_zone_outer")]
        public double HabitableZoneOuter { get; set; }
    }
}
