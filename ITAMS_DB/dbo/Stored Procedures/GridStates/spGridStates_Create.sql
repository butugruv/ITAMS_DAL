CREATE PROCEDURE [dbo].[spGridStates_Create]
	@SerializedState nvarchar(4000),
	@GridId int,
	@StateName nvarchar(50)
AS
BEGIN
	set nocount on;

	insert into GridStates (
		SerializedState,
		GridId,
		StateName
	)
	values (
		@SerializedState,
		@GridId,
		@StateName
	);
END