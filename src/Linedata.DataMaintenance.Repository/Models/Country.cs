namespace Linedata.DataMaintenance.Repository.Models
{
    public class Country
    {
        public int CountryId { get; set; }
        public string Mnemonic { get; set; } = null!;
        public string Name { get; set; } = null!;
        public bool EmuFlag { get; set; }
        public string? UserId1 { get; set; }
        public string? UserId2 { get; set; }
        public string? UserId3 { get; set; }
        public string? UserId4 { get; set; }
        public string? UserId5 { get; set; }
        public string? UserId6 { get; set; }
        public string? UserId7 { get; set; }
        public string? UserId8 { get; set; }
        public int ModifiedBy { get; set; }
        public int? CountryAuditId { get; set; }
        public DateTime? AsofTime { get; set; }
        public byte? DoNotAudit { get; set; }
    }
}
