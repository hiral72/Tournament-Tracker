using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class TextConnector : IDataConnection
    {
        // TODO - Wire up createPrize for text file
        //saves a new prize to db and returns prize ingo and unique id
        public PrizeModel CreatePrize(PrizeModel model)
        {
            model.PrizeId = 1;
            return model;
        }
    }
}
