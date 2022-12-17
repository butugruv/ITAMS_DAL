using ITAMS_DAL.DataAccess;
using ITAMS_DAL.Models;

namespace ITAMS_DAL.Data
{
    public class RmfPackageData : IRmfPackageData
    {
        private readonly ISqlDataAccess _dataAccess;
        private readonly ConnectionStringData _connectionString;

        public RmfPackageData(ISqlDataAccess dataAccess, ConnectionStringData connectionString)
        {
            _dataAccess = dataAccess;
            _connectionString = connectionString;
        }

        public async Task<List<RmfPackageModel>> GetRmfPackages()
        {
            var rmfPackages = await _dataAccess.LoadData<RmfPackageModel, dynamic>("dbo.spRmfPackages_GetAll", new { }, _connectionString.SqlConnectionName);
            return rmfPackages;
        }

        public async Task CreateRmfPackage(RmfPackageModel rmfPackage)
        {
            var rmfPackageParameters = new
            {
                rmfPackage.PackageName,
                rmfPackage.PackageDescription
            };

            await _dataAccess.SaveData("dbo.spRmfPackages_Create", rmfPackageParameters, _connectionString.SqlConnectionName);
        }

        public async Task UpdateRmfPackage(RmfPackageModel rmfPackage)
        {
            await _dataAccess.SaveData("dbo.spRmfPackages_Update", rmfPackage, _connectionString.SqlConnectionName);
        }

        public async Task DeleteRmfPackage(int id)
        {
            await _dataAccess.SaveData("dbo.spRmfPackages_Delete", new { Id = id }, _connectionString.SqlConnectionName);
        }
    }
}
