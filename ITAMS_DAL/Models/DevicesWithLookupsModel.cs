namespace ITAMS_DAL.Models
{
    public class DevicesWithLookupsModel : IDevicesWithLookupsModel
    {
        public int Id { get; set; }
        public string DeviceName { get; set; }
        public string DeviceFunction { get; set; }
        public string TypeName { get; set; }
        public string Manufacturer { get; set; }
        public string Poc { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public string LocationName { get; set; }
        public string Floor { get; set; }
        public string Room { get; set; }
        public string PackageName { get; set; }
        public string Model { get; set; }
    }
}
