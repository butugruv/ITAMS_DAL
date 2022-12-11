CREATE PROCEDURE [dbo].[spDevicesWithLookups_GetAll]
AS
BEGIN
	select [Id], 
		[DeviceName], 
		[DeviceFunction], 
		[TypeName], 
		[Manufacturer], 
		[Poc], 
		[CreatedDate], 
		[CreatedBy], 
		[ModifiedDate], 
		[ModifiedBy], 
		[LocationName], 
		[Floor], 
		[Room], 
		[PackageName], 
		[Model],
		[NetworkName]
	from Devices_with_lookups_vw;
END