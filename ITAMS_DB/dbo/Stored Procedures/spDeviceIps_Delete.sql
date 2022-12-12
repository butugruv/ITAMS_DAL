CREATE PROCEDURE [dbo].[spDeviceIps_Delete]
	@Id int
AS
BEGIN
	delete from Devices
	where Id = @id;
END
