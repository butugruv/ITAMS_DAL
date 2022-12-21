CREATE PROCEDURE [dbo].[spDeviceTypes_Update]
	@Id int,
	@TypeName nvarchar(50),
	@TypeDescription nvarchar(4000)
AS
BEGIN
	set nocount on;

	update Device_Types
	set TypeName = @TypeName,
		TypeDescription = @TypeDescription
	where Id = @Id;
END
