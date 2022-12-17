CREATE PROCEDURE [dbo].[spRmfPackages_Create]
	@PackageName nvarchar(50),
	@PackageDescription nvarchar(4000)
AS
BEGIN
	set nocount on;

	insert into RMF_Packages (
		PackageName,
		PackageDescription
	)
	values (
		@PackageName,
		@PackageDescription
	);

END