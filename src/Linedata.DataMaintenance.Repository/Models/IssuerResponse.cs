namespace Linedata.DataMaintenance.Repository.Models
{
    public class IssuerResponse
    {
        public List<Issuer> Issuers { get; set; } = new List<Issuer>();
        public int Pages { get; set; }
        public int CurrentPage { get; set; }
    }
}
