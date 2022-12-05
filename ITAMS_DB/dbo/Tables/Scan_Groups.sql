CREATE TABLE [dbo].[Scan_Groups]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [ScanGroupName] NVARCHAR(50) NOT NULL, 
    [ScanGroupDescription] NVARCHAR(4000) NULL
)
