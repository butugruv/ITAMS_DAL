namespace ITAMS_DAL.Models
{
    public class GridStateModel
    {
        public int Id { get; set; }
        public string SerializedState { get; set; }
        public int GridId { get; set; }
        public string StateName { get; set; }
    }
}
