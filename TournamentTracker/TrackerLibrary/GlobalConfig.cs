using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.DataAccess;

namespace TrackerLibrary
{
    public static class GlobalConfig
    {
        public static IDataConnection Connections { get; private set; }
   
        public static void IntializeConnections(DatabaseType dbType)
        {

            switch (dbType)
            {
                case DatabaseType.Sql:
                    // TODO -create sql connection
                    SqlConnector sql = new SqlConnector();
                    Connections = sql;
                    break;
                case DatabaseType.TextFile:
                    // TODO - create text connection
                    TextConnector text = new TextConnector();
                    Connections = text;
                    break;
                default:
                    break;
            }
    
         
        }
        public static string CnnString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
