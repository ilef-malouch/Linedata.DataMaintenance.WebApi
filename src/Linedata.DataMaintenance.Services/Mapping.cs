using Linedata.DataMaintenance.Repository;
using Linedata.DataMaintenance.Repository.Models;
using Linedata.DataMaintenance.Shared.DataAccess;
using Linedata.DataMaintenance.Shared.DTOs;

namespace Linedata.DataMaintenance.Services
{
    public class Mapping: IMapping
    {
        private readonly ITools _tools;
        public Mapping (ITools tools)
        {
            _tools = tools;
        }

        public Security MappingInput(InputDto dto)
        {
            
            Security sec = new Security()
            {
                //SecurityId = 12345678,
                Symbol = dto.Symbol,
                
                Name1 = dto.Name,
                //LookthroughModelId
                LookthroughDepthLimit = dto.LookthroughDepthLimit,
                //Description
                // SicId
                SecurityAttribute = dto.SecurityAttribute,
                CmplSecurityTypeId = _tools.GetCmplSecurityTypeId(dto.Mnemonic, dto.Name),

                CountryId = _tools.GetCountryId(dto.Country),
                ExchangeId = _tools.GetExchangeId(dto.Exchange),
                RiskCountryId = _tools.GetCountryId(dto.CountryOfRisk),
                //OtcCcpId = CCP 
                PrincipalCurrencyId = _tools.GetCurrencyId(dto.PrincipalCurrency),
                IncomeCurrencyId = _tools.GetCurrencyId(dto.IncomeCurrency),
                LegacyCurrencyId = _tools.GetCurrencyId(dto.LegacyCurrency),
                SettlementCurrencyId = _tools.GetCurrencyId(dto.SettlementCurrency),
                LotSize = dto.LotSizeException,

                IssuePrice = dto.IssuePrice,
                AnnualDividendRate = dto.AnnualDividendRate,
                ParValue = dto.ParValue,
                //DividendFrequency
                //DividendDayCount
                PricingFactor = dto.PricingFactor,
                IncomeFactor = dto.IncomeFactor,
                //openingPrice
                //ClosingPrice

                SharesOutstanding = dto.SharesOutstanding,
                ShareClass = dto.ShareClass,
                VotesPerShare = dto.VotesPerShare,
                HoldingPeriod = dto.HoldingPeriod,
                SettlementDaysOverride = dto.SettlementDaysOverride,
                AdrFlag = dto.AdrFlag,
                PrivatePlacement = dto.PrivatePlacement,
                SecuritiesRelatedFlag = dto.SecuritiesRelatedFlag,
                DtcEligibleFlag = dto.DtcEligibleFlag,
                RegulationSFlag = dto.RegulationSFlag,
                Section144aFlag = dto.Section144aFlag,
                IlliquidFlag = dto.IlliquidFlag,
                AffiliatedCoFlag =dto.AffiliatedCoFlag,
                RegisteredFlag = dto.AffiliatedCoFlag,
                
                CreatedBy = 4,
                ModifiedBy = 4,
                ModifiedTime = DateTime.Now,
               MinorAssetId = _tools.GetMinorAssetId(dto.Type)
            };
            return sec;
        }

        public Security MappingEquity(EquityDtoInput dto)
        {
            Security sec = this.MappingInput(dto);
            sec.MajorAssetId = _tools.GetMajorAssetId("Equity");
            sec.UserId1 = dto.Ticker;
            sec.UserId2 = dto.Reuters;
            sec.UserId3 = dto.CUSIP;
            sec.UserId4 = dto.SEDOL;
            sec.UserId5 = dto.ISIN;
            
                
            return sec;
        }
        public Security MappingFund(FundDtoInput dto)
        {
            Security sec = this.MappingInput(dto);
            sec.MajorAssetId = _tools.GetMajorAssetId("Fund");
            sec.UserId1 = dto.Ticker;
            sec.UserId3 = dto.CUSIP;
            return sec;
        }

        public Security MappingFutures(FuturesDtoInput dto)
        {
            Security sec = this.MappingInput(dto);
            sec.MajorAssetId = _tools.GetMajorAssetId("Futures");
            return sec;
        }
    }
}
