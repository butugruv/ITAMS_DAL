CREATE TABLE [dbo].[Device_Certs]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [DeviceId] INT NOT NULL, 
    [CertName] NVARCHAR(50) NULL, 
    [ExpirationDate] DATETIME2 NULL, 
    CONSTRAINT [FK_Device_Certs_Devices] FOREIGN KEY ([DeviceId]) REFERENCES Devices(Id)
)
