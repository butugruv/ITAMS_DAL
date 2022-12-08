using ITAMS_DAL.Models;

namespace ITAMS_DAL.Data
{
    public interface IDeviceTypeData
    {
        Task<List<IDeviceTypeModel>> GetDeviceTypes();
    }
}