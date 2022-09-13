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

        public static List<TeamModel> ConvertToTeamModels(this List<string> lines, string peopleFileName)
        {
            List<TeamModel> output = new List<TeamModel>();
            List<PersonModel> people = peopleFileName.FullFilePath().LoadFile().ConvertToPersonModels();

            foreach (string line in lines)
            {
                //1,Hiral warriors,1|3|2
                string[] cols = line.Split(',');
                TeamModel t = new TeamModel();
                t.TeamId=int.Parse(cols[0]);     
                t.TeamName = cols[1];
                string[] personIds = cols[2].Split('|');

                foreach (string id in personIds)
                { 
                    t.TeamMembers.Add(
                        people.Where(x=>x.PersonId == int.Parse(id)).First()
                    );
                }
                output.Add(t);
            }
            return output;
        }

        public static List<PersonModel> ConvertToPersonModels(this List<string> lines)
        {
            List<PersonModel> output = new List<PersonModel>();
            foreach (string line in lines)
            {
                string[] cols = line.Split(',');
                PersonModel p = new PersonModel();
                p.PersonId = int.Parse(cols[0]);
                p.FirstName = cols[1];
                p.LastName = cols[2];
                p.EmailAddress = cols[3];
                p.PhoneNumber = cols[4];
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

        public static void SaveToPeopleFile(this List<PersonModel> models, string fileName)
        {
            List<string> lines = new List<string>();
            foreach (PersonModel p in models)
            {
                string newStr = p.PersonId + "," + p.FirstName + "," + p.LastName + "," + p.EmailAddress + "," + p.PhoneNumber;

                lines.Add(newStr);
            }
            File.WriteAllLines(fileName.FullFilePath(), lines);
        }

        private static string ConvertPeopleListToString(List<PersonModel> people)
        {
            string output="";
            if (people.Count == 0)
            { return ""; }
            foreach (PersonModel p in people)
            {
                output=output+ p.PersonId.ToString()+"|";
            }
            output = output.Substring(0, output.Length - 1);
            return output;
        }

        public static void SaveToTeamsFile(this List<TeamModel> models, string fileName)
        {
            List<string> lines = new List<string>();
            foreach (TeamModel t in models)
            {
                string newStr = t.TeamId + "," + t.TeamName+","+ ConvertPeopleListToString(t.TeamMembers);
                lines.Add(newStr);
            }
            File.WriteAllLines(fileName.FullFilePath(), lines);
        }

    }
}
