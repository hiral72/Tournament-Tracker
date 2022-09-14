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
CREATE PROCEDURE spMatchupEntries_GetByMatchup
	@MatchupId int
AS
BEGIN
	SET NOCOUNT ON;
	Select * from
	MatchupEntries m
	where m.ParentMatchUpId= @MatchupId
END
GO


