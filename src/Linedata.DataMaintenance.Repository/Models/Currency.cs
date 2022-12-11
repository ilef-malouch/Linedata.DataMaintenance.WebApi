namespace Linedata.DataMaintenance.Repository.Models
{
    public partial class Currency
    {
        public int SecurityId { get; set; }
        public string Mnemonic { get; set; } = null!;
        public double ExchangeRate { get; set; }
        public DateTime Dated { get; set; }
        public double? Opening { get; set; }
        public double? Closing { get; set; }
        public short MarketValueRounding { get; set; }
        public bool SystemCurrency { get; set; }
        public int? CurrencyAuditId { get; set; }
        public DateTime? AsofTime { get; set; }
        public byte? DoNotAudit { get; set; }
        public byte InvalidFlag { get; set; }
        public DateTime? ValidationDate { get; set; }
        public int? ReviewerId { get; set; }
        public string? ReviewComment { get; set; }
    }
}
