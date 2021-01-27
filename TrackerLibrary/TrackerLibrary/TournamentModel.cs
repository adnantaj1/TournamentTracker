using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary
{
    /// <summary>
    /// Represents one tournament.
    /// </summary>
    public class TournamentModel
    {
        /// <summary>
        /// The name of tournament.
        /// </summary>
        public string  TournamentName { get; set; }

        /// <summary>
        /// Entry fee to enter in the tournament.
        /// </summary>
        public decimal EntryFee { get; set; }

        /// <summary>
        /// List of total teams in the tournament. 
        /// </summary>
        public List<TeamModel> EnteredTeams { get; set; } = new List<TeamModel>();
        /// <summary>
        /// list of prizez for the winners
        /// </summary>
        public List<PrizeModel> Prizez { get; set; } = new List<PrizeModel>();

        /// <summary>
        /// List of matchups
        /// </summary>
        public List<List<MatchupModel>> Rounds { get; set; } = new List<List<MatchupModel>>();
    }
}
