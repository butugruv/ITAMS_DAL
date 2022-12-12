using System.ComponentModel.DataAnnotations;

namespace ITAMS_DAL.Models
{
    public class DeviceIpModel : IDeviceIpModel
    {
        public int Id { get; set; }
        public int DeviceId { get; set; }

        [Required]
        [Display(Name = "IP Address")]
        public string IpAddress { get; set; }

        [Required]
        [Display(Name = "MAC Address")]
        public string MacAddress { get; set; }
    }
}
