using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Linedata.DataMaintenance.Repository.Models
{
    public class Security
    {
        public bool Deleted { get; set; } = false;
        public bool NewFlag { get; set; } = false;
        public bool Section144aFlag { get; set; } = false ;
        public bool IlliquidFlag { get; set; } = false;
        public bool PrivatePlacement { get; set; } = false;

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SecurityId { get; set; }
        
        public string Symbol { get; set; } = null!;
        public string Name1 { get; set; } = null!;
        public string? Name2 { get; set; }
        public string? Name3 { get; set; }
        public string? Name4 { get; set; }
        public short? MajorAssetId { get; set; }
        public short? MinorAssetId { get; set; }
        public int? CountryId { get; set; }
        public int? PrincipalCurrencyId { get; set; }
        public int? IncomeCurrencyId { get; set; }
        public int? ExchangeId { get; set; }
        public double PricingFactor { get; set; }
        public double IncomeFactor { get; set; }
        public double PrincipalFactor { get; set; }
        public int? IssuerId { get; set; }
        public string? SicId { get; set; }
        public double? LotSize { get; set; }
        public byte? SettlementDaysOverride { get; set; }
        public int? LegacyCurrencyId { get; set; }
        public double? AnnualDividendRate { get; set; }
        public double? SharesOutstanding { get; set; }
        public string? ShareClass { get; set; }
        public double? VotesPerShare { get; set; }
        public short? HoldingPeriod { get; set; }
        public double? DailyTradingVolume { get; set; }
        public double? AverageTradingVolume { get; set; }
        public bool RegisteredFlag { get; set; }
        public bool DtcEligibleFlag { get; set; }
        public bool AdrFlag { get; set; }
        public bool SecuritiesRelatedFlag { get; set; }
        public bool AffiliatedCoFlag { get; set; }
        public double? ParValue { get; set; }
        public bool CallableFlag { get; set; }
        public bool PutableFlag { get; set; }
        public bool SinkingFundFlag { get; set; }
        public double? Coupon { get; set; }
        public short? PaymentFrequency { get; set; }
        public DateTime? MaturityDate { get; set; }
        public DateTime? IssueDate { get; set; }
        public DateTime? DatedDate { get; set; }
        public double? IssuePrice { get; set; }
        public double? OriginalIssueSize { get; set; }
        public DateTime? RedemptionDate { get; set; }
        public double? RedemptionValue { get; set; }
        public DateTime? PrincipalFactorDate { get; set; }
        public byte? AccruedInterestDayCount { get; set; }
        public byte? OddCouponAccruedDayCount { get; set; }
        public byte? PriceYieldDayCount { get; set; }
        public DateTime? OddFirstCouponDate { get; set; }
        public DateTime? OddLastCouponDate { get; set; }
        public byte? PriceYieldId { get; set; }
        public bool OidFlag { get; set; }
        public bool InDefaultFlag { get; set; }
        public DateTime? ExDividendDate { get; set; }
        public bool ExDividendTradingFlag { get; set; }
        public DateTime? LastCouponDate { get; set; }
        public DateTime? NextCouponDate { get; set; }
        public short? SettlementForm { get; set; }
        public short? DeliveryId { get; set; }
        public byte TaxStatusId { get; set; }
        public byte EnhancementsId { get; set; }
        public byte RefundingTypeId { get; set; }
        public string? State { get; set; }
        public double? ServiceFeeRate { get; set; }
        public byte? StatedPaymentDelay { get; set; }
        public byte? ActualPaymentDelay { get; set; }
        public double? UnderlyingCoupon { get; set; }
        public bool ConversionPriceRatioFlag { get; set; }
        public double? ConversionCap { get; set; }
        public int? SettlementCurrencyId { get; set; }
        public byte? ContractTypeId { get; set; }
        public byte? ExerciseStyleId { get; set; }
        public double? StrikePrice { get; set; }
        public byte? PayoffStyleId { get; set; }
        public double? BarrierPrice { get; set; }
        public DateTime? AveragingBeginDate { get; set; }
        public DateTime? AveragingEndDate { get; set; }
        public double? PayoffAmount { get; set; }
        public int? UnderlyingSecurityId { get; set; }
        public double? ContractSize { get; set; }
        public byte? ContractMonth { get; set; }
        public short? ContractYear { get; set; }
        public bool CashSettlementFlag { get; set; }
        public string? ProductId { get; set; }
        public string? UserId1 { get; set; }
        public string? UserId2 { get; set; }
        public string? UserId3 { get; set; }
        public string? UserId4 { get; set; }
        public string? UserId5 { get; set; }
        public string? UserId6 { get; set; }
        public string? UserId7 { get; set; }
        public string? UserId8 { get; set; }
        public string? UserId9 { get; set; }
        public string? UserId10 { get; set; }
        public string? UserId11 { get; set; }
        public string? UserId12 { get; set; }
        public string? UserId13 { get; set; }
        public string? UserId14 { get; set; }
        public string? UserId15 { get; set; }
        public string? UserId16 { get; set; }
        public double? UserField1 { get; set; }
        public double? UserField2 { get; set; }
        public double? UserField3 { get; set; }
        public double? UserField4 { get; set; }
        public double? UserField5 { get; set; }
        public double? UserField6 { get; set; }
        public double? UserField7 { get; set; }
        public double? UserField8 { get; set; }
        public double? UserField9 { get; set; }
        public double? UserField10 { get; set; }
        public string? UserField11 { get; set; }
        public string? UserField12 { get; set; }
        public string? UserField13 { get; set; }
        public string? UserField14 { get; set; }
        public string? UserField15 { get; set; }
        public string? UserField16 { get; set; }
        public short? SourceSystemId { get; set; }
        public string? ClientSecurityId { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime CreatedTime { get; set; }
        public byte IssuerTypeId { get; set; }
        public byte PrincipalPaymentTypeId { get; set; }
        public byte IncomePaymentTypeId { get; set; }
        public short BondTypeId { get; set; }
        public byte SinkingFundTypeId { get; set; }
        public bool ConvertibleFlag { get; set; }
        public bool PikFlag { get; set; }
        public byte DebtTypeId { get; set; }
        public int? RateIndexId { get; set; }
        public byte RateResetFrequencyId { get; set; }
        public double? PercentOfRateIndex { get; set; }
        public double? SpreadOverIndexRate { get; set; }
        public string? PoolTrancheType { get; set; }
        public short? OriginalTerm { get; set; }
        public byte CollateralTypeId { get; set; }
        public int? IssuingAgentBrokerId { get; set; }
        public byte SecurityLevelId { get; set; }
        public int? MasterSecurityId { get; set; }
        public int? LongBondSecurityId { get; set; }
        public int? BenchmarkSecurityId { get; set; }
        public byte CustodyTypeId { get; set; }
        public DateTime? DefaultDate { get; set; }
        public short? PaymentId { get; set; }
        public double? BaseRate { get; set; }
        public double? CapRate { get; set; }
        public double? FloorRate { get; set; }
        public DateTime? LastResetDate { get; set; }
        public DateTime? NextResetDate { get; set; }
        public short? SecurityAttribute { get; set; }
        public int? CmplSecurityTypeId { get; set; }
        public int? LookthroughModelId { get; set; }
        public bool UserFlag1 { get; set; }
        public bool UserFlag2 { get; set; }
        public string? MunicipalProjectName { get; set; }
        public double? OutstandingPrincipal { get; set; }
        public int? RiskCountryId { get; set; }
        public byte? RegulationSFlag { get; set; }
        public string? PairClip { get; set; }
        public short? SeniorityId { get; set; }
        public int? NavRelatedIndexId { get; set; }
        public double? InitialMarginRate { get; set; }
        public short? CurveTypeId { get; set; }
        public short? TbaUmbMortgageTypeId { get; set; }
        public short? TbaUmbSettlementMonthId { get; set; }
        public int? ModifiedBy { get; set; }
        public int? NavRelatedShareClassId { get; set; }
        public short? NavScUseCompBenchVal { get; set; }
        public int? RepoCollateralTypeId { get; set; }
        public int? RepoReferenceIndexId { get; set; }
        public short? RepoTypeId { get; set; }
        public double? RepoHaircut { get; set; }
        public double? RepoCollateralMarketValue { get; set; }
        public double? RepoRequiredCollateralMv { get; set; }
        public double? RepoInvestmentRate { get; set; }
        public double? RepoSpread { get; set; }
        public short? LookthroughDepthLimit { get; set; }
        public int? SecurityAuditId { get; set; }
        public DateTime? AsofTime { get; set; }
        public byte? DoNotAudit { get; set; }
        public DateTime? ModifiedTime { get; set; }
        public DateTime? FixingDate { get; set; }
        public int? PaymentFrequencyInterval { get; set; }
        public short? PaymentDayOfWeek { get; set; }
        public bool ExponentialCouponCalcFlag { get; set; }
        public bool UseSimpleInterestFlag { get; set; }
        public bool InflationLinkedBondFlag { get; set; }
        public double? FutureInflationRate { get; set; }
        public bool UnitTradedBondFlag { get; set; }
        public double? UnitTradedBondSize { get; set; }
        public double? PriceIncrement { get; set; }
        public short? BusinessDayConvention { get; set; }
        public string? Isin { get; set; }
        public int? OtcCcpId { get; set; }
        public string? CfiId { get; set; }
    }

}
