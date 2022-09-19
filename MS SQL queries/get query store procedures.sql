Use [Tournaments]
GO
CREATE PROCEDURE spTeam_GetAll
AS
BEGIN
	SET NOCOUNT ON;
	Select * from Teams 
END
GO

Use [Tournaments]
GO
CREATE PROCEDURE spPrize_GetAll
AS
BEGIN
	SET NOCOUNT ON;
	Select * from Prizes 
END
GO

Use [Tournaments]
GO
CREATE PROCEDURE spTournament_GetAll
AS
BEGIN
	SET NOCOUNT ON;
	Select * from Tournaments order by DateCreated desc
END
GO


Use [Tournaments]
GO
CREATE PROCEDURE spTeamMembers_GetByTeam
	@TeamId int
AS
BEGIN
	SET NOCOUNT ON;
	Select p.* from dbo.TeamMembers m
	inner join dbo.People p
	on m.PersonId=p.PersonId
	where m.TeamId=@TeamId
END
GO


Use [Tournaments]
GO
CREATE PROCEDURE spPrizes_GetByTournament
	@TournamentId int
AS
BEGIN
	SET NOCOUNT ON;
	Select p.* 
	from dbo.Prizes p
	inner join dbo.TournamentPrizes t
	on p.PrizeId= t.PrizeId
	where t.TournamentId= @TournamentId
	
END
GO


Use [Tournaments]
GO
CREATE PROCEDURE spTeams_GetByTournament
	@TournamentId int
AS
BEGIN
	SET NOCOUNT ON;
	Select t.*
	from dbo.Teams t
	inner join dbo.TournamentEntries e
	on t.TeamId=e.TeamId
	where e.TournamentId= @TournamentId
	
END
GO

Drop procedure spMatchups_GetByTournament
Use [Tournaments]
GO
CREATE PROCEDURE spMatchups_GetByTournament
	@TournamentId int
AS
BEGIN
	SET NOCOUNT ON;
	Select m.*
	from Matchups m
	where m.TournamentId= @TournamentId
	order by MatchupRound
	
END



Use [Tournaments]
GO
CREATE PROCEDURE spMatchupEntries_GetByMatchup
	@MatchupId int
AS
BEGIN
	SET NOCOUNT ON;
	Select * from
	MatchupEntries m
	where m.MatchupId= @MatchupId
END
GO


