CREATE VIEW [dbo].[devices_vw]
AS
SELECT devi.[Id]
      ,devi.[device_name]
      ,devi.[device_function]
      ,dtype.type_name as device_type
      ,manu.[name] as manufacturer
      ,devi.[poc_tx]
      ,devi.[created_dt]
      ,devi.[created_by]
      ,devi.[modified_dt]
      ,devi.[modified_by]
      ,loc.location_name
      ,locf.[floor]
      ,lfr.room
      ,rmfp.package_name
      ,devi.[model]
FROM Devices devi
left join Manufacturers manu on devi.manufacturer_id = manu.Id
left join Device_Types dtype on devi.device_type_id = dtype.Id
left join RMF_Packages rmfp on devi.rmf_package_id = rmfp.Id
left join Locations loc on devi.location_id = loc.id
left join Location_Floors locf on devi.location_floor_id = locf.Id
left join Location_Floor_Rooms lfr on devi.location_floor_room_id = lfr.Id