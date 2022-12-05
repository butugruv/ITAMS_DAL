CREATE TABLE [dbo].[Location_Floor_Rooms]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [LocationFloorId] INT NOT NULL, 
    [Room] NVARCHAR(50) NOT NULL, 
    CONSTRAINT [FK_Location_Floor_Rooms_Location_Floor] FOREIGN KEY ([LocationFloorId]) REFERENCES Location_Floors(Id)
)
