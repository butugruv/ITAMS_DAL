CREATE PROCEDURE [dbo].[spGridStates_GetAll]
AS
BEGIN
	set nocount on;

	select [Id], 
		[SerializedState], 
		[GridId], 
		[StateName]
	from GridStates;
END