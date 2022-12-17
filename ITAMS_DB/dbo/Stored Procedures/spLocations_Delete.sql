CREATE PROCEDURE [dbo].[spLocations_Delete]
	@Id int
AS
BEGIN
	delete from Locations
	where Id = @Id;
END