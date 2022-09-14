using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class TournamentModel
    {
        public int TournamentId { get; set; }
        public string TournamentName { get; set; }
        public decimal EntryFee { get; set; }
        public List<TeamModel> EnteredTeams { get; set; }
        public List<PrizeModel> Prizes { get; set; }
        public List<List<MatchupModel>> Rounds { get; set; }

        public TournamentModel ()
	    {
            EnteredTeams=new List<TeamModel>();
            Prizes=new List<PrizeModel>();
            Rounds = new List<List<MatchupModel>>();
	    }
    }
}
