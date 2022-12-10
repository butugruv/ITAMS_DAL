namespace ITAMS_DAL.Models
{
    public interface IDeviceIpModel
    {
        int Id { get; set; }
        int DeviceId { get; set; }
        string IpAddress { get; set; }
        string MacAddress { get; set; }
    }
}