using ITAMS_DAL.Models;

namespace ITAMS_DAL.Data
{
    public interface ILocationData
    {
        Task CreateLocation(LocationModel location);
        Task DeleteLocation(int id);
        Task<List<LocationFloorModel>> GetLocationFloors(int locationId);
        Task<List<LocationModel>> GetLocations();
        Task UpdateLocation(LocationModel location);
    }
}