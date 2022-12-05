CREATE TABLE [dbo].[Device_IPs]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [DeviceId] INT NOT NULL, 
    [IpAddress] NVARCHAR(20) NOT NULL, 
    [MacAddress] NVARCHAR(20) NULL, 
    CONSTRAINT [FK_Device_IPs_Devices] FOREIGN KEY ([DeviceId]) REFERENCES Devices(Id)
)
