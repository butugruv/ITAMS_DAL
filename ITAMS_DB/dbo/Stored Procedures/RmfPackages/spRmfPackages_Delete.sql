CREATE PROCEDURE [dbo].[spRmfPackages_Delete]
	@Id int
AS
BEGIN
	delete from RMF_Packages
	where Id = @Id;
END