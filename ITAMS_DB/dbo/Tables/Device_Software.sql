CREATE TABLE [dbo].[Device_Software]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [DeviceId] INT NOT NULL, 
    [SoftwareId] INT NOT NULL, 
    CONSTRAINT [FK_Device_Software_Devices] FOREIGN KEY ([DeviceId]) REFERENCES Devices(Id) ON DELETE CASCADE, 
    CONSTRAINT [FK_Device_Software_Software] FOREIGN KEY ([SoftwareId]) REFERENCES Software(Id)
)
