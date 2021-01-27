using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary
{
    /// <summary>
    /// Represents one team.
    /// </summary>
    public class TeamModel
    {
        /// <summary>
        /// List of members of the specific team.
        /// </summary>
        public List<PersonModel> TeamMembers { get; set; } = new List<PersonModel>();

        /// <summary>
        /// name of the team. 
        /// </summary>
        public String TeamName { get; set; }
    }
}
