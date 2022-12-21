CREATE VIEW [dbo].[DeviceType_Counts_vw]
AS 
select dtype.TypeName
	,count(*) as "Count"
from Devices devi
inner join Device_Types dtype on devi.DeviceTypeId = dtype.Id
group by dtype.TypeName
