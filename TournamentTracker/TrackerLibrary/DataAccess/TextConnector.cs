using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;
using TrackerLibrary.DataAccess.TextHelpers;


namespace TrackerLibrary.DataAccess
{
    public class TextConnector : IDataConnection
    {
        private const string PrizesFile = "PrizeModels.csv";
        // TODO - Wire up createPrize for text file
        //saves a new prize to db and returns prize ingo and unique id
        public PrizeModel CreatePrize(PrizeModel model)
        {
            //Load text file
            //convert txt list List<prizemodel>
            List<PrizeModel> prizes=PrizesFile.FullFilePath().LoadFile().ConvertToPrizeModels();
            //find highest id
            int currentId = 1;
            if (prizes.Count > 0)
            {
                currentId = prizes.OrderByDescending(x => x.PrizeId).First().PrizeId + 1;    
            }
            model.PrizeId = currentId;
            prizes.Add(model);
            //convert prizes to list <string>
            // save list<string> to text file
            prizes.SaveToPrizeFile(PrizesFile);
            return model;
        }
    }
}
