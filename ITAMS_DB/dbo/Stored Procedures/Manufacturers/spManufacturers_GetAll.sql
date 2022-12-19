CREATE PROCEDURE [dbo].[spManufacturers_GetAll]
AS
BEGIN
	set nocount on;

	select [Id], 
		[Name]
	from Manufacturers;
END
