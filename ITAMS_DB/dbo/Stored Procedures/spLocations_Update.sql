CREATE PROCEDURE [dbo].[spLocations_Update]
	@Id int,
	@LocationName nvarchar(50),
	@Description nvarchar(4000)
AS
BEGIN
	set nocount on;

	update Locations
	set LocationName = @LocationName,
		[Description] = @Description
	where Id = @Id;
END