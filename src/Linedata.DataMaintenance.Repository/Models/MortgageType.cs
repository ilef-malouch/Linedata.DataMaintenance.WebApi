
namespace Linedata.DataMaintenance.Repository.Models
{
    public class MortgageType
    {
        public short MortgageTypeId { get; set; }
        public string? MortgageTypeDesc { get; set; }
        public short ProductTypeId { get; set; }
        public short AgencyTypeId { get; set; }
        public short MaturityTypeId { get; set; }
        public string? GenericTicker { get; set; }
        public char SettlementClass { get; set; }
        public int DefaultingIssuerId { get; set; } 
    }
}
