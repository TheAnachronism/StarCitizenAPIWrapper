namespace StarCitizenAPIWrapper.Models.User
{
    /// <summary>
    /// Interface for the information about a organization a user is currently member of.
    /// </summary>
    public class UserOrganizationInfo
    {
        /// <summary>
        /// The image URL of the organization image.
        /// </summary>
        public string Image { get; set; }
        /// <summary>
        /// The name of the organization.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// The rank of the user inside this organization.
        /// </summary>
        public string Rank { get; set; }
        /// <summary>
        /// The SID of the organization.
        /// </summary>
        public string Sid { get; set; }
    }
}
