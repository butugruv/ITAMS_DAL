CREATE PROCEDURE [dbo].[spLocations_Create]
	@LocationName nvarchar(50),
	@Description nvarchar(4000)
AS
BEGIN
	set nocount on;

	insert into Locations (
		LocationName,
		[Description]
	)
	values (
		@LocationName,
		@Description
	);
END