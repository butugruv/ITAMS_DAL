using ITAMS_DAL.Models;

namespace ITAMS_DAL.Data
{
    public interface IDeviceData
    {
        Task CreateDevice(IDeviceModel device);
        Task<IDeviceModel> GetDeviceById(int deviceId);
        Task<List<IDeviceModel>> GetDevices();
        Task<List<IDevicesWithLookupsModel>> GetDevicesWithLookups();
        Task UpdateDevice(IDeviceModel device);
    }
}