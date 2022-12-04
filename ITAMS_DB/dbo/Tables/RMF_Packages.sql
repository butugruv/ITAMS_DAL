CREATE TABLE [dbo].[RMF_Packages]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [package_name] NVARCHAR(50) NOT NULL, 
    [package_description] NVARCHAR(4000) NULL
)
