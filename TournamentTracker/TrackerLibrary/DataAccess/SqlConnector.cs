using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;
using Dapper;


namespace TrackerLibrary.DataAccess
{
    public class SqlConnector: IDataConnection
    {
        private const string db = "Tournaments";
       
        //saves a new prize to db and returns prize model with unique id
        public void CreatePrize(PrizeModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                var p = new DynamicParameters();
                p.Add("@Placenumber",model.PlaceNumber);
                p.Add("@PlaceName", model.PlaceName);
                p.Add("@PrizeAmount", model.PrizeAmount);
                p.Add("@PrizePercentage", model.PrizePercentage);
                p.Add("@PrizeId", dbType: DbType.Int32, direction: ParameterDirection.Output);
                connection.Execute("dbo.spPrizes_Insert", p, commandType: CommandType.StoredProcedure);
                model.PrizeId=p.Get<int>("@PrizeId");

            }
        }
        //saves a new prize to db and returns person model with unique id
        public void CreatePerson(PersonModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                var p = new DynamicParameters();
                p.Add("@FirstName", model.FirstName);
                p.Add("@LastName", model.LastName);
                p.Add("@EmailAddress", model.EmailAddress);
                p.Add("@PhoneNumber", model.PhoneNumber);
                p.Add("@PersonId", dbType: DbType.Int32, direction: ParameterDirection.Output);
                connection.Execute("dbo.spPeople_Insert", p, commandType: CommandType.StoredProcedure);
                model.PersonId=p.Get<int>("@PersonId");

            }
        }


         public List<PersonModel> GetPerson_All()
         {
             using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
             {
                 List<PersonModel> output;
                 output=connection.Query<PersonModel>("dbo.spPeople_GetAll").ToList();
                 return output;
             }
         }

         public List<TournamentModel> GetTournament_All()
         {
             using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
             {
                 List<TournamentModel> output;
                 output = connection.Query<TournamentModel>("dbo.spTournament_GetAll").ToList();
                 //populate prizes,teams, rounds
                 foreach(TournamentModel t in output)
                 {
                     var p = new DynamicParameters();
                     p.Add("@TournamentId", t.TournamentId);
                     t.Prizes = connection.Query<PrizeModel>("dbo.spPrizes_GetByTournament", p, commandType: CommandType.StoredProcedure).ToList();
                     t.EnteredTeams= connection.Query<TeamModel>("dbo.spTeams_GetByTournament", p, commandType: CommandType.StoredProcedure).ToList();
                     foreach (TeamModel team in t.EnteredTeams)
                     {
                        var q = new DynamicParameters();
                         q.Add("@TeamId", team.TeamId);
                         team.TeamMembers = connection.Query<PersonModel>("dbo.spTeamMembers_GetByTeam", q, commandType: CommandType.StoredProcedure).ToList();
                     }
                     List<MatchupModel> matchups= connection.Query<MatchupModel>("dbo.spMatchups_GetByTournament", p, commandType: CommandType.StoredProcedure).ToList();
                     foreach (MatchupModel matchup in matchups)
                     {
                         if(matchup.WinnerId>0)
                         {
                             matchup.Winner = t.EnteredTeams.Where(x => x.TeamId == matchup.WinnerId).First();
                         }
                        var r = new DynamicParameters();
                        r.Add("@MatchupId",matchup.MatchupId );
                        matchup.Entries = connection.Query<MatchupEntryModel>("dbo.spMatchupEntries_GetByMatchup", r, commandType: CommandType.StoredProcedure).ToList();
                        //populate each entry
                        foreach(MatchupEntryModel entry in matchup.Entries)
                        {
                            //populate teamcompeting
                            if (entry.TeamCompetingId > 0)
                            {
                                entry.TeamCompeting = t.EnteredTeams.Where(x => x.TeamId == entry.TeamCompetingId).First();
                            }
                            //populate parentmatchup
                            if (entry.ParentMatchupId > 0)
                            {
                                entry.ParentMatchup = matchups.Where(x => x.MatchupId == entry.ParentMatchupId).First();
                            }
                        }
                     }
                     
                     List<MatchupModel> currRound=new List<MatchupModel>();
                     int rn=1;
                     foreach (MatchupModel m in matchups)
                     {
                         if (m.MatchupRound > rn)
                         {
                             t.Rounds.Add(currRound);
                             currRound = new List<MatchupModel>();
                             rn += 1;
                         }                   
                         currRound.Add(m);
                     }
                     t.Rounds.Add(currRound);
                 }

                 return output;
             }
         }
         public List<TeamModel> GetTeam_All()
         {
             using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
             {
                 List<TeamModel> output;
                 output = connection.Query<TeamModel>("dbo.spTeam_GetAll").ToList();
                 foreach (TeamModel team in output)
                 {
                     var p = new DynamicParameters();
                     p.Add("@TeamId", team.TeamId);
                     team.TeamMembers = connection.Query<PersonModel>("dbo.spTeamMembers_GetByTeam", p, commandType: CommandType.StoredProcedure).ToList();

                 }
                 return output;
             }
         }


         public List<PrizeModel> GetPrize_All()
         {
             using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
             {
                 List<PrizeModel> output;
                 output = connection.Query<PrizeModel>("dbo.spPrize_GetAll").ToList();
                 return output;
             }

         }

         public void CreateTeam(TeamModel model)
         {
             using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
             {
                 var p = new DynamicParameters();
                 p.Add("@TeamName", model.TeamName);
                 p.Add("@TeamId", dbType: DbType.Int32, direction: ParameterDirection.Output);
                 connection.Execute("dbo.spTeams_Insert", p, commandType: CommandType.StoredProcedure);
                 model.TeamId = p.Get<int>("@TeamId");

                 foreach (PersonModel tm in model.TeamMembers)
                 {
                     p = new DynamicParameters();
                     p.Add("@TeamId", model.TeamId);
                     p.Add("@PersonId",tm.PersonId);
                     connection.Execute("dbo.spTeamMembers_Insert", p, commandType: CommandType.StoredProcedure);

                 }

             }
         }


        

        private void SaveTournament(IDbConnection connection,TournamentModel model)
        {
            var p = new DynamicParameters();
            p.Add("@TournamentName", model.TournamentName);
            p.Add("@EntryFee", model.EntryFee);
            p.Add("@TournamentId", dbType: DbType.Int32, direction: ParameterDirection.Output);
            connection.Execute("dbo.spTournaments_Insert", p, commandType: CommandType.StoredProcedure);
            model.TournamentId = p.Get<int>("@TournamentId");
        }

        private void SaveEnteredTeams(IDbConnection connection, TournamentModel model)
        {
            foreach (TeamModel tm in model.EnteredTeams)
            {
                var p = new DynamicParameters();
                p.Add("@TournamentId", model.TournamentId);
                p.Add("@TeamId", tm.TeamId);
                connection.Execute("dbo.spTournamentEntries_Insert", p, commandType: CommandType.StoredProcedure);
            }
        }

        private void SaveTournamentPrizes(IDbConnection connection, TournamentModel model)
        {
            foreach (PrizeModel tm in model.Prizes)
            {
                var p = new DynamicParameters();
                p.Add("@TournamentId", model.TournamentId);
                p.Add("@PrizeId", tm.PrizeId);
                connection.Execute("dbo.spTournamentPrizes_Insert", p, commandType: CommandType.StoredProcedure);
            }
        }
   
        private void SaveTournamentRounds(IDbConnection connection, TournamentModel model)
        {
            //List<List<MatchupModel>> rounds
            //List<MatchupEntryModel> Entries
            //loop through the rounds
            //loop through the matchups   
            foreach (List<MatchupModel> round in model.Rounds)
            {
                foreach (MatchupModel mp in round)
                {
                    //save matchup
                    //loop through entires and save them
                    var p = new DynamicParameters();
                    p.Add("@TournamentId", model.TournamentId);
                    p.Add("@MatchupRound", mp.MatchupRound);
                    p.Add("@MatchupId", dbType: DbType.Int32, direction: ParameterDirection.Output);
                    connection.Execute("dbo.spMatchups_Insert", p, commandType: CommandType.StoredProcedure);
                    mp.MatchupId = p.Get<int>("@MatchupId");
                    foreach (MatchupEntryModel entry in mp.Entries)
                    {
                        p = new DynamicParameters();
                        p.Add("@MatchupId",mp.MatchupId );
                        p.Add("@MatchupEntryId", dbType: DbType.Int32, direction: ParameterDirection.Output);
                        
                        if (entry.TeamCompeting == null)
                        {
                            entry.ParentMatchupId = entry.ParentMatchup.MatchupId;
                            p.Add("@TeamCompetitingId", null);
                            p.Add("@ParentMatchupId", entry.ParentMatchup.MatchupId);
                        }
                        else{
                            //round1
                            p.Add("@TeamCompetitingId",entry.TeamCompeting.TeamId );
                            p.Add("@ParentMatchupId", null);
                        }
                        
                        connection.Execute("dbo.spMatchupEntries_Insert", p, commandType: CommandType.StoredProcedure);
                        entry.MatchupEntryId = p.Get<int>("@MatchupEntryId");
                    }
                }
            }
        }
        public void CreateTournament(TournamentModel model)
         {
              using(IDbConnection connection=new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
              {
                  SaveTournament(connection,model);
                  SaveEnteredTeams(connection, model);
                  SaveTournamentPrizes(connection, model);
                  SaveTournamentRounds(connection, model);
              }

        }

         public void UpdateMatchup(MatchupModel model)
         {
             using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
             {
                 var p = new DynamicParameters();
                 p.Add("@MatchupId", model.MatchupId);
                 if (model.Winner!= null)
                 {
                     p.Add("@WinnerId", model.WinnerId);
                     connection.Execute("dbo.spMatchups_Update", p, commandType: CommandType.StoredProcedure);
                 }
                // matchupentries update
                 foreach (MatchupEntryModel me in model.Entries)
                 {
                     p = new DynamicParameters();
                     if (me.TeamCompeting != null)
                     {
                         p.Add("@MatchupEntryId", me.MatchupEntryId);
                         p.Add("@TeamCompetingId", me.TeamCompeting.TeamId);
                         p.Add("@Score", me.Score);
                         connection.Execute("dbo.spMatchupEntries_Update", p, commandType: CommandType.StoredProcedure);
                     }  
                 }
             }
             
         }
    }
}
