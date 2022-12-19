CREATE TABLE [dbo].[Software]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [SoftwareName] NVARCHAR(50) NOT NULL, 
    [Version] NVARCHAR(50) NOT NULL, 
    [Description] NVARCHAR(4000) NOT NULL, 
    [DadmsApprovedDate] DATETIME2 NULL, 
    [SecnavLdaDate] DATETIME2 NULL, 
    [ValidatedDate] DATETIME2 NULL, 
    [ValidatedBy] NVARCHAR(50) NULL
)
