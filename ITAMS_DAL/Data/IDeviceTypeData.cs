using ITAMS_DAL.Models;

namespace ITAMS_DAL.Data
{
    public interface IDeviceTypeData
    {
        Task CreateDeviceType(DeviceTypeModel deviceType);
        Task DeleteDeviceType(int id);
        Task<List<DeviceTypeModel>> GetDeviceTypes();
        Task UpdateDeviceType(DeviceTypeModel deviceType);
    }
}