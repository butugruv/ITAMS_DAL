using ITAMS_DAL.Models;

namespace ITAMS_DAL.Data
{
    public interface IManufacturerData
    {
        Task<List<ManufacturerModel>> GetManufacturers();
    }
}