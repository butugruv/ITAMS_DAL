CREATE PROCEDURE [dbo].[spLocationFloors_GetLocationFloors]
	@LocationId int
AS
BEGIN
	set nocount on;

	select [Id],  
		[Floor]
	from Location_Floors
	where LocationId = @LocationId;
END