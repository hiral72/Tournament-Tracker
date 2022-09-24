using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class MatchupModel
    {
        public int MatchupId{get; set;}

        //set of teams involved in this matchp
        public List<MatchupEntryModel> Entries { get; set; }
        public TeamModel Winner { get; set; }
        public int WinnerId { get; set; }
        public int MatchupRound { get; set; }

        public MatchupModel()
        {
            Entries= new List<MatchupEntryModel>();
        }

        public string DisplayName
        {
            get 
            {
                string output = "";
                foreach (MatchupEntryModel entry in Entries)
                {
                    if (entry.TeamCompeting != null)
                    {
                        if (output.Length == 0)
                        {
                            output = entry.TeamCompeting.TeamName;
                        }
                        else
                        {
                            output = output + " vs. " + entry.TeamCompeting.TeamName;
                        }
                    }
                    else
                    {
                        output = "Matchup not determined";
                        break;

                    }
                    
                }
                return output;
            }
        }

    }
}
