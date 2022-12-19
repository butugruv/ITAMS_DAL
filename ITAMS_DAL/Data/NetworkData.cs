using ITAMS_DAL.DataAccess;
using ITAMS_DAL.Models;

namespace ITAMS_DAL.Data
{
    public class NetworkData : INetworkData
    {
        private readonly ISqlDataAccess _dataAccess;
        private readonly ConnectionStringData _connectionString;

        public NetworkData(ISqlDataAccess dataAccess, ConnectionStringData connectionString)
        {
            _dataAccess = dataAccess;
            _connectionString = connectionString;
        }

        public async Task<List<NetworkModel>> GetNetworks()
        {
            var networks = await _dataAccess.LoadData<NetworkModel, dynamic>("dbo.spNetworks_GetAll", new { }, _connectionString.SqlConnectionName);
            return networks;
        }

        public async Task CreateNetwork(NetworkModel network)
        {
            var networkParameters = new
            {
                network.NetworkName,
                network.Description
            };

            await _dataAccess.SaveData("dbo.spNetworks_Create", networkParameters, _connectionString.SqlConnectionName);
        }

        public async Task UpdateNetwork(NetworkModel network)
        {
            await _dataAccess.SaveData("dbo.spNetworks_Update", network, _connectionString.SqlConnectionName);
        }

        public async Task DeleteNetwork(int id)
        {
            await _dataAccess.SaveData("dbo.spNetworks_Delete", new { Id = id }, _connectionString.SqlConnectionName);
        }
    }
}