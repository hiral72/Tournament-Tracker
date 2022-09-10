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
        // TODO - Wire up createPrize for sql file
        //saves a new prize to db and returns prize ingo and unique id
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
                model.PrizeId=p.Get<int>("@id");
                return model;
            }
        }
    }
}
