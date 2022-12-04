CREATE TABLE [dbo].[Device_Software]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [device_id] INT NOT NULL, 
    [software_id] INT NOT NULL, 
    CONSTRAINT [FK_Device_Software_Devices] FOREIGN KEY (device_id) REFERENCES Devices(Id), 
    CONSTRAINT [FK_Device_Software_Software] FOREIGN KEY (software_id) REFERENCES Software(Id)
)
