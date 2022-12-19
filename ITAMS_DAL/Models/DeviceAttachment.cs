namespace ITAMS_DAL.Models
{
    public class DeviceAttachment
    {
        public int Id { get; set; }
        public int DeviceId { get; set; }
        public string StreamId { get; set; }
        public string FileName { get; set; }
        public byte[] FileStream { get; set; }
        public DateTime CreatedDate { get; set; }
        public string FileType { get; set; }
    }
}
