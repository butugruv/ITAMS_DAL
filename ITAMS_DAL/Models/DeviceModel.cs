using System.ComponentModel.DataAnnotations;

namespace ITAMS_DAL.Models
{
    public class DeviceModel : IDeviceModel
    {
        [Display(Name = "Device ID#")]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Device Name")]
        public string DeviceName { get; set; }
        public string DeviceFunction { get; set; }

        [Required]
        [Display(Name = "Device Type")]
        [Range(1, int.MaxValue, ErrorMessage = "Value must be greater than 0")]
        public int DeviceTypeId { get; set; }

        [Required]
        [Display(Name = "Manufacturer")]
        [Range(1, int.MaxValue, ErrorMessage = "Value must be greater than 0")]
        public int ManufacturerId { get; set; }

        [Required]
        [Display(Name = "POC")]
        public string Poc { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }

        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Value must be greater than 0")]
        public int LocationId { get; set; }

        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Value must be greater than 0")]
        public int LocationFloorId { get; set; }

        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Value must be greater than 0")]
        public int LocationFloorRoomId { get; set; }

        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Value must be greater than 0")]
        public int RmfPackageId { get; set; }
        public string Model { get; set; }

        [Required]
        [Display(Name = "Manufacturer")]
        [Range(1, int.MaxValue, ErrorMessage = "Value must be greater than 0")]
        public int NetworkId { get; set; }
    }
}
