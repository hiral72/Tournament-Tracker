
Use [Tournaments]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
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
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
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


