using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class MatchupModel
    {
        /// <summary>
        /// Represents the entries of the two teams competing in this particular matchup.
        /// </summary>
        public List<MatchupEntryModel> Entries { get; set; } = new();
        /// <summary>
        /// Represents the winner team of this particular matchup.
        /// </summary>
        public TeamModel Winner { get; set; }
        /// <summary>
        /// Represents the round in which this matchup takes place.
        /// </summary>
        public int MatchupRound { get; set; }
    }
}
