using ITAMS_DAL.Models;

namespace ITAMS_DAL.Data
{
    public interface IGridStateData
    {
        Task CreateGridState(GridStateModel gridState);
        Task<List<GridStateModel>> GetGridStates();
    }
}