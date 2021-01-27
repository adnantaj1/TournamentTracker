using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary
{
    /// <summary>
    /// Represents one match in the tournament
    /// </summary>
    public class MatchupModel
    {
        /// <summary>
        /// Represents one in the tournament.
        /// </summary>
        public List<MatchupEntryModel> Entries { get; set; } = new List<MatchupEntryModel>();

        /// <summary>
        /// The winner of the match.
        /// </summary>
        public TeamModel winner { get; set; }

        /// <summary>
        /// which round this match is a part of. 
        /// </summary>
        public int MatchupRound { get; set; }
    }
}
