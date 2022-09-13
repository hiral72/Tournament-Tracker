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
        public PrizeModel CreatePrize(PrizeModel model)
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
                return model;
            }
        }
        //saves a new prize to db and returns person model with unique id
         public PersonModel CreatePerson(PersonModel model)
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
                return model;
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


         public TeamModel CreateTeam(TeamModel model)
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

                 return model;
             }
         }
    }
}
