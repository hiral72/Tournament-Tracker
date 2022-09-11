using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Configuration;
using System.Threading.Tasks;
using TrackerLibrary.Models;

//Load text file
//convert txt lisi List<prizemodel>
//find highest id
//convert prizes to list <string>
// save list<string> to text file

namespace TrackerLibrary.DataAccess.TextHelpers
{
    public static class textConnectorProcessor
    {
        public static string FullFilePath(this string fileName)//prizeModel.csv
        {
            string file = ConfigurationManager.AppSettings["filePath"]+"\\"+fileName;
            return file;
        }

        public static List<String> LoadFile(this string file)
        {
            if (File.Exists(file)==false)
            { 
                return new List<string>();
            }
            return File.ReadAllLines(file).ToList();
        }

        public static List<PrizeModel> ConvertToPrizeModels(this List<string> lines)
        {
            List<PrizeModel> output = new List<PrizeModel>();
            foreach (string line in lines)
            {
                string[] cols = line.Split(',');
                PrizeModel p = new PrizeModel();
                p.PrizeId = int.Parse(cols[0]);
                p.PlaceNumber = int.Parse(cols[1]);
                p.PlaceName = cols[2];
                p.PrizeAmount = decimal.Parse(cols[3]);
                p.PrizePercentage = float.Parse(cols[4]);
                output.Add(p);
            }
            return output;

        }

        public static void SaveToPrizeFile(this List<PrizeModel> models, string fileName)
        {
            List<string> lines = new List<string>();
            foreach (PrizeModel p in models)
            {
                string newStr= p.PrizeId +","+ p.PlaceNumber+","+p.PlaceName+","+p.PrizeAmount+","+p.PrizePercentage;
 
                lines.Add(newStr);
            }
            File.WriteAllLines(fileName.FullFilePath(), lines);
        }
    }
}
