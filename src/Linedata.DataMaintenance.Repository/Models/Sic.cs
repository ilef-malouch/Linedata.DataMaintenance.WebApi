namespace Linedata.DataMaintenance.Repository.Models
{
    public class Sic
    {
        public byte Deleted { get; set; }
        public string SicId { get; set; } = null!;
        public string SicIdDesc { get; set; } = null!;
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedTime { get; set; }
    }

}
