CREATE PROCEDURE [dbo].[spNetworks_Create]
	@NetworkName nvarchar(50),
	@Description nvarchar(4000)
AS
BEGIN
	set nocount on;

	insert into Networks (
		NetworkName,
		[Description]
	)
	values (
		@NetworkName,
		@Description
	);

END