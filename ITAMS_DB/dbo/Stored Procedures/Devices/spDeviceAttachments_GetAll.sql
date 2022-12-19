CREATE PROCEDURE [dbo].[spDeviceAttachments_GetAll]
	@DeviceId int
AS
BEGIN
	set nocount on;

	select [Id], 
		[DeviceId], 
		[StreamId]
	from Device_Attachments
	where DeviceId = @DeviceId;
END