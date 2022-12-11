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
	,netw.NetworkName
from Devices devi
left join Device_Types dtype on devi.DeviceTypeId = dtype.Id
left join Manufacturers mfr on devi.ManufacturerId = mfr.Id
left join Locations loc on devi.LocationId = loc.Id
left join Location_Floors lflr on devi.LocationFloorId = lflr.Id
left join Location_Floor_Rooms lfr on devi.LocationFloorRoomId = lfr.Id
left join RMF_Packages rmf on devi.RmfPackageId = rmf.Id
left join Networks netw on devi.NetworkId = netw.Id
