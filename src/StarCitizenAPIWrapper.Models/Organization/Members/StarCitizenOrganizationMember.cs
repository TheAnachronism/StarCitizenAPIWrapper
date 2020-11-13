namespace StarCitizenAPIWrapper.Models.Organization.Members
{
    /// <summary>
    /// Interface for organization member info from the API.
    /// </summary>
    public class StarCitizenOrganizationMember
    {
        /// <summary>
        /// Display name of this organization member.
        /// </summary>
        public string Display { get; set; }
        /// <summary>
        /// Handle of this organization member.
        /// </summary>
        public string Handle { get; set; }
        /// <summary>
        /// Image URL of this organization member.
        /// </summary>
        public string Image { get; set; }
        /// <summary>
        /// Rank of this member in the organization
        /// </summary>
        public string Rank { get; set; }
        /// <summary>
        /// Amount of stars this member has.
        /// </summary>
        public int Stars { get; set; }
        /// <summary>
        /// Roles this member has.
        /// </summary>
        public string[] Roles { get; set; }
    }
}
