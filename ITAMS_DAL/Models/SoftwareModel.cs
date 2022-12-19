namespace ITAMS_DAL.Models
{
    public class SoftwareModel
    {
        public int Id { get; set; }
        public string SoftwareName { get; set; }
        public string Version { get; set; }
        public string Description { get; set; }
        public DateTime DadmsApprovedDate { get; set; }
        public DateTime SecnavLdaDate { get; set; }
        public DateTime ValidatedDate { get; set; }
        public string ValidatedBy { get; set; }
    }
}
