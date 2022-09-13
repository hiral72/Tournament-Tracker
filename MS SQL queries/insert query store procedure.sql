
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