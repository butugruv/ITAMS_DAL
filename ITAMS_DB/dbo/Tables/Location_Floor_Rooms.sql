CREATE TABLE [dbo].[Location_Floor_Rooms]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [location_floor_id] INT NOT NULL, 
    [room] NVARCHAR(50) NOT NULL, 
    CONSTRAINT [FK_Location_Floor_Rooms_Location_Floor] FOREIGN KEY (location_floor_id) REFERENCES Location_Floors(Id)
)
