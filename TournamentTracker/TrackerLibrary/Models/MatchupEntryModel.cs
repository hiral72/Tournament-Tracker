using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class MatchupEntryModel
    {
   
        public TeamModel TeamCompeting { get; set; }
        //Represents one team in a matchup

        public double Score { get; set; }
        //Represents score for that particular team

        public MatchupModel ParentMatchup { get; set; }
        //Represents the matchup that this team came from as a winner
    }

}
