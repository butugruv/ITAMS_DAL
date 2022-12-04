CREATE TABLE [dbo].[Device_IPs]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [device_id] INT NOT NULL, 
    [ip_address] NVARCHAR(20) NOT NULL, 
    [mac_address] NVARCHAR(20) NULL, 
    CONSTRAINT [FK_Device_IPs_Devices] FOREIGN KEY (device_id) REFERENCES Devices(Id)
)
