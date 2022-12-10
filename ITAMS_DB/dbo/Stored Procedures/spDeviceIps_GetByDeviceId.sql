CREATE PROCEDURE [dbo].[spDeviceIps_GetByDeviceId]
	@deviceId int
AS
BEGIN
	select [Id],
		[DeviceId],
		[IpAddress], 
		[MacAddress]
	from Device_IPs
	where DeviceId = @deviceId;
END