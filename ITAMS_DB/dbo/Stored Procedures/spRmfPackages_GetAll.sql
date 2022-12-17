CREATE PROCEDURE [dbo].[spRmfPackages_GetAll]
AS
BEGIN
	set nocount on;

	select [Id], 
		[PackageName], 
		[PackageDescription] 
	from RMF_Packages;
END
