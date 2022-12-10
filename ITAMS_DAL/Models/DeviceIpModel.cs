namespace ITAMS_DAL.Models
{
    public class DeviceIpModel : IDeviceIpModel
    {
        public int Id { get; set; }
        public int DeviceId { get; set; }
        public string IpAddress { get; set; }
        public string MacAddress { get; set; }
    }
}
