using ITAMS_DAL.Models;

namespace ITAMS_DAL.Data
{
    public interface IDeviceIpData
    {
        Task CreateDeviceIp(IDeviceIpModel deviceIp);
        Task<List<IDeviceIpModel>> GetDeviceIps(int deviceIdParameter);
        Task UpdateDeviceIp(IDeviceIpModel deviceIp);
    }
}