CREATE PROCEDURE [dbo].[spDeviceTypes_Create]
	@TypeName nvarchar(50),
	@TypeDescription nvarchar(4000)
AS
BEGIN
	set nocount on;

	insert into Device_Types (
		TypeName,
		TypeDescription
	)
	values (
		@TypeName,
		@TypeDescription
	);
END
