using System;
using System.Collections.Generic;
using System.Configuration;
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
        public static void UpdateTournamentResults(TournamentModel model)
        {
            List<MatchupModel> toScore= new List<MatchupModel>();
            foreach (List<MatchupModel> round in model.Rounds)
            {
                foreach (MatchupModel rm in round)
                {
                    if (rm.Winner==null && (rm.Entries.Any(x => x.Score != 0) || rm.Entries.Count == 1))
                    {
                        toScore.Add(rm);
                    }
                }
            }
            ScoreMatchups(toScore);
            AdvanceWinners(toScore,model);
            toScore.ForEach(x => GlobalConfig.Connections.UpdateMatchup(x));
        }
        private static void AdvanceWinners(List<MatchupModel> models,TournamentModel model)
        {

            foreach (MatchupModel m in models)
            {
                foreach (List<MatchupModel> round in model.Rounds)
                {
                    foreach (MatchupModel rm in round)
                    {
                        foreach (MatchupEntryModel me in rm.Entries)
                        {
                            if (me.ParentMatchup != null)
                            {
                                if (me.ParentMatchupId == m.MatchupId)
                                {
                                    me.TeamCompeting = m.Winner;
                                    me.TeamCompetingId = m.WinnerId;
                                    GlobalConfig.Connections.UpdateMatchup(rm);
                                }
                            }
                        }
                    }
                } 
            }
        }


        private static void ScoreMatchups(List<MatchupModel> models)
        {
            //greater or lesser
           string greaterWins=ConfigurationManager.AppSettings["greaterWins"];

           foreach (MatchupModel m in models)
           {
               //check for bye week entry
               if (m.Entries.Count == 1)
               {
                   m.Winner = m.Entries[0].TeamCompeting;
                   m.WinnerId = m.Winner.TeamId;
                   continue;
               }
               //0 means false or low score wins
               if (greaterWins == "0")
               {
                   if (m.Entries[0].Score < m.Entries[1].Score)
                   {
                       //Team one wins
                       m.Winner = m.Entries[0].TeamCompeting;
                       m.WinnerId = m.Winner.TeamId;
                   }
                   else if (m.Entries[0].Score > m.Entries[1].Score)
                   {
                       //Team two wins
                       m.Winner = m.Entries[1].TeamCompeting;
                       m.WinnerId = m.Winner.TeamId;
                   }
                   else
                   {
                       throw new Exception("We don't allow ties in this application");
                   }
               }
               else
               {
                   //1 means true, or high score wins
                   if (m.Entries[0].Score > m.Entries[1].Score)
                   {
                       //Team one wins
                       m.Winner = m.Entries[0].TeamCompeting;
                       m.WinnerId = m.Winner.TeamId;
                   }
                   else if (m.Entries[0].Score < m.Entries[1].Score)
                   {
                       //Team two wins
                       m.Winner = m.Entries[1].TeamCompeting;
                       m.WinnerId = m.Winner.TeamId;
                   }
                   else
                   {
                       throw new Exception("We don't allow ties in this application");
                   }
               }  
           }  
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
                    currMatchUp.Entries.Add(new MatchupEntryModel { ParentMatchup = match,ParentMatchupId=match.MatchupId });
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
