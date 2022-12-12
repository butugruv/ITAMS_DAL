CREATE PROCEDURE [dbo].[spDevices_Delete]
	@Id int
AS
BEGIN
	delete from Devices
	where Id = @Id;
END