namespace ITAMS_DAL.Models
{
    public interface IDeviceTypeModel
    {
        string CreatedBy { get; set; }
        DateTime CreatedDate { get; set; }
        int Id { get; set; }
        string ModifiedBy { get; set; }
        DateTime ModifiedDate { get; set; }
        string TypeDescription { get; set; }
        string TypeName { get; set; }
    }
}