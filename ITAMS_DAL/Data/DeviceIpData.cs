using ITAMS_DAL.DataAccess;
using ITAMS_DAL.Models;

namespace ITAMS_DAL.Data
{
    public class DeviceIpData : IDeviceIpData
    {
        private readonly ISqlDataAccess _dataAccess;
        private readonly ConnectionStringData _connectionString;

        public DeviceIpData(ISqlDataAccess dataAccess, ConnectionStringData connectionString)
        {
            _dataAccess = dataAccess;
            _connectionString = connectionString;
        }

        public async Task<List<DeviceIpModel>> GetDeviceIps(int deviceIdParameter)
        {
            var ips = await _dataAccess.LoadData<DeviceIpModel, dynamic>("dbo.spDeviceIps_GetByDeviceId", new { deviceId = deviceIdParameter }, _connectionString.SqlConnectionName);
            //return ips.ToList<IDeviceIpModel>();
            return ips;
        }

        public async Task UpdateDeviceIp(DeviceIpModel deviceIp)
        {
            await _dataAccess.SaveData("dbo.spDeviceIps_Update", deviceIp, _connectionString.SqlConnectionName);
        }

        public async Task DeleteDeviceIp(int Id)
        {
            await _dataAccess.SaveData("dbo.spDeviceIps_Delete", Id, _connectionString.SqlConnectionName);
        }

        public async Task CreateDeviceIp(DeviceIpModel deviceIp)
        {
            var deviceIpParameters = new
            {
                deviceIp.DeviceId,
                deviceIp.IpAddress,
                deviceIp.MacAddress
            };

            await _dataAccess.SaveData("dbo.spDeviceIps_Create", deviceIpParameters, _connectionString.SqlConnectionName);
        }
    }
}
