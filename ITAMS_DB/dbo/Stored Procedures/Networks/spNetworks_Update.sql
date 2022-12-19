CREATE PROCEDURE [dbo].[spNetworks_Update]
	@Id int,
	@NetworkName nvarchar(50),
	@Description nvarchar(4000)
AS
BEGIN
	set nocount on;

	update Networks
	set NetworkName = @NetworkName,
		[Description] = @Description
	where Id = @Id;
END