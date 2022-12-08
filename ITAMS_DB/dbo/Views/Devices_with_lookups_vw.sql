CREATE VIEW [dbo].[Devices_with_lookups_vw]
AS
select devi.Id
	,devi.DeviceName
	,devi.DeviceFunction
	,dtype.TypeName
	,mfr.[Name] as Manufacturer
	,devi.Poc
	,devi.CreatedDate
	,devi.CreatedBy
	,devi.ModifiedDate
	,devi.ModifiedBy
	,loc.LocationName
	,lflr.[Floor]
	,lfr.Room
	,rmf.PackageName
	,devi.Model
from Devices devi
inner join Device_Types dtype on devi.DeviceTypeId = dtype.Id
inner join Manufacturers mfr on devi.ManufacturerId = mfr.Id
inner join Locations loc on devi.LocationId = loc.Id
inner join Location_Floors lflr on devi.LocationFloorId = lflr.Id
inner join Location_Floor_Rooms lfr on devi.LocationFloorRoomId = lfr.Id
inner join RMF_Packages rmf on devi.RmfPackageId = rmf.Id
