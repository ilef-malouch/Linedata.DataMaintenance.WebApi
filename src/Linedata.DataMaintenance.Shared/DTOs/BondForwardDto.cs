
namespace Linedata.DataMaintenance.Shared.DTOs
{
    public class BondForwardDto
    {
        public string? Symbol { get; set; }
        public string? Name { get; set; }
        public string? GenericTicker { get; set; }
        public string? MortgageType { get; set; }
        public string? SettlementMonth { get; set; }

        //public string? Agency { get; set; }

        //public string? Issuer { get; set; }
        public double? Coupon { get; set; }
        public string? Ticker { get; set; }
        public string? Reuters { get; set; }
        public string? CUSIP { get; set; }
        public string? SEDOL { get; set; }
        public string? ISIN { get; set; }

        //public string? InternalName { get; set; }

    }
}
