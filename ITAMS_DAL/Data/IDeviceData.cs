using ITAMS_DAL.Models;

namespace ITAMS_DAL.Data
{
    public interface IDeviceData
    {
        Task<IDeviceModel> GetDeviceById(int deviceId);
        Task<List<IDeviceModel>> GetDevices();
        Task<List<IDevicesWithLookupsModel>> GetDevicesWithLookups();
    }
}