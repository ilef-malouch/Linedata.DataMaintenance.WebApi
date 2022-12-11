using Linedata.DataMaintenance.Repository.Models;

namespace Linedata.DataMaintenance.Repository
{
    public interface IIssuerRepo
    {
        //GET ISSUER BY ID
        public Issuer? GetIssuerById(int id);
        public IssuerResponse GetIssuers(int page, string? shortName, string? issuerName, string? entityClip, string? entityForm, string? legalForm, string? country);
    }
}
