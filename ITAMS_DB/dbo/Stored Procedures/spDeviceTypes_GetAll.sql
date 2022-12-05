CREATE PROCEDURE [dbo].[spDeviceTypes_GetAll]
AS
BEGIN
	set nocount on;
	
	select [Id], 
		[TypeName], 
		[TypeDescription], 
		[CreatedDate], 
		[CreatedBy], 
		[ModifiedDate], 
		[ModifiedBy]
	from Device_Types;
END
