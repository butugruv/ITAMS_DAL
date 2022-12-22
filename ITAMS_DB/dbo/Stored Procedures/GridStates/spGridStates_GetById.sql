CREATE PROCEDURE [dbo].[spGridStates_GetById]
	@Id int
AS
BEGIN
	select [Id], 
		[SerializedState], 
		[GridId], 
		[StateName]
	from GridStates
	where Id = @Id;
END