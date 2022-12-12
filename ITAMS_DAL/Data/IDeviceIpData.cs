using ITAMS_DAL.Models;

namespace ITAMS_DAL.Data
{
    public interface IDeviceIpData
    {
        Task CreateDeviceIp(DeviceIpModel deviceIp);
        Task DeleteDeviceIp(int Id);
        Task<List<DeviceIpModel>> GetDeviceIps(int deviceIdParameter);
        Task UpdateDeviceIp(DeviceIpModel deviceIp);
    }
}