CREATE TABLE [dbo].[Locations]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [location_name] NVARCHAR(50) NOT NULL, 
    [description] NVARCHAR(50) NULL
)
