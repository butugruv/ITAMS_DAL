using ITAMS_DAL.Models;

namespace ITAMS_DAL.Data
{
    public interface IDeviceIpData
    {
        Task<List<IDeviceIpModel>> GetDeviceIps(int deviceIdParameter);
    }
}