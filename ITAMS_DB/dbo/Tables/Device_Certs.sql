CREATE TABLE [dbo].[Device_Certs]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [device_id] INT NOT NULL, 
    [cert_name] NVARCHAR(50) NULL, 
    [expiration_dt] DATETIME2 NULL, 
    CONSTRAINT [FK_Device_Certs_Devices] FOREIGN KEY (device_id) REFERENCES Devices(Id)
)
