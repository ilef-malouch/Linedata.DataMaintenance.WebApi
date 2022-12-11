using Linedata.DataMaintenance.Repository.Models;

namespace Linedata.DataMaintenance.Repository
{
    public class IssuerRepo : IIssuerRepo
    {
        public readonly DataContext _dataContext;
        public readonly ITools _tools;

        public IssuerRepo(DataContext dataContext, ITools tools )
        {
            _dataContext = dataContext;
            _tools = tools;
        }

        //Get Issuer by id
        public Issuer? GetIssuerById(int id)
        {
            return _dataContext.Issuers
                .Where(i => i.IssuerId == id)
                .Where(i => i.Deleted == false)
                .FirstOrDefault();
        }

        //Get Issuers
        public IssuerResponse GetIssuers(int page, string? shortName, string? issuerName, string? entityClip, string? entityForm, string? legalForm, string? country)
        {
            IQueryable<Issuer> issuer = _dataContext.Issuers;

            if (page <= 0)
                page = 1;

            var pageResults = 4f;
            var pageCount = Math.Ceiling(_dataContext.Issuers.Count() / pageResults);

            if (!string.IsNullOrEmpty(shortName))
                issuer = issuer.Where(m => m.ShortName == shortName);
            if (!string.IsNullOrEmpty(issuerName))
                issuer = issuer.Where(m => m.IssuerName == issuerName);
            if (!string.IsNullOrEmpty(entityClip))
                issuer = issuer.Where(m => m.EntityClip == entityClip);
            if (!string.IsNullOrEmpty(entityForm))
                issuer = issuer.Where(m => m.EntityFormId == _tools.GetEntityFormId(entityForm));
            if (!string.IsNullOrEmpty(legalForm))
                issuer = issuer.Where(m => m.LegalFormId == _tools.GetLegalFormId(legalForm));
            if (!string.IsNullOrEmpty(country))
                issuer = issuer.Where(m => m.CountryId == _tools.GetCountryId(country));

            var result = issuer
                            .Skip((page - 1) * (int)pageResults)
                            .Take((int)pageResults)
                            .ToList();
            var response = new IssuerResponse
            {
                Issuers = result,
                Pages = (int)pageCount,
                CurrentPage = page
            };
           
            return response;
        }
    }
}
