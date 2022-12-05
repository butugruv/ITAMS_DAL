CREATE TABLE [dbo].[Location_Floors]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [LocationId] INT NOT NULL, 
    [Floor] NVARCHAR(10) NOT NULL, 
    CONSTRAINT [FK_Location_Floors_Locations] FOREIGN KEY ([LocationId]) REFERENCES Locations(Id)
)
