CREATE VIEW [dbo].[DeviceType_Counts_vw]
AS 
select dtype.TypeName, 
	count(devi.DeviceName) as "Count"
from Device_Types dtype
left join Devices devi on devi.DeviceTypeId = dtype.Id
group by dtype.typename