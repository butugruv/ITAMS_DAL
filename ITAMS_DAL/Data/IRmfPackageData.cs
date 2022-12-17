using ITAMS_DAL.Models;

namespace ITAMS_DAL.Data
{
    public interface IRmfPackageData
    {
        Task CreateRmfPackage(RmfPackageModel rmfPackage);
        Task DeleteRmfPackage(int id);
        Task<List<RmfPackageModel>> GetRmfPackages();
        Task UpdateRmfPackage(RmfPackageModel rmfPackage);
    }
}