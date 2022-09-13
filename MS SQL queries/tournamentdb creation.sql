
use tempor;
Drop database Tournaments;
Create database Tournaments;
Use Tournaments;

Create Table Tournaments (
 TournamentId int identity(1,1) PRIMARY KEY,
 TournamentName varchar(50) NOT NULL,
 EntryFee money NOT NULL,
 DateCreated datetime2 NOT NULL default (getDate())
);


Create Table Teams (
 TeamId int identity(1,1) PRIMARY KEY,
 TeamName varchar(50) NOT NULL,
 DateCreated datetime2 NOT NULL default (getDate())
);


Create Table TournamentEntries(
TournamentEntryId int identity(1,1) PRIMARY KEY,
TournamentId int FOREIGN KEY references Tournaments(TournamentId) ,
TeamId int FOREIGN KEY references Teams(TeamId),
);

Create Table People(
PersonId int identity(1,1) PRIMARY KEY,
FirstName varchar(50) NOT NULL,
LastName varchar(50) NOT NULL,
Email varchar(50) NOT NULL,
PhoneNo varchar(50) NOT NULL,
DateCreated datetime2 NOT NULL default (getDate())
);



Create Table TeamMembers(
TeamMemberId int identity(1,1) PRIMARY KEY,
TeamId int FOREIGN KEY references Teams(TeamId) ,
PersonId int FOREIGN KEY references People(PersonId)  ,
);


Create Table Prizes(
PrizeId int identity(1,1) PRIMARY KEY,
PlaceNumber int NOT NULL,
PlaceName varchar(50) NOT NULL,
PrizeAmount money NOT NULL,
PrizePercentage float NOT NULL,
CreateDate datetime2 NOT NULL default (getDate())
);

Create Table TournamentPrizes(
TournamentPrizeId int identity(1,1) PRIMARY KEY,
TournamentId int FOREIGN KEY references Tournaments(TournamentId) ,
PrizeId int FOREIGN KEY references Prizes(PrizeId)  ,
DateCreated datetime2 NOT NULL default (getDate())
);


Create Table Matchups(
MatchUpId int identity(1,1) PRIMARY KEY,
WinnerId int FOREIGN KEY references Teams(TeamId) ,
MatchUpRound int NOT NULL,
DateCreated datetime2 NOT NULL default (getDate())
);


Create Table MatchupEntries(
MatchUpEntryId int identity(1,1) PRIMARY KEY,
ParentMatchUpId int FOREIGN KEY references MatchUps(MatchUpId),
TeamCompetingId int FOREIGN KEY references Teams(TeamId),
Score int NOT NULL,
DateCreated datetime2 NOT NULL default (getDate())
);









