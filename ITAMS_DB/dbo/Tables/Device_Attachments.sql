CREATE TABLE [dbo].[Device_Attachments]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [DeviceId] INT NOT NULL, 
    [StreamId] NVARCHAR(50) NOT NULL
)
