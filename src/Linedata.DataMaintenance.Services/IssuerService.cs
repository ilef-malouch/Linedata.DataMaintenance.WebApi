using Linedata.DataMaintenance.Repository;
using Linedata.DataMaintenance.Shared.DataAccess;
using Linedata.DataMaintenance.Shared.DTOs;

namespace Linedata.DataMaintenance.Services
{
    public class IssuerService : IIssuerService
    {
        private IIssuerRepo _issuerRepo;
        private readonly ITools _tools;
        public IssuerService(IIssuerRepo issuerRepo, ITools tools)
        {
            _issuerRepo = issuerRepo;
            _tools = tools;
        }

        //GET ISSUER BY ID
        public IssuerDto GetIssuerById(int id)
        {
            var s = _issuerRepo.GetIssuerById(id);
            if (s == null)
                return null;

            return (new IssuerDto()
            {
                  ShortName = s.ShortName ,
                  IssuerName = s.IssuerName,
                  EntityClip = s.EntityClip,
                  EntityForm = _tools.GetEntityFormMnemonic(s.EntityFormId),
                  LegalForm = _tools.GetLegalFormMnemonic(s.LegalFormId),
                  Country = _tools.GetCountryMnemonic(s.CountryId),
                  UserId1 = s.UserId1,
                  UserId2 = s.UserId2,
                  UserId3 = s.UserId3,
                  UserId4 = s.UserId4,
                  UserId5 = s.UserId5,
                  UserId6 = s.UserId6,
                  UserId7 = s.UserId7,
                  UserId8 = s.UserId8,
                  Counterparty = _tools.GetCounterpartyMnemonic(s.CounterpartyId) 
            });
        }


        public IssuerResponseDto GetIssuers(int page, string? shortName, string? issuerName, string? entityClip, string? entityForm, string? legalForm, string? country)
        { var issuer = _issuerRepo.GetIssuers(page, shortName, issuerName, entityClip, entityForm, legalForm, country);
            
            List<IssuerDto> issuersdto = issuer.Issuers.Select(s => new IssuerDto()
                {
                    ShortName = s.ShortName,
                    IssuerName = s.IssuerName,
                    EntityClip = s.EntityClip,
                    EntityForm = _tools.GetEntityFormMnemonic(s.EntityFormId),
                    LegalForm = _tools.GetLegalFormMnemonic(s.LegalFormId),
                    Country = _tools.GetCountryMnemonic(s.CountryId),
                    UserId1 = s.UserId1,
                    UserId2 = s.UserId2,
                    UserId3 = s.UserId3,
                    UserId4 = s.UserId4,
                    UserId5 = s.UserId5,
                    UserId6 = s.UserId6,
                    UserId7 = s.UserId7,
                    UserId8 = s.UserId8,
                    Counterparty = _tools.GetCounterpartyMnemonic(s.CounterpartyId)
                }).ToList();
            var result = new IssuerResponseDto
            {
                Issuers = issuersdto,
                Pages = issuer.Pages,
                CurrentPage = issuer.CurrentPage
            };
            return result;
                

        }


    }
}
