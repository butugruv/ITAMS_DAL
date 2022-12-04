CREATE TABLE [dbo].[Devices]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [device_name] NVARCHAR(50) NOT NULL, 
    [device_function] NVARCHAR(4000) NOT NULL, 
    [device_type_id] INT NOT NULL, 
    [manufacturer_id] INT NULL, 
    [poc_tx] NCHAR(10) NOT NULL, 
    [created_dt] DATETIME2 NOT NULL, 
    [created_by] NVARCHAR(50) NOT NULL, 
    [modified_dt] DATETIME2 NULL, 
    [modified_by] NVARCHAR(50) NULL, 
    [location_id] INT NULL, 
    [location_floor_id] INT NULL, 
    [location_floor_room_id] INT NULL, 
    [rmf_package_id] INT NULL, 
    [model] NVARCHAR(50) NULL, 
    CONSTRAINT [FK_Devices_Device_Types] FOREIGN KEY (device_type_id) REFERENCES Device_Types(Id), 
    CONSTRAINT [FK_Devices_Manufacturers] FOREIGN KEY (manufacturer_id) REFERENCES Manufacturers(Id), 
    CONSTRAINT [FK_Devices_Locations] FOREIGN KEY (location_id) REFERENCES Locations(Id), 
    CONSTRAINT [FK_Devices_Location_Floors] FOREIGN KEY (location_floor_id) REFERENCES Location_Floors(Id), 
    CONSTRAINT [FK_Devices_Location_Floor_Rooms] FOREIGN KEY (location_floor_room_id) REFERENCES Location_Floor_Rooms(Id)
)
