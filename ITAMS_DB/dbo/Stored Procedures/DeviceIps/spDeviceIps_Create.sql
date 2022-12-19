CREATE PROCEDURE [dbo].[spDeviceIps_Create]
	@DeviceId int,
	@IpAddress nvarchar(20),
	@MacAddress nvarchar(20)
AS
BEGIN
	set nocount on;

	insert into Device_IPs (
		DeviceId,
		IpAddress,
		MacAddress
	)
	values (
		@DeviceId,
		@IpAddress,
		@MacAddress
	);
END