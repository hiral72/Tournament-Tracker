
Use [Tournaments]
GO
CREATE PROCEDURE spPrizes_Insert
@Placenumber int,
@PlaceName varchar(50),
@PrizeAmount money,
@PrizePercentage float,
@PrizeId int=0 output
AS
BEGIN
	SET NOCOUNT ON;
	Insert into dbo.Prizes(PlaceName,PlaceNumber,PrizeAmount,PrizePercentage)
	values (@PlaceName,@Placenumber,@PrizeAmount,@PrizePercentage)

	Select @PrizeId=SCOPE_IDENTITY();
END
GO


select * from Prizes


Drop  Procedure spPeople_insert;
Use [Tournaments]
GO
CREATE PROCEDURE spPeople_Insert
@FirstName varchar(50),
@LastName varchar(50),
@EmailAddress varchar(50),
@PhoneNumber varchar(50),
@PersonId int=0 output
AS
BEGIN
	SET NOCOUNT ON;
	Insert into dbo.People(FirstName,LastName,Email,PhoneNo)
	values (@FirstName,@LastName,@EmailAddress,@PhoneNumber)

	Select @PersonId=SCOPE_IDENTITY();
END
GO


select * from People

Use [Tournaments]
GO
CREATE PROCEDURE spTeamMembers_Insert
@TeamId int,
@PersonId int,
@TeamMemberId int=0 output 
AS
BEGIN
	Insert into dbo.TeamMembers(TeamId,PersonId)
	values (@TeamId,@PersonId)
	Select @TeamMemberId=SCOPE_IDENTITY();
END
GO
select * from TeamMembers;

Use [Tournaments]
GO
CREATE PROCEDURE spTeams_Insert
@TeamName varchar(50),
@TeamId int=0 output
AS
BEGIN
	SET NOCOUNT ON;
	Insert into dbo.Teams(TeamName)
	values (@TeamName)
	Select @TeamId=SCOPE_IDENTITY();
END
GO

select * from Teams;

Use [Tournaments]
GO
CREATE PROCEDURE spTournaments_Insert
@TournamentName varchar(50),
@EntryFee money,
@TournamentId int=0 output
AS
BEGIN
	SET NOCOUNT ON;
	Insert into dbo.Tournaments(TournamentName,EntryFee,Active)
	values(@TournamentName,@EntryFee,1)
	Select @TournamentId=SCOPE_IDENTITY();
END
GO

Use [Tournaments]
GO
CREATE PROCEDURE spTournamentEntries_Insert
@TournamentId int ,
@TeamId int
AS
BEGIN
	SET NOCOUNT ON;
	Insert into dbo.TournamentEntries(TournamentId,TeamId)
	values(@TournamentId,@TeamId)
END
GO


Use [Tournaments]
GO
CREATE PROCEDURE spTournamentPrizes_Insert
@TournamentId int ,
@PrizeId int
AS
BEGIN
	SET NOCOUNT ON;
	Insert into dbo.TournamentPrizes(TournamentId,PrizeId)
	values(@TournamentId,@PrizeId)
END
GO

Use [Tournaments]
GO
CREATE PROCEDURE dbo.spMatchups_Insert
@TournamentId int ,
@MatchupRound int ,
@MatchupId int=0 output
AS
BEGIN
	SET NOCOUNT ON;
	Insert into dbo.Matchups(TournamentId,MatchupRound)
	values(@TournamentId,@MatchupRound)
	Select @MatchupId=SCOPE_IDENTITY();
END
GO

Use [Tournaments]
GO
CREATE PROCEDURE dbo.spMatchupEntries_Insert
@MatchupId int ,
@ParentMatchupId int,
@TeamCompetitingId int
AS
BEGIN
	SET NOCOUNT ON;
	Insert into dbo.MatchupEntries(MatchupId,ParentMatchupId,TeamCompetingId)
	values (@MatchupId,@ParentMatchupId,@TeamCompetitingId)
END
GO

select * from Matchups
Select * from MatchupEntries

