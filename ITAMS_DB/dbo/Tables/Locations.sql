CREATE TABLE [dbo].[Locations]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [LocationName] NVARCHAR(50) NOT NULL, 
    [Description] NVARCHAR(50) NULL
)
