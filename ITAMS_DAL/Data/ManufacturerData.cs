using ITAMS_DAL.DataAccess;
using ITAMS_DAL.Models;

namespace ITAMS_DAL.Data
{
    public class ManufacturerData : IManufacturerData
    {
        private readonly ISqlDataAccess _dataAccess;
        private readonly ConnectionStringData _connectionString;

        public ManufacturerData(ISqlDataAccess dataAccess, ConnectionStringData connectionString)
        {
            _dataAccess = dataAccess;
            _connectionString = connectionString;
        }

        public async Task<List<ManufacturerModel>> GetManufacturers()
        {
            var manufacturers = await _dataAccess.LoadData<ManufacturerModel, dynamic>("dbo.spManufacturers_GetAll", new { }, _connectionString.SqlConnectionName);
            return manufacturers;
        }
    }
}
