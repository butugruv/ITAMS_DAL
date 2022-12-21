CREATE PROCEDURE [dbo].[spDeviceTypes_Delete]
	@Id int
AS
BEGIN
	delete from Device_Types
	where Id = @Id;
END