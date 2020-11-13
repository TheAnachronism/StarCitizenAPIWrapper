using StarCitizenAPIWrapper.Models.Attributes;

namespace StarCitizenAPIWrapper.Models.Organization
{
    /// <summary>
    /// Interface for organization info from the API.
    /// </summary>
    public class StarCitizenOrganization
    {
        /// <summary>
        /// The type of this organization.
        /// </summary>
        public Archetypes Archetype { get; set; }
        /// <summary>
        /// The banner url of this organization.
        /// </summary>
        public string Banner { get; set; }
        /// <summary>
        /// The required commitment of this organization.
        /// </summary>
        public string Commitment { get; set; }
        /// <summary>
        /// The focus information of this organization.
        /// </summary>
        public Focus Focus { get; set; }
        /// <summary>
        /// The headline information of this organization.
        /// </summary>
        public (string html, string plaintext) Headline { get; set; }
        /// <summary>
        /// The link to this organization.
        /// </summary>
        public string Href { get; set; }
        /// <summary>
        /// The main language of this organization.
        /// </summary>
        [ApiName("lang")]
        public string Language { get; set; }
        /// <summary>
        /// The url of the logo of this organization.
        /// </summary>
        public string Logo { get; set; }
        /// <summary>
        /// The amount of members this organization has.
        /// </summary>
        public int Members { get; set; }
        /// <summary>
        /// The name of this organization.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Indicates if this organization is currently recruiting.
        /// </summary>
        public bool Recruiting { get; set; }
        /// <summary>
        /// Indicates if this organization is role playing or not.
        /// </summary>
        public bool RolePlaying { get; set; }
        /// <summary>
        /// The SID of this organization.
        /// </summary>
        public string SID { get; set; }
        /// <summary>
        /// The url of this organization page.
        /// </summary>
        public string Url { get; set; }
    }

    /// <summary>
    /// Helper struct to contain information about the focus of an org.
    /// </summary>
    public struct Focus
    {
        /// <summary>
        /// The url of the image for the primary focus.
        /// </summary>
        public string PrimaryFocusImage { get; set; }
        /// <summary>
        /// The primary focus type of the organization.
        /// </summary>
        public FocusTypes PrimaryFocus { get; set; }
        /// <summary>
        /// The url of the image for the secondary focus.
        /// </summary>
        public string SecondaryFocusImage { get; set; }
        /// <summary>
        /// The secondary focus type of the organization.
        /// </summary>
        public FocusTypes SecondaryFocus { get; set; }
    }

    /// <summary>
    /// The different types of focus for an organization.
    /// </summary>
    public enum FocusTypes
    {
#pragma warning disable 1591
        BountyHunting,
        Engineering,
        Exploration,
        Freelancing,
        Infiltration,
        Piracy,
        Resources,
        Scouting,
        Security,
        Smuggling,
        Social,
        Trading,
        Transport
#pragma warning restore 1591
    }

    /// <summary>
    /// The different types of organizations
    /// </summary>
    public enum Archetypes
    {
#pragma warning disable 1591
        Corporation,
        PMC,
        Faith,
        Syndicate,
        Organization,
        Undefined
#pragma warning restore 1591
    }
}
