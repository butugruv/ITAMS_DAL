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
            var recs = await _dataAccess.LoadData<DeviceModel, dynamic>("dbo.spDevices_GetById",
                new { Id = deviceId },
                _connectionString.SqlConnectionName);

            return recs.FirstOrDefault();
        }
    }
}
