using System.ComponentModel.DataAnnotations;

namespace ITAMS_DAL.Models
{
    public class DeviceIpModel : IDeviceIpModel
    {
        public int Id { get; set; }
        public int DeviceId { get; set; }
        [Required]
        public string IpAddress { get; set; }
        [Required]
        public string MacAddress { get; set; }
    }
}
