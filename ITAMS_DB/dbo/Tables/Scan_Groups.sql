CREATE TABLE [dbo].[Scan_Groups]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [scan_group_name] NVARCHAR(50) NOT NULL, 
    [scan_group_description] NVARCHAR(4000) NULL
)
