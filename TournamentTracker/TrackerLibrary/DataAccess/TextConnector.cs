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
        private const string PeopleFile = "PeopleModels.csv";
        private const string TeamsFile = "TeamModels.csv";
        private const string TournamentsFile = "TournamentModels.csv";
        private const string MatchupFile = "MatchupModels.csv";
        private const string MatchupEntryFile = "MatchupEntryModels.csv";

      

        // TODO - Wire up createPrize for text file
        //saves a new prize to db and returns prize ingo and unique id
        public void CreatePrize(PrizeModel model)
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

        }

        public void CreatePerson(PersonModel model)
        {
            //Load text file
            //convert txt list List<personmodel>
            List<PersonModel> people = PeopleFile.FullFilePath().LoadFile().ConvertToPersonModels();
            //find highest id
            int currentId = 1;
            if (people.Count > 0)
            {
                currentId = people.OrderByDescending(x => x.PersonId).First().PersonId + 1;
            }
            model.PersonId = currentId;
            people.Add(model);
            //convert persons to list <string>
            // save list<string> to text file
            people.SaveToPeopleFile(PeopleFile);
    
        }




        public List<PersonModel> GetPerson_All()
        {
            return PeopleFile.FullFilePath().LoadFile().ConvertToPersonModels();
        }


        public void CreateTeam(TeamModel model)
        {
            //Load text file
            //convert txt list List<teammodel>
            List<TeamModel> teams = TeamsFile.FullFilePath().LoadFile().ConvertToTeamModels(PeopleFile);
            //find highest id
            int currentId = 1;
            if (teams.Count > 0)
            {
                currentId = teams.OrderByDescending(x => x.TeamId).First().TeamId + 1;
            }
            model.TeamId = currentId;
            teams.Add(model);
            //convert persons to list <string>
            // save list<string> to text file
            teams.SaveToTeamsFile(TeamsFile);

        }


        public List<TeamModel> GetTeam_All()
        {
            return TeamsFile.FullFilePath().LoadFile().ConvertToTeamModels(PeopleFile);

        }

        public List<PrizeModel> GetPrize_All()
        {
            return PrizesFile.FullFilePath().LoadFile().ConvertToPrizeModels();

        }


        public void CreateTournament(TournamentModel model)
        {
            List<TournamentModel> tournaments = TournamentsFile.FullFilePath().LoadFile().ConvertToTournamentModels(TeamsFile,PrizesFile,PeopleFile);
            int currentId = 1;
            if (tournaments.Count > 0)
            {
                currentId = tournaments.OrderByDescending(x => x.TournamentId).First().TournamentId+ 1;
            }
            model.TournamentId = currentId;
            model.SaveRoundsToFile(MatchupFile, MatchupEntryFile);
            tournaments.Add(model);
            tournaments.SaveToTournamentsFile(TournamentsFile);

            
        }


        public List<TournamentModel> GetTournament_All()
        {
            return TournamentsFile.FullFilePath().LoadFile().ConvertToTournamentModels(TeamsFile, PrizesFile, PeopleFile);
        }


        public void UpdateMatchup(MatchupModel model)
        {
            throw new NotImplementedException();
        }
    }
}
