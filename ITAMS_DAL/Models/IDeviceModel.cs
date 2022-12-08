namespace ITAMS_DAL.Models
{
    public interface IDeviceModel
    {
        string CreatedBy { get; set; }
        DateTime CreatedDate { get; set; }
        string DeviceFunction { get; set; }
        string DeviceName { get; set; }
        int DeviceTypeId { get; set; }
        int Id { get; set; }
        int LocationFloorId { get; set; }
        int LocationFloorRoomId { get; set; }
        int LocationId { get; set; }
        int ManufacturerId { get; set; }
        string model { get; set; }
        string ModifiedBy { get; set; }
        DateTime ModifiedDate { get; set; }
        string Poc { get; set; }
        int RmfPackageId { get; set; }
    }
}