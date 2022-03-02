using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class TournamentModel
    {
        /// <summary>
        /// Represents the name of the tournament.
        /// </summary>
        public string TournamentName { get; set; }
        /// <summary>
        /// Represents the entry fee that each team has to pay to enter the tournament.
        /// </summary>
        public decimal EntryFee { get; set; }
        /// <summary>
        /// Represents all the teams that entered the tournament.
        /// </summary>
        public List<TeamModel> EnteredTeams { get; set; } = new();
        /// <summary>
        /// Represent the prizes that are given at the end of the tournament.
        /// </summary>
        public List<PrizeModel> Prizes { get; set; } = new();
        /// <summary>
        /// Represent all the rounds of the tournament.
        /// </summary>
        public List<List<MatchupModel>> Rounds { get; set; } = new();
    }
}
