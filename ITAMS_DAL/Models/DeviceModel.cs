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

        [Display(Name = "Created Date")]
        public DateTime CreatedDate { get; set; }

        [Display(Name = "Created By")]
        public string CreatedBy { get; set; }

        [Display(Name = "Modified Date")]
        public DateTime ModifiedDate { get; set; }

        [Display(Name = "Modified By")]
        public string ModifiedBy { get; set; }

        [Required]
        [Display(Name = "Location")]
        [Range(1, int.MaxValue, ErrorMessage = "Value must be greater than 0")]
        public int LocationId { get; set; }

        [Required]
        [Display(Name = "Floor")]
        [Range(1, int.MaxValue, ErrorMessage = "Value must be greater than 0")]
        public int LocationFloorId { get; set; }

        [Required]
        [Display(Name = "Room")]
        [Range(1, int.MaxValue, ErrorMessage = "Value must be greater than 0")]
        public int LocationFloorRoomId { get; set; }

        [Required]
        [Display(Name = "RMF Package")]
        [Range(1, int.MaxValue, ErrorMessage = "Value must be greater than 0")]
        public int RmfPackageId { get; set; }
        public string Model { get; set; }

        [Required]
        [Display(Name = "Manufacturer")]
        [Range(1, int.MaxValue, ErrorMessage = "Value must be greater than 0")]
        public int NetworkId { get; set; }
    }
}
