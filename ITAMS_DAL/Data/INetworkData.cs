using ITAMS_DAL.Models;

namespace ITAMS_DAL.Data
{
    public interface INetworkData
    {
        Task CreateNetwork(NetworkModel network);
        Task DeleteNetwork(int id);
        Task<List<NetworkModel>> GetNetworks();
        Task UpdateNetwork(NetworkModel network);
    }
}