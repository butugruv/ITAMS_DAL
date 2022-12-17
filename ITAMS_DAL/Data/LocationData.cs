using ITAMS_DAL.DataAccess;
using ITAMS_DAL.Models;

namespace ITAMS_DAL.Data
{
    public class LocationData : ILocationData
    {
        private readonly ISqlDataAccess _dataAccess;
        private readonly ConnectionStringData _connectionString;

        public LocationData(ISqlDataAccess dataAccess, ConnectionStringData connectionString)
        {
            _dataAccess = dataAccess;
            _connectionString = connectionString;
        }

        public async Task<List<LocationModel>> GetLocations()
        {
            var locations = await _dataAccess.LoadData<LocationModel, dynamic>("dbo.spLocations_GetAll", new { }, _connectionString.SqlConnectionName);
            return locations;
        }

        public async Task CreateLocation(LocationModel location)
        {
            var locationParameters = new
            {
                location.LocationName,
                location.Description
            };

            await _dataAccess.SaveData("dbo.spLocations_Create", locationParameters, _connectionString.SqlConnectionName);
        }

        public async Task UpdateLocation(LocationModel location)
        {
            await _dataAccess.SaveData("dbo.spLocations_Update", location, _connectionString.SqlConnectionName);
        }

        public async Task DeleteLocation(int id)
        {
            await _dataAccess.SaveData("dbo.spLocations_Delete", new { Id = id }, _connectionString.SqlConnectionName);
        }

        public async Task<List<LocationFloorModel>> GetLocationFloors(int locationId)
        {
            var locations = await _dataAccess.LoadData<LocationFloorModel, dynamic>("dbo.spLocationFloors_GetLocationFloors", new { LocationId = locationId }, _connectionString.SqlConnectionName);
            return locations;
        }
    }
}
