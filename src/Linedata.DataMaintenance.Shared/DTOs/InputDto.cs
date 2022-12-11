using System.ComponentModel.DataAnnotations;

namespace Linedata.DataMaintenance.Shared.DTOs
{
    public class InputDto
    {
        public string? Type { get; set; } //MinorAssetId
        public int Id { get; set; } = 0;
        //Identifiers
        [Required(ErrorMessage = "Symbol is required.")]
        public string Symbol { get; set; }
       
        //Issuer

        
        //Name & Description
        [Required(ErrorMessage = "Name is required.")]
        public string Name { get; set; } //Name1
        //public string? LookthroughModel { get; set; } //LookthroughModelId
        public short? LookthroughDepthLimit { get; set; }
        //Description
        public string? NAICSCode { get; set; } // SicId
        public short? SecurityAttribute { get; set; }
        public string? Mnemonic { get; set; } //CmplSecurityTypeId
        public string? NameCmp { get; set; } //CmplSecurityTypeId


        //Exchange & currency
        public string? Country { get; set; } //CoutryId
        public string? Exchange { get; set; } //ExchangeId
        public string? CountryOfRisk { get; set; } //RiskCountryId
        //public string? CCP { get; set; } //OtcCcpId
        public string? PrincipalCurrency { get; set; } //PrincipalCurrencyId
        public string? IncomeCurrency { get; set; } //IncomeCurrencyId
        public string? LegacyCurrency { get; set; } //LegacyCurrencyId
        public string? SettlementCurrency { get; set; } //SettlementCurrencyId
        public double? LotSizeException { get; set; } //LotSize

        //Price & Dividend
        public double? IssuePrice { get; set; }
        public double? AnnualDividendRate { get; set; }
        public double? ParValue { get; set; }
        //DividendFrequency
        //DividendDayCount
        public double PricingFactor { get; set; }
        public double IncomeFactor { get; set; }
        //openingPrice
        //ClosingPrice


        //Issue Information
        public double? SharesOutstanding { get; set; }
        public string? ShareClass { get; set; }
        public double? VotesPerShare { get; set; }
        public short? HoldingPeriod { get; set; }
        public byte? SettlementDaysOverride { get; set; }
        public bool AdrFlag { get; set; }
        public bool PrivatePlacement { get; set; }
        public bool SecuritiesRelatedFlag { get; set; }
        public bool DtcEligibleFlag { get; set; }
        public byte? RegulationSFlag { get; set; }
        public bool Section144aFlag { get; set; }
        public bool IlliquidFlag { get; set; }
        public bool AffiliatedCoFlag { get; set; }
        public bool RegisteredFlag { get; set; }


        //Analytics


        //Quality Rating

        //Dividend Information

        //Schedules

        //User Data
    }
}
