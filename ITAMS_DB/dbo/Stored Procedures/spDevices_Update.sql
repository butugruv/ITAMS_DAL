CREATE PROCEDURE [dbo].[spDevices_Update]
	@Id int = 0,
	@DeviceName nvarchar(50),
	@DeviceFunction nvarchar(4000),
	@DeviceTypeId int,
	@ManufacturerId int,
	@Poc nvarchar(50),
	@CreatedDate datetime2(7),
	@CreatedBy nvarchar(50),
	@ModifiedDate datetime2(7),
	@ModifiedBy nvarchar(50),
	@LocationId int,
	@LocationFloorId int,
	@LocationFloorRoomId int,
	@RmfPackageId int,
	@Model nvarchar(50)
AS
BEGIN
	set nocount on;

	update Devices
	set DeviceName = @DeviceName,
		DeviceFunction = @DeviceFunction,
		DeviceTypeId = @DeviceTypeId,
		ManufacturerId = @ManufacturerId,
		Poc = @Poc,
		CreatedDate = @CreatedDate,
		CreatedBy = @CreatedBy,
		ModifiedDate = @ModifiedDate,
		ModifiedBy = @ModifiedBy,
		LocationId = @LocationId,
		LocationFloorId = @LocationFloorId,
		LocationFloorRoomId = @LocationFloorRoomId,
		RmfPackageId = @RmfPackageId,
		Model = @Model
	where Id = @Id;
END