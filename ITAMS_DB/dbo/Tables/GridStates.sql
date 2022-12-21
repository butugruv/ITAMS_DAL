CREATE TABLE [dbo].[GridStates]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [SerializedState] NVARCHAR(4000) NOT NULL, 
    [GridId] INT NOT NULL, 
    [StateName] NVARCHAR(50) NOT NULL
)
