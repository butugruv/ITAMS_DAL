CREATE PROCEDURE [dbo].[spDeviceIps_Update]
	@Id int,
	@deviceId int,
	@IpAddress nvarchar(20),
	@MacAddress nvarchar(20)
AS
BEGIN
	set nocount on;

	update Device_IPs
	set DeviceId = @deviceId,
		IpAddress = @IpAddress,
		MacAddress = @MacAddress
	where Id = @Id;
END