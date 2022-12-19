CREATE PROCEDURE [dbo].[spDeviceAttachments_Insert]
	@Name nvarchar(255),
	@FileStream varbinary(max),
	@DeviceId int
AS
BEGIN

	declare @inserted table ([stream_id] uniqueidentifier);
	declare @StreamId nvarchar(50);

	insert into ITAMSDocStore (
		[name],
		[file_stream]
	) output inserted.stream_id into @inserted
	values (
		@Name,
		@FileStream
	);

	select @StreamId = stream_id 
	from @inserted;

	insert into Device_Attachments (
		DeviceId,
		StreamId
	)
	values (
		@DeviceId,
		@StreamId
	);

END