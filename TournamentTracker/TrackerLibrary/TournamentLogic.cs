using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;

namespace TrackerLibrary
{
    public static class TournamentLogic
    {
        // TODO- wireup our matchups
        // order team list randomly
        // check if its big enough- if not ,add in byes
        // power of 2 req. 2^n - eg.14 not+2byes=16
        // create our first round of matchups
        // create every round after that-half no. of mathcups eg.8 mp- 4mp -2mp-1mp 
        public static void CreateRounds(TournamentModel model)
        {
            // order team list randomly
            List<TeamModel> randomizedTeams = RandomizeTeamOrder(model.EnteredTeams);

        }
        private static List<TeamModel> RandomizeTeamOrder(List<TeamModel> teams)
        {
            return teams.OrderBy(a => Guid.NewGuid()).ToList();
        }
    }
}
