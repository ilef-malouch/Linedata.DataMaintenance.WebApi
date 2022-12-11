using Linedata.DataMaintenance.Shared.DTOs;

namespace Linedata.DataMaintenance.Shared.DataAccess
{
    public interface IIssuerService
    {
        //GET ISSUER NON DELETED WITH ID
        public IssuerDto GetIssuerById(int id);

        //ISSUER NON DELETED
        public IssuerResponseDto GetIssuers(int page, string? shortName, string? issuerName, string? entityClip, string? entityForm, string? legalForm, string? country);

    }
}
