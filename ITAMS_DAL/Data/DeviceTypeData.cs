using ITAMS_DAL.DataAccess;
using ITAMS_DAL.Models;

namespace ITAMS_DAL.Data
{
    public class DeviceTypeData : IDeviceTypeData
    {
        private readonly ISqlDataAccess _dataAccess;
        private readonly ConnectionStringData _connectionString;

        public DeviceTypeData(ISqlDataAccess dataAccess, ConnectionStringData connectionString)
        {
            _dataAccess = dataAccess;
            _connectionString = connectionString;
        }

        public async Task<List<DeviceTypeModel>> GetDeviceTypes()
        {
            var deviceTypes = await _dataAccess.LoadData<DeviceTypeModel, dynamic>("dbo.spDeviceTypes_GetAll", new { }, _connectionString.SqlConnectionName);
            return deviceTypes;
        }

        public async Task CreateDeviceType(DeviceTypeModel deviceType)
        {
            var deviceTypeParameters = new
            {
                deviceType.TypeName,
                deviceType.TypeDescription,
                deviceType.CreatedDate,
                deviceType.CreatedBy
            };

            await _dataAccess.SaveData("dbo.spDeviceTypes_Create", deviceTypeParameters, _connectionString.SqlConnectionName);
        }

        public async Task UpdateDeviceType(DeviceTypeModel deviceType)
        {
            await _dataAccess.SaveData("dbo.spDeviceTypes_Update", deviceType, _connectionString.SqlConnectionName);
        }

        public async Task DeleteDeviceType(int id)
        {
            await _dataAccess.SaveData("dbo.spDeviceTypes_Delete", new { Id = id }, _connectionString.SqlConnectionName);
        }
    }
}
