CREATE PROCEDURE [dbo].[spDevices_GetById]
	@Id int
AS
BEGIN
	SELECT [Id], 
		[DeviceName], 
		[DeviceFunction], 
		[DeviceTypeId], 
		[ManufacturerId], 
		[Poc], 
		[CreatedDate], 
		[CreatedBy], 
		[ModifiedDate], 
		[ModifiedBy], 
		[LocationId], 
		[LocationFloorId], 
		[LocationFloorRoomId], 
		[RmfPackageId], 
		[Model],
		[NetworkId]
	from Devices
	where Id = @Id;
END