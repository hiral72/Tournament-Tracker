using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Configuration;
using System.Threading.Tasks;
using TrackerLibrary.Models;


namespace TrackerLibrary.DataAccess.TextHelpers
{
    public static class textConnectorProcessor
    {
        public static string FullFilePath(this string fileName)//prizeModel.csv
        {
            string file = ConfigurationManager.AppSettings["filePath"] + "\\" + fileName;
            return file;
        }

        public static List<String> LoadFile(this string file)
        {
            if (File.Exists(file) == false)
            {
                return new List<string>();
            }
            return File.ReadAllLines(file).ToList();
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
                t.TeamId = int.Parse(cols[0]);
                t.TeamName = cols[1];
                string[] personIds = cols[2].Split('|');

                foreach (string id in personIds)
                {
                    t.TeamMembers.Add(
                        people.Where(x => x.PersonId == int.Parse(id)).First()
                    );
                }
                output.Add(t);
            }
            return output;
        }

        public static List<MatchupEntryModel> ConvertToMatchupEntryModels(this string input)
        {
            //teamcompeting,score, parent matchup
            //
            List<MatchupEntryModel> output = new List<MatchupEntryModel>();

            //foreach (string item in input)
            //{
            //    //1,Hiral warriors,1|3|2
            //    string[] cols = item.Split(',');
            //    MatchupEntryModel entry = new MatchupEntryModel();
            //    entry.Score = int.Parse(cols[0]);
            //    //entry.ParentMatchup = 
            //    //entry.TeamCompeting=
        
            //    output.Add(entry);
            //}
            return output;
        }

        public static List<MatchupModel> ConvertToMatchupModels(this List<string> lines)
        {
            //id,entries,winner, round
            //0,1|2|4, 2, 1
            List<MatchupModel> output = new List<MatchupModel>();
       
            foreach (string line in lines)
            {
                //1,Hiral warriors,1|3|2
                string[] cols = line.Split(',');
                MatchupModel mp = new MatchupModel();
                mp.MatchupId = int.Parse(cols[0]);
                string[] personIds = cols[2].Split('|');
               // mp.Entries = 
                int winnerteamID = int.Parse(cols[2]);
               // mp.Winner = 
                mp.MatchupRound = int.Parse(cols[3]);
                TeamModel t = new TeamModel();
                t.TeamId = int.Parse(cols[0]);
                t.TeamName = cols[1];
                output.Add(mp);
            }
            return output;
        }


        public static List<TournamentModel> ConvertToTournamentModels(this List<string> lines,
            string teamsFileName, string prizesFileName, string peopleFileName)
        {
            //TournamentId, TournamentName, EntryFee, (id|id|id- Entered teams),
            //(id|id|id- prizes), 
            //(Rounds- id^id^id|id^id^id|id^id^id) list of list of matchupmodel

            List<TournamentModel> output = new List<TournamentModel>();
            foreach (string line in lines)
            {
                string[] cols = line.Split(',');
                TournamentModel tm = new TournamentModel();
                List<TeamModel> teams = teamsFileName.FullFilePath().LoadFile().ConvertToTeamModels(peopleFileName);
                List<PrizeModel> prizes = prizesFileName.FullFilePath().LoadFile().ConvertToPrizeModels();
                tm.TournamentId = int.Parse(cols[0]);
                tm.TournamentName = cols[1];
                tm.EntryFee = decimal.Parse(cols[2]);
                string[] teamIds = cols[3].Split('|');
                foreach (string id in teamIds)
                {
                    tm.EnteredTeams.Add(
                        teams.Where(x => x.TeamId == int.Parse(id)).First()
                    );
                }

                string[] prizeIds = cols[4].Split('|');
                foreach (string id in prizeIds)
                {
                    tm.Prizes.Add(
                        prizes.Where(x => x.PrizeId == int.Parse(id)).First()
                    );
                }

                // TODO- capture rounds information
                output.Add(tm);

            }
            return output;
        }

       
        public static void SaveToPrizeFile(this List<PrizeModel> models, string fileName)
        {
            List<string> lines = new List<string>();
            foreach (PrizeModel p in models)
            {
                string newStr = p.PrizeId + "," + p.PlaceNumber + "," + p.PlaceName + "," + p.PrizeAmount + "," + p.PrizePercentage;

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
            string output = "";
            if (people.Count == 0)
            { return ""; }
            foreach (PersonModel p in people)
            {
                output = output + p.PersonId.ToString() + "|";
            }
            output = output.Substring(0, output.Length - 1);
            return output;
        }

        public static void SaveToTeamsFile(this List<TeamModel> models, string fileName)
        {
            List<string> lines = new List<string>();
            foreach (TeamModel t in models)
            {
                string newStr = t.TeamId + "," + t.TeamName + "," + ConvertPeopleListToString(t.TeamMembers);
                lines.Add(newStr);
            }
            File.WriteAllLines(fileName.FullFilePath(), lines);
        }
        public static void SaveToTournamentsFile(this List<TournamentModel> models, string fileName)
        {
            //TournamentId, TournamentName, EntryFee, (id|id|id- Entered teams),
            //(id|id|id- prizes), 
            //(Rounds- id^id^id|id^id^id|id^id^id) list of list of matchupmodel
            List<string> lines = new List<string>();
            foreach (TournamentModel tm in models)
            {
                string newStr = tm.TournamentId + "," + tm.TournamentName + "," + tm.EntryFee + "," + ConvertTeamsListToString(tm.EnteredTeams) + "," + ConvertPrizeListToString(tm.Prizes) + "," + ConvertRoundsListToString(tm.Rounds);
                lines.Add(newStr);

            }
            File.WriteAllLines(fileName.FullFilePath(), lines);
        }


        public static void SaveMatchupToFile(this MatchupModel matchup, string matchupFile,string matchupEntryFile)
        {
            List<MatchupModel> matchups = matchupFile.FullFilePath().LoadFile().ConvertToMatchupModels();
            foreach (MatchupEntryModel entry in matchup.Entries)
            {
                entry.SaveEntryToFile(matchupEntryFile);
            }
        }


        public static void SaveEntryToFile(this MatchupEntryModel entry, string matchupEntryFile)
        { 

        }

        public static void SaveRoundsToFile(this TournamentModel model, string matchupFile, string matchupEntryFile)
        {
            //List<List<MatchupModel>> rounds
            //List<MatchupEntryModel> Entries
            //loop through the rounds
            //loop through the matchups 
            //get is and save matchup
            //loop through each entires, get id and save them
            foreach (List<MatchupModel> round in model.Rounds)
            {
                foreach (MatchupModel matchup in round)
                {
                    matchup.SaveMatchupToFile(matchupFile,matchupEntryFile);
                    
                
                }
            }


        }

        private static string ConvertPrizeListToString(List<PrizeModel> prizes)
        {
            string output = "";
            if (prizes.Count == 0)
            { return ""; }
            foreach (PrizeModel p in prizes)
            {
                output = output + p.PrizeId.ToString() + "|";
            }
            output = output.Substring(0, output.Length - 1);
            return output;
        }

        private static string ConvertTeamsListToString(List<TeamModel> teams)
        {
            string output = "";
            if (teams.Count == 0)
            { return ""; }
            foreach (TeamModel p in teams)
            {
                output = output + p.TeamId.ToString() + "|";
            }
            output = output.Substring(0, output.Length - 1);
            return output;
        }

        private static string ConvertMatchupListsToString(List<MatchupModel> matchups)
        {
            string output = "";
            if (matchups.Count == 0)
            { return ""; }
            foreach (MatchupModel p in matchups)
            {
                output = output + p.ToString() + "^";
            }
            output = output.Substring(0, output.Length - 1);
            return output;

        }

        private static string ConvertRoundsListToString(List<List<MatchupModel>> rounds)
        {
            //(Rounds- id^id^id|id^id^id|id^id^id) list of list of matchupmodel
            string output = "";
            if (rounds.Count == 0)
            { return ""; }

            foreach (List<MatchupModel> matchups in rounds)
            {
                output = output + ConvertMatchupListsToString(matchups)+"|"; 
            }
            output = output.Substring(0, output.Length - 1);
            return output;
        }

         

        

    }
}
