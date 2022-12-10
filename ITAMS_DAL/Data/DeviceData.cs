using ITAMS_DAL.DataAccess;
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
                device.CreatedBy

            };

            await _dataAccess.SaveData("dbo.spDevices_Create", deviceParameters, _connectionString.SqlConnectionName);
        }
    }
}
