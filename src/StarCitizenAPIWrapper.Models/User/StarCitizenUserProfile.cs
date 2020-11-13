using System;
using StarCitizenAPIWrapper.Models.Attributes;

namespace StarCitizenAPIWrapper.Models.User
{
    /// <summary>
    /// Information about the user profile.
    /// </summary>
    public class StarCitizenUserProfile
    {        
        /// <summary>
        /// The current badge of the user.
        /// </summary>
        public string Badge { get; set; }

        /// <summary>
        /// The url to the image of the <see cref="Badge"/>.
        /// </summary>
        [ApiName("badge_image")]
        public string BadgeImage { get; set; }

        /// <summary>
        /// The display name of this user.
        /// </summary>
        public string Display { get; set; }

        /// <summary>
        /// The datetime when this user enlisted.
        /// </summary>
        public DateTime Enlisted { get; set; }

        /// <summary>
        /// The languages this user is fluent in.
        /// </summary>
        public string[] Fluency { get; set; }

        /// <summary>
        /// The handle of this user.
        /// </summary>
        public string Handle { get; set; }

        /// <summary>
        /// The id of this user.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// The url of the image of this user.
        /// </summary>
        public string Image { get; set; }

        /// <summary>
        /// The information about the user page.
        /// </summary>
        public (string Title, string Url) Page { get; set; }
    }
}
