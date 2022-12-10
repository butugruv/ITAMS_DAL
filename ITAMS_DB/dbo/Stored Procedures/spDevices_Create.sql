CREATE PROCEDURE [dbo].[spDevices_Create]
	@DeviceName nvarchar(50),
	@DeviceFunction nvarchar(4000),
	@DeviceTypeId int,
	@ManufacturerId int,
	@Poc nvarchar(50),
	@LocationId int,
	@LocationFloorId int,
	@LocationFloorRoomId int,
	@RmfPackageId int,
	@Model nvarchar(50)
AS
BEGIN
	set nocount on;

	insert into Devices (
		DeviceName,
		DeviceFunction,
		DeviceTypeId,
		ManufacturerId,
		Poc,
		LocationId,
		LocationFloorId,
		LocationFloorRoomId,
		RmfPackageId,
		Model
	)
	values (
		@DeviceName,
		@DeviceFunction,
		@DeviceTypeId,
		@ManufacturerId,
		@Poc,
		@LocationId,
		@LocationFloorId,
		@LocationFloorRoomId,
		@RmfPackageId,
		@Model
	);
END