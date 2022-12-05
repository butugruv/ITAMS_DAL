CREATE PROCEDURE [dbo].[spDevices_GetAll]
AS
BEGIN
	set nocount on;

	select [Id], 
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
		[Model]
	from Devices;
END