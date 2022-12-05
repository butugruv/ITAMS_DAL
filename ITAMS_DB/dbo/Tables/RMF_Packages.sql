CREATE TABLE [dbo].[RMF_Packages]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [PackageName] NVARCHAR(50) NOT NULL, 
    [PackageDescription] NVARCHAR(4000) NULL
)
