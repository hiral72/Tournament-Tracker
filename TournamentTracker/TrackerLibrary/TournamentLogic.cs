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
            int teamCount = randomizedTeams.Count;
            int rounds = findNumberOfRounds(teamCount);
            int byes = findNumberOfByes(rounds,teamCount);
            model.Rounds.Add(CreateFirstRound(byes, randomizedTeams,rounds));
            CreateOtherRounds(model, rounds);
        }

        private static List<MatchupModel> CreateFirstRound(int byes, List<TeamModel> teams, int rounds)
        {
            List<MatchupModel> output = new List<MatchupModel>();
            MatchupModel curr = new MatchupModel();
            foreach (TeamModel team in teams)
            {
                
                curr.Entries.Add(new MatchupEntryModel { TeamCompeting = team });
                if (byes > 0 || curr.Entries.Count > 1)
                {
                    //adding byes in starting matchups
                    curr.MatchupRound = 1;
                    output.Add(curr);
                    curr = new MatchupModel();
                    if (byes > 0)
                    {
                        byes -= 1;
                    }
                }
            }
            return output;
        }

        private static void CreateOtherRounds(TournamentModel model, int rounds)
        {
            int round = 2;
            List<MatchupModel> prevRound=model.Rounds[0];
            List<MatchupModel> currRound = new List<MatchupModel>();
            MatchupModel currMatchUp = new MatchupModel();
            while (round <= rounds)
            {
                foreach (MatchupModel match in prevRound)
                {
                    currMatchUp.Entries.Add(new MatchupEntryModel { ParentMatchup = match });
                    if (currMatchUp.Entries.Count > 1)
                    {
                        currMatchUp.MatchupRound = round;
                        currRound.Add(currMatchUp);
                        currMatchUp = new MatchupModel();
                    }
 
                }
                model.Rounds.Add(currRound);
                prevRound = currRound;
                currRound = new List<MatchupModel>();
                round += 1;
            }
           
        }

        private static int findNumberOfByes(int rounds,int teamCount)
        {
           int output=0;
           int totalTeams = 1;
            //Math.Pow(2,rounds)
           for(int i=1; i<=rounds;i++)
           {
               totalTeams *= 2;
           }
           output = totalTeams - teamCount;
           return output;
        }

        private static int findNumberOfRounds(int teamCount)
        {
            int output = 1;
            int val = 2;
            while (teamCount > val)
            {
                output += 1;
                val *= 2;
            }
            return output;
        }

       

        private static List<TeamModel> RandomizeTeamOrder(List<TeamModel> teams)
        {
            return teams.OrderBy(a => Guid.NewGuid()).ToList();
        }

    }
}
