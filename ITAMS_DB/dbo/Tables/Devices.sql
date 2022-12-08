CREATE TABLE [dbo].[Devices]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [DeviceName] NVARCHAR(50) NOT NULL, 
    [DeviceFunction] NVARCHAR(4000) NOT NULL, 
    [DeviceTypeId] INT NOT NULL, 
    [ManufacturerId] INT NULL, 
    [Poc] NVARCHAR(50) NOT NULL, 
    [CreatedDate] DATETIME2 NOT NULL, 
    [CreatedBy] NVARCHAR(50) NOT NULL, 
    [ModifiedDate] DATETIME2 NULL, 
    [ModifiedBy] NVARCHAR(50) NULL, 
    [LocationId] INT NULL, 
    [LocationFloorId] INT NULL, 
    [LocationFloorRoomId] INT NULL, 
    [RmfPackageId] INT NULL, 
    [Model] NVARCHAR(50) NULL, 
    CONSTRAINT [FK_Devices_Device_Types] FOREIGN KEY ([DeviceTypeId]) REFERENCES Device_Types(Id), 
    CONSTRAINT [FK_Devices_Manufacturers] FOREIGN KEY ([ManufacturerId]) REFERENCES Manufacturers(Id), 
    CONSTRAINT [FK_Devices_Locations] FOREIGN KEY ([LocationId]) REFERENCES Locations(Id), 
    CONSTRAINT [FK_Devices_Location_Floors] FOREIGN KEY ([LocationFloorId]) REFERENCES Location_Floors(Id), 
    CONSTRAINT [FK_Devices_Location_Floor_Rooms] FOREIGN KEY ([LocationFloorRoomId]) REFERENCES Location_Floor_Rooms(Id)
)
