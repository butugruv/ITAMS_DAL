CREATE PROCEDURE [dbo].[spLocations_GetAll]
AS
BEGIN
	set nocount on;
	
	select [Id],
		[LocationName], 
		[Description]
	from Locations;
END