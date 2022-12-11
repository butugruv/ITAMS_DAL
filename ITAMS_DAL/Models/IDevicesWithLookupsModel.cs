namespace ITAMS_DAL.Models
{
    public interface IDevicesWithLookupsModel
    {
        string CreatedBy { get; set; }
        DateTime CreatedDate { get; set; }
        string DeviceFunction { get; set; }
        string DeviceName { get; set; }
        string Floor { get; set; }
        int Id { get; set; }
        string LocationName { get; set; }
        string Manufacturer { get; set; }
        string Model { get; set; }
        string ModifiedBy { get; set; }
        DateTime ModifiedDate { get; set; }
        string PackageName { get; set; }
        string Poc { get; set; }
        string Room { get; set; }
        string TypeName { get; set; }
        string NetworkName { get; set; }
    }
}