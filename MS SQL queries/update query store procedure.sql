
Drop procedure dbo.spMatchups_Update
Use [Tournaments]
GO
CREATE PROCEDURE dbo.spMatchups_Update
@MatchupId int ,
@WinnerId int =null
AS
BEGIN
	SET NOCOUNT ON;
	Update dbo.Matchups
	set WinnerId=@WinnerId
	where MatchupId=@MatchupId
END

drop procedure  dbo.spMatchupEntries_Update

Use [Tournaments]
GO
CREATE PROCEDURE dbo.spMatchupEntries_Update
@MatchupEntryId int ,
@Score float=null,
@TeamCompetingId int=null
AS
BEGIN
	Update dbo.MatchupEntries
	set Score=@Score, TeamCompetingId= @TeamCompetingId
	where MatchupEntryId=@MatchupEntryId
END
GO

select * from Matchups
Select * from MatchupEntries
