CREATE PROCEDURE [dbo].[spMetrics_GetDeviceTypeCounts]
AS
	SELECT [TypeName], 
		[Count]
	FROM DeviceType_Counts_vw;
RETURN 0
