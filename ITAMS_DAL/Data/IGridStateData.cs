using ITAMS_DAL.Models;

namespace ITAMS_DAL.Data
{
    public interface IGridStateData
    {
        Task CreateGridState(GridStateModel gridState);
        Task<GridStateModel> GetGridStateById(int gridStateId);
        Task<List<GridStateModel>> GetGridStates();
    }
}