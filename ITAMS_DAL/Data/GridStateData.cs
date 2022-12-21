using ITAMS_DAL.DataAccess;
using ITAMS_DAL.Models;

namespace ITAMS_DAL.Data
{
    public class GridStateData : IGridStateData
    {
        private readonly ISqlDataAccess _dataAccess;
        private readonly ConnectionStringData _connectionString;

        public GridStateData(ISqlDataAccess dataAccess, ConnectionStringData connectionString)
        {
            _dataAccess = dataAccess;
            _connectionString = connectionString;
        }

        public async Task<List<GridStateModel>> GetGridStates()
        {
            var gridStates = await _dataAccess.LoadData<GridStateModel, dynamic>("dbo.spGridStates_GetAll", new { }, _connectionString.SqlConnectionName);
            return gridStates;
        }

        public async Task CreateGridState(GridStateModel gridState)
        {
            var gridStateParameters = new
            {
                gridState.SerializedState,
                gridState.GridId,
                gridState.StateName
            };

            await _dataAccess.SaveData("dbo.spGridStates_Create", gridStateParameters, _connectionString.SqlConnectionName);
        }
    }
}
