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
       
        //saves a new prize to db and returns prize model with unique id
        public PrizeModel CreatePrize(PrizeModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("Tournaments")))
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
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("Tournaments")))
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
    }
}
