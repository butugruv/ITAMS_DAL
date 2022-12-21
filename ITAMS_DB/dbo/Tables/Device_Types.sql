CREATE TABLE [dbo].[Device_Types]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [TypeName] NVARCHAR(50) NOT NULL, 
    [TypeDescription] NVARCHAR(4000) NULL, 
    [CreatedDate] DATETIME2 NULL, 
    [CreatedBy] NVARCHAR(50) NULL, 
    [ModifiedDate] DATETIME2 NULL, 
    [ModifiedBy] NVARCHAR(50) NULL
)
