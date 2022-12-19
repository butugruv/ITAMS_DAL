CREATE PROCEDURE [dbo].[spNetworks_GetAll]
AS
BEGIN
	set nocount on;

	select [Id], 
		[NetworkName], 
		[Description]
	from Networks;
END