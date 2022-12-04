CREATE TABLE [dbo].[Location_Floors]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [location_id] INT NOT NULL, 
    [floor] NVARCHAR(10) NOT NULL, 
    CONSTRAINT [FK_Location_Floors_Locations] FOREIGN KEY (location_id) REFERENCES Locations(Id)
)
