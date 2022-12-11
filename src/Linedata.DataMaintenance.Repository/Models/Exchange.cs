namespace Linedata.DataMaintenance.Repository.Models
{
    public partial class Exchange
    {
        public bool Listed { get; set; }
        public int ExchangeId { get; set; }
        public string Mnemonic { get; set; } = null!;
        public string Name { get; set; } = null!;
        public int CountryId { get; set; }
        public short Rounding { get; set; }
        public short ExchangeFeeId { get; set; }
        public short CommissionTypeId { get; set; }
        public string? UserId1 { get; set; }
        public string? UserId2 { get; set; }
        public string? UserId3 { get; set; }
        public string? UserId4 { get; set; }
        public string? UserId5 { get; set; }
        public string? UserId6 { get; set; }
        public string? UserId7 { get; set; }
        public string? UserId8 { get; set; }
        public int TimeZoneId { get; set; }
        public short ClosingHour { get; set; }
        public short ClosingMinute { get; set; }
        public int? SourceSystemId { get; set; }
        public string? ClientExchangeId { get; set; }
        public int ModifiedBy { get; set; }
        public int? ExchangeAuditId { get; set; }
        public DateTime? AsofTime { get; set; }
        public byte? DoNotAudit { get; set; }
        public short OpeningHour { get; set; }
        public short OpeningMinute { get; set; }
        public int? ExchangeCcpId { get; set; }
        public string? LastMkt { get; set; }
    }
}
