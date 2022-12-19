using System.ComponentModel.DataAnnotations;

namespace ITAMS_DAL.Models
{
    public class DeviceIpModel : IDeviceIpModel
    {
        public int Id { get; set; }
        public int DeviceId { get; set; }

        [Required]
        [Display(Name = "IP Address")]
        [RegularExpression(@"^(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)$"
                            , ErrorMessage = "IP must be in a valid IPv4 format")]
        public string IpAddress { get; set; }

        [Required]
        [Display(Name = "MAC Address")]
        [RegularExpression(@"^(\w{2}:){5}(\w{2})$", ErrorMessage = "Value must be in the format of XX:XX:XX:XX:XX:XX")]
        public string MacAddress { get; set; }
    }
}
