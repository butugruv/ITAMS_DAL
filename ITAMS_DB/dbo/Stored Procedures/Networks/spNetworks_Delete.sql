CREATE PROCEDURE [dbo].[spNetworks_Delete]
	@Id int
AS
BEGIN
	delete from Networks
	where Id = @Id;
END
