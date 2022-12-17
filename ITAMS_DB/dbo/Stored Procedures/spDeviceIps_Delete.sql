CREATE PROCEDURE [dbo].[spDeviceIps_Delete]
	@Id int
AS
BEGIN
	delete from Device_IPs
	where Id = @Id;
END
