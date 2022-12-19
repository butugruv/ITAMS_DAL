CREATE PROCEDURE [dbo].[spRmfPackages_Update]
	@Id int,
	@PackageName nvarchar(50),
	@PackageDescription nvarchar(4000)
AS
BEGIN
	set nocount on;

	update RMF_Packages
	set PackageName = @PackageName,
		PackageDescription = @PackageDescription
	where Id = @Id;
END