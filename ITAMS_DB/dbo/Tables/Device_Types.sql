CREATE TABLE [dbo].[Device_Types]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [type_name] NVARCHAR(50) NOT NULL, 
    [type_description] NVARCHAR(50) NULL, 
    [created_dt] DATETIME2 NULL, 
    [created_by] NVARCHAR(50) NULL, 
    [modified_dt] DATETIME2 NULL, 
    [modified_by] NVARCHAR(50) NULL
)
