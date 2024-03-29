﻿using ITAMS_DAL.DataAccess;
using ITAMS_DAL.Models;

namespace ITAMS_DAL.Data
{
    public class DeviceData : IDeviceData
    {
        private readonly ISqlDataAccess _dataAccess;
        private readonly ConnectionStringData _connectionString;

        public DeviceData(ISqlDataAccess dataAccess, ConnectionStringData connectionString)
        {
            _dataAccess = dataAccess;
            _connectionString = connectionString;
        }

        public async Task<List<IDeviceModel>> GetDevices()
        {
            var devices = await _dataAccess.LoadData<DeviceModel, dynamic>("dbo.spDevices_GetAll", new { }, _connectionString.SqlConnectionName);
            return devices.ToList<IDeviceModel>();
        }

        public async Task<List<IDevicesWithLookupsModel>> GetDevicesWithLookups()
        {
            var devicesWithLookups = await _dataAccess.LoadData<DevicesWithLookupsModel, dynamic>("dbo.spDevicesWithLookups_GetAll", new { }, _connectionString.SqlConnectionName);
            return devicesWithLookups.ToList<IDevicesWithLookupsModel>();
        }

        public async Task<IDeviceModel> GetDeviceById(int deviceId)
        {
            var recs = await _dataAccess.LoadData<DeviceModel, dynamic>("dbo.spDevices_GetById", new { Id = deviceId }, _connectionString.SqlConnectionName);

            return recs.FirstOrDefault();
        }

        public async Task UpdateDevice(IDeviceModel device)
        {
            await _dataAccess.SaveData("dbo.spDevices_Update", device, _connectionString.SqlConnectionName);
        }

        public async Task DeleteDevice(int id)
        {
            await _dataAccess.SaveData("dbo.spDevices_Delete", new { Id = id }, _connectionString.SqlConnectionName);
        }

        public async Task CreateDevice(IDeviceModel device)
        {
            var deviceParameters = new
            {
                device.DeviceName,
                device.DeviceFunction,
                device.DeviceTypeId,
                device.ManufacturerId,
                device.Poc,
                device.LocationId,
                device.LocationFloorId,
                device.LocationFloorRoomId,
                device.RmfPackageId,
                device.Model,
                device.CreatedDate,
                device.CreatedBy,
                device.NetworkId

            };

            await _dataAccess.SaveData("dbo.spDevices_Create", deviceParameters, _connectionString.SqlConnectionName);
        }

        public async Task CreateDeviceAttachment(string fileName, byte[] data, int deviceId)
        {
            var parameters = new
            {
                Name = fileName,
                FileStream = data,
                DeviceId = deviceId
            };

            await _dataAccess.SaveData("dbo.spDeviceAttachments_Insert", parameters, _connectionString.SqlConnectionName);
        }

        public async Task<List<DeviceAttachment>> GetDeviceAttachments(int deviceId)
        {
            var deviceAttachments = await _dataAccess.LoadData<DeviceAttachment, dynamic>("dbo.spDeviceAttachments_GetAll", new { DeviceId = deviceId }, _connectionString.SqlConnectionName);
            return deviceAttachments;
        }

    }
}
