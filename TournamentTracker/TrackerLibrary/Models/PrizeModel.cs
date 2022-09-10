using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class PrizeModel
    {
        public int PrizeId { get; set; }
        public int PlaceNumber { get; set; }
        public string PlaceName { get; set; }
        public decimal PrizeAmount { get; set; }
        public double PrizePercentage { get; set; }

        public PrizeModel()
        {

        }

        public PrizeModel(string placeNumber, string placeName, string prizeAmt, string prizePercentage )
        {
            PlaceName = placeName;
            int PlaceNumberVal= 0;
            int.TryParse(placeNumber,out PlaceNumberVal);
            PlaceNumber=PlaceNumberVal;
            decimal prizeAmtVal = 0;
            double prizePercentageVal = 0;
            decimal.TryParse(prizeAmt, out prizeAmtVal);
            PrizeAmount = prizeAmtVal;
            double.TryParse(prizePercentage, out prizePercentageVal);
            PrizePercentage = prizePercentageVal;
            

        }
    }
}
