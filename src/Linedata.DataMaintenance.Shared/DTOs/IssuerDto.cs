
namespace Linedata.DataMaintenance.Shared.DTOs
{
    public class IssuerDto
    {
        //public int IssuerId { get; set; }
        public string ShortName { get; set; } = null!;
        public string IssuerName { get; set; } = null!;
        public string? EntityClip { get; set; }
        public string? EntityForm { get; set; } //EntityFormId
        public string? LegalForm { get; set; } //LegalFormId
        public string? Country { get; set; } //CountryId
        public string? UserId1 { get; set; }
        public string? UserId2 { get; set; }
        public string? UserId3 { get; set; }
        public string? UserId4 { get; set; }
        public string? UserId5 { get; set; }
        public string? UserId6 { get; set; }
        public string? UserId7 { get; set; }
        public string? UserId8 { get; set; }
        public string? Counterparty { get; set; } //CounterpartyId
    }                                         
}
