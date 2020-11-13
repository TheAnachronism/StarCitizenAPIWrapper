namespace StarCitizenAPIWrapper.Models.User
{
    /// <summary>
    /// Interface for user info from the API.
    /// </summary>
    public class StarCitizenUser
    {        
        /// <summary>
        /// The profile information about this user.
        /// </summary>
        public StarCitizenUserProfile Profile { get; set; }
        /// <summary>
        /// The current <see cref="UserOrganizationInfo"/> of the organization this user is currently member of.
        /// </summary>
        public UserOrganizationInfo Organization { get; set; }
    }
}
