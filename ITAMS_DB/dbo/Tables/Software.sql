CREATE TABLE [dbo].[Software]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [software_name] NVARCHAR(50) NOT NULL, 
    [version] NVARCHAR(50) NOT NULL, 
    [description] NVARCHAR(4000) NOT NULL
)
