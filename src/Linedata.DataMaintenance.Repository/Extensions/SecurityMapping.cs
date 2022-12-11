using Linedata.DataMaintenance.Repository.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Data.SqlClient;
using System.ComponentModel.DataAnnotations.Schema;
 

namespace Linedata.DataMaintenance.Repository.Extensions
{
    public static class SecurityMapping
    {
        public static void SecurityMap(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Security>(entity =>
            {
                entity.ToTable("security");

                entity.HasIndex(e => e.Symbol, "security_ix6").IsUnique();
                entity.HasKey(entity => entity.SecurityId);

                entity.Property(e => e.SecurityId)
                    .IsRequired()
                    .HasColumnType("numeric(10, 0)")
                    .HasColumnName("security_id");
                    //.HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
                //.ValueGeneratedOnAddOrUpdate();
                //.HasDefaultValueSql("((-999999999))");


                entity.Property(e => e.AccruedInterestDayCount).HasColumnName("accrued_interest_day_count");

                entity.Property(e => e.ActualPaymentDelay).HasColumnName("actual_payment_delay");

                entity.Property(e => e.AdrFlag).HasColumnName("adr_flag");

                entity.Property(e => e.AffiliatedCoFlag).HasColumnName("affiliated_co_flag");

                entity.Property(e => e.AnnualDividendRate).HasColumnName("annual_dividend_rate");

                entity.Property(e => e.AsofTime).HasColumnName("asof_time");

                entity.Property(e => e.AverageTradingVolume).HasColumnName("average_trading_volume");

                entity.Property(e => e.AveragingBeginDate)
                    .HasColumnType("datetime")
                    .HasColumnName("averaging_begin_date");

                entity.Property(e => e.AveragingEndDate)
                    .HasColumnType("datetime")
                    .HasColumnName("averaging_end_date");

                entity.Property(e => e.BarrierPrice).HasColumnName("barrier_price");

                entity.Property(e => e.BaseRate).HasColumnName("base_rate");

                entity.Property(e => e.BenchmarkSecurityId)
                    .HasColumnType("numeric(10, 0)")
                    .HasColumnName("benchmark_security_id");

                entity.Property(e => e.BondTypeId).HasColumnName("bond_type_code");

                entity.Property(e => e.BusinessDayConvention).HasColumnName("business_day_convention");

                entity.Property(e => e.CallableFlag).HasColumnName("callable_flag");

                entity.Property(e => e.CapRate).HasColumnName("cap_rate");

                entity.Property(e => e.CashSettlementFlag).HasColumnName("cash_settlement_flag");

                entity.Property(e => e.CfiId)
                    .HasMaxLength(6)
                    .HasColumnName("cfi_code");

                entity.Property(e => e.ClientSecurityId)
                    .HasMaxLength(40)
                    .HasColumnName("client_security_id");

                entity.Property(e => e.CmplSecurityTypeId)
                    .HasColumnType("numeric(10, 0)")
                    .HasColumnName("cmpl_security_type_id");

                entity.Property(e => e.CollateralTypeId).HasColumnName("collateral_type_code");

                entity.Property(e => e.ContractMonth).HasColumnName("contract_month");

                entity.Property(e => e.ContractSize).HasColumnName("contract_size");

                entity.Property(e => e.ContractTypeId).HasColumnName("contract_type_code");

                entity.Property(e => e.ContractYear).HasColumnName("contract_year");

                entity.Property(e => e.ConversionCap).HasColumnName("conversion_cap");

                entity.Property(e => e.ConversionPriceRatioFlag).HasColumnName("conversion_price_ratio_flag");

                entity.Property(e => e.ConvertibleFlag).HasColumnName("convertible_flag");

                entity.Property(e => e.CountryId)
                    .HasColumnType("numeric(10, 0)")
                    .HasColumnName("country_code");

                entity.Property(e => e.Coupon).HasColumnName("coupon");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("numeric(10, 0)")
                    .HasColumnName("created_by");

                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasColumnName("created_time");

                entity.Property(e => e.CurveTypeId).HasColumnName("curve_type_code");

                entity.Property(e => e.CustodyTypeId).HasColumnName("custody_type_code");

                entity.Property(e => e.DailyTradingVolume).HasColumnName("daily_trading_volume");

                entity.Property(e => e.DatedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("dated_date");

                entity.Property(e => e.DebtTypeId).HasColumnName("debt_type_code");

                entity.Property(e => e.DefaultDate)
                    .HasColumnType("datetime")
                    .HasColumnName("default_date");

                entity.Property(e => e.Deleted).HasColumnName("deleted");

                entity.Property(e => e.DeliveryId).HasColumnName("delivery_code");

                entity.Property(e => e.DoNotAudit).HasColumnName("do_not_audit");

                entity.Property(e => e.DtcEligibleFlag).HasColumnName("dtc_eligible_flag");

                entity.Property(e => e.EnhancementsId).HasColumnName("enhancements_code");

                entity.Property(e => e.ExDividendDate)
                    .HasColumnType("datetime")
                    .HasColumnName("ex_dividend_date");

                entity.Property(e => e.ExDividendTradingFlag).HasColumnName("ex_dividend_trading_flag");

                entity.Property(e => e.ExchangeId)
                    .HasColumnType("numeric(10, 0)")
                    .HasColumnName("exchange_code");

                entity.Property(e => e.ExerciseStyleId).HasColumnName("exercise_style_code");

                entity.Property(e => e.ExponentialCouponCalcFlag).HasColumnName("exponential_coupon_calc_flag");

                entity.Property(e => e.FixingDate)
                    .HasColumnType("datetime")
                    .HasColumnName("fixing_date");

                entity.Property(e => e.FloorRate).HasColumnName("floor_rate");

                entity.Property(e => e.FutureInflationRate)
                    .HasColumnName("future_inflation_rate")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.HoldingPeriod).HasColumnName("holding_period");

                entity.Property(e => e.IlliquidFlag).HasColumnName("illiquid_flag");

                entity.Property(e => e.InDefaultFlag).HasColumnName("in_default_flag");

                entity.Property(e => e.IncomeCurrencyId)
                    .HasColumnType("numeric(10, 0)")
                    .HasColumnName("income_currency_id");

                entity.Property(e => e.IncomeFactor)
                    .HasColumnName("income_factor")
                    .HasDefaultValueSql("((1.0))");

                entity.Property(e => e.IncomePaymentTypeId)
                    .HasColumnName("income_payment_type_code")
                    .HasDefaultValueSql("((3))");

                entity.Property(e => e.InflationLinkedBondFlag).HasColumnName("inflation_linked_bond_flag");

                entity.Property(e => e.InitialMarginRate).HasColumnName("initial_margin_rate");

                entity.Property(e => e.Isin)
                    .HasMaxLength(40)
                    .HasColumnName("isin");

                entity.Property(e => e.IssueDate)
                    .HasColumnType("datetime")
                    .HasColumnName("issue_date");

                entity.Property(e => e.IssuePrice).HasColumnName("issue_price");

                entity.Property(e => e.IssuerId)
                    .HasColumnType("numeric(10, 0)")
                    .HasColumnName("issuer_id");

                entity.Property(e => e.IssuerTypeId)
                    .HasColumnName("issuer_type_code")
                    .HasDefaultValueSql("((6))");

                entity.Property(e => e.IssuingAgentBrokerId)
                    .HasColumnType("numeric(10, 0)")
                    .HasColumnName("issuing_agent_broker_id");

                entity.Property(e => e.LastCouponDate)
                    .HasColumnType("datetime")
                    .HasColumnName("last_coupon_date");

                entity.Property(e => e.LastResetDate)
                    .HasColumnType("datetime")
                    .HasColumnName("last_reset_date");

                entity.Property(e => e.LegacyCurrencyId)
                    .HasColumnType("numeric(10, 0)")
                    .HasColumnName("legacy_currency_id");

                entity.Property(e => e.LongBondSecurityId)
                    .HasColumnType("numeric(10, 0)")
                    .HasColumnName("long_bond_security_id");

                entity.Property(e => e.LookthroughDepthLimit).HasColumnName("lookthrough_depth_limit");

                entity.Property(e => e.LookthroughModelId)
                    .HasColumnType("numeric(10, 0)")
                    .HasColumnName("lookthrough_model_id");

                entity.Property(e => e.LotSize).HasColumnName("lot_size");

                entity.Property(e => e.MajorAssetId).HasColumnName("major_asset_code");

                entity.Property(e => e.MasterSecurityId)
                    .HasColumnType("numeric(10, 0)")
                    .HasColumnName("master_security_id");

                entity.Property(e => e.MaturityDate)
                    .HasColumnType("datetime")
                    .HasColumnName("maturity_date");

                entity.Property(e => e.MinorAssetId).HasColumnName("minor_asset_code");

                entity.Property(e => e.ModifiedBy)
                    .HasColumnType("numeric(10, 0)")
                    .HasColumnName("modified_by");

                entity.Property(e => e.ModifiedTime)
                    .HasColumnType("datetime")
                    .HasColumnName("modified_time");

                entity.Property(e => e.MunicipalProjectName)
                    .HasMaxLength(255)
                    .HasColumnName("municipal_project_name");

                entity.Property(e => e.Name1)
                    .HasMaxLength(40)
                    .HasColumnName("name_1");

                entity.Property(e => e.Name2)
                    .HasMaxLength(40)
                    .HasColumnName("name_2");

                entity.Property(e => e.Name3)
                    .HasMaxLength(40)
                    .HasColumnName("name_3");

                entity.Property(e => e.Name4)
                    .HasMaxLength(40)
                    .HasColumnName("name_4");

                entity.Property(e => e.NavRelatedIndexId)
                    .HasColumnType("numeric(10, 0)")
                    .HasColumnName("nav_related_index_id");

                entity.Property(e => e.NavRelatedShareClassId)
                    .HasColumnType("numeric(10, 0)")
                    .HasColumnName("nav_related_share_class_id");

                entity.Property(e => e.NavScUseCompBenchVal).HasColumnName("nav_sc_use_comp_bench_val");

                entity.Property(e => e.NewFlag).HasColumnName("new_flag");

                entity.Property(e => e.NextCouponDate)
                    .HasColumnType("datetime")
                    .HasColumnName("next_coupon_date");

                entity.Property(e => e.NextResetDate)
                    .HasColumnType("datetime")
                    .HasColumnName("next_reset_date");

                entity.Property(e => e.OddCouponAccruedDayCount).HasColumnName("odd_coupon_accrued_day_count");

                entity.Property(e => e.OddFirstCouponDate)
                    .HasColumnType("datetime")
                    .HasColumnName("odd_first_coupon_date");

                entity.Property(e => e.OddLastCouponDate)
                    .HasColumnType("datetime")
                    .HasColumnName("odd_last_coupon_date");

                entity.Property(e => e.OidFlag).HasColumnName("OID_flag");

                entity.Property(e => e.OriginalIssueSize).HasColumnName("original_issue_size");

                entity.Property(e => e.OriginalTerm).HasColumnName("original_term");

                entity.Property(e => e.OtcCcpId)
                    .HasColumnType("numeric(10, 0)")
                    .HasColumnName("otc_ccp_id");

                entity.Property(e => e.OutstandingPrincipal).HasColumnName("outstanding_principal");

                entity.Property(e => e.PairClip)
                    .HasMaxLength(9)
                    .HasColumnName("pair_clip");

                entity.Property(e => e.ParValue).HasColumnName("par_value");

                entity.Property(e => e.PaymentId).HasColumnName("payment_code");

                entity.Property(e => e.PaymentDayOfWeek).HasColumnName("payment_day_of_week");

                entity.Property(e => e.PaymentFrequency).HasColumnName("payment_frequency");

                entity.Property(e => e.PaymentFrequencyInterval).HasColumnName("payment_frequency_interval");

                entity.Property(e => e.PayoffAmount).HasColumnName("payoff_amount");

                entity.Property(e => e.PayoffStyleId).HasColumnName("payoff_style_code");

                entity.Property(e => e.PercentOfRateIndex).HasColumnName("percent_of_rate_index");

                entity.Property(e => e.PikFlag).HasColumnName("pik_flag");

                entity.Property(e => e.PoolTrancheType)
                    .HasMaxLength(10)
                    .HasColumnName("pool_tranche_type")
                    .IsFixedLength();

                entity.Property(e => e.PriceIncrement).HasColumnName("price_increment");

                entity.Property(e => e.PriceYieldId).HasColumnName("price_yield_code");

                entity.Property(e => e.PriceYieldDayCount).HasColumnName("price_yield_day_count");

                entity.Property(e => e.PricingFactor)
                    .HasColumnName("pricing_factor")
                    .HasDefaultValueSql("((1.0))");

                entity.Property(e => e.PrincipalCurrencyId)
                    .HasColumnType("numeric(10, 0)")
                    .HasColumnName("principal_currency_id");

                entity.Property(e => e.PrincipalFactor)
                    .HasColumnName("principal_factor")
                    .HasDefaultValueSql("((1.0))");

                entity.Property(e => e.PrincipalFactorDate)
                    .HasColumnType("datetime")
                    .HasColumnName("principal_factor_date");

                entity.Property(e => e.PrincipalPaymentTypeId)
                    .HasColumnName("principal_payment_type_code")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.PrivatePlacement).HasColumnName("private_placement");

                entity.Property(e => e.ProductId)
                    .HasMaxLength(8)
                    .HasColumnName("product_code")
                    .IsFixedLength();

                entity.Property(e => e.PutableFlag).HasColumnName("putable_flag");

                entity.Property(e => e.RateIndexId)
                    .HasColumnType("numeric(10, 0)")
                    .HasColumnName("rate_index_id");

                entity.Property(e => e.RateResetFrequencyId).HasColumnName("rate_reset_frequency_code");

                entity.Property(e => e.RedemptionDate)
                    .HasColumnType("datetime")
                    .HasColumnName("redemption_date");

                entity.Property(e => e.RedemptionValue).HasColumnName("redemption_value");

                entity.Property(e => e.RefundingTypeId).HasColumnName("refunding_type_code");

                entity.Property(e => e.RegisteredFlag).HasColumnName("registered_flag");

                entity.Property(e => e.RegulationSFlag)
                    .HasColumnName("regulation_s_flag")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RepoCollateralMarketValue).HasColumnName("repo_collateral_market_value");

                entity.Property(e => e.RepoCollateralTypeId)
                    .HasColumnType("numeric(10, 0)")
                    .HasColumnName("repo_collateral_type_id");

                entity.Property(e => e.RepoHaircut).HasColumnName("repo_haircut");

                entity.Property(e => e.RepoInvestmentRate).HasColumnName("repo_investment_rate");

                entity.Property(e => e.RepoReferenceIndexId)
                    .HasColumnType("numeric(10, 0)")
                    .HasColumnName("repo_reference_index_id");

                entity.Property(e => e.RepoRequiredCollateralMv).HasColumnName("repo_required_collateral_mv");

                entity.Property(e => e.RepoSpread).HasColumnName("repo_spread");

                entity.Property(e => e.RepoTypeId).HasColumnName("repo_type_code");

                entity.Property(e => e.RiskCountryId)
                    .HasColumnType("numeric(10, 0)")
                    .HasColumnName("risk_country_code");

                entity.Property(e => e.Section144aFlag).HasColumnName("section_144A_flag");

                entity.Property(e => e.SecuritiesRelatedFlag).HasColumnName("securities_related_flag");

                entity.Property(e => e.SecurityAttribute).HasColumnName("security_attribute");

                entity.Property(e => e.SecurityAuditId)
                    .HasColumnType("numeric(10, 0)")
                    .HasColumnName("security_audit_id");

                entity.Property(e => e.SecurityLevelId).HasColumnName("security_level_code");

                entity.Property(e => e.SeniorityId).HasColumnName("seniority_code");

                entity.Property(e => e.ServiceFeeRate).HasColumnName("service_fee_rate");

                entity.Property(e => e.SettlementCurrencyId)
                    .HasColumnType("numeric(10, 0)")
                    .HasColumnName("settlement_currency_id");

                entity.Property(e => e.SettlementDaysOverride).HasColumnName("settlement_days_override");

                entity.Property(e => e.SettlementForm).HasColumnName("settlement_form");

                entity.Property(e => e.ShareClass)
                    .HasMaxLength(2)
                    .HasColumnName("share_class");

                entity.Property(e => e.SharesOutstanding).HasColumnName("shares_outstanding");

                entity.Property(e => e.SicId)
                    .HasMaxLength(6)
                    .HasColumnName("sic_code");

                entity.Property(e => e.SinkingFundFlag).HasColumnName("sinking_fund_flag");

                entity.Property(e => e.SinkingFundTypeId).HasColumnName("sinking_fund_type_code");

                entity.Property(e => e.SourceSystemId).HasColumnName("source_system_id");

                entity.Property(e => e.SpreadOverIndexRate).HasColumnName("spread_over_index_rate");

                entity.Property(e => e.State)
                    .HasMaxLength(2)
                    .HasColumnName("state")
                    .IsFixedLength();

                entity.Property(e => e.StatedPaymentDelay).HasColumnName("stated_payment_delay");

                entity.Property(e => e.StrikePrice).HasColumnName("strike_price");

                entity.Property(e => e.Symbol)
                    .HasMaxLength(40)
                    .HasColumnName("symbol");

                entity.Property(e => e.TaxStatusId).HasColumnName("tax_status_code");

                entity.Property(e => e.TbaUmbMortgageTypeId)
                    .HasColumnType("numeric(10, 0)")
                    .HasColumnName("tba_umb_mortgage_type_code");

                entity.Property(e => e.TbaUmbSettlementMonthId)
                    .HasColumnType("numeric(10, 0)")
                    .HasColumnName("tba_umb_settlement_month_code");

                entity.Property(e => e.UnderlyingCoupon).HasColumnName("underlying_coupon");

                entity.Property(e => e.UnderlyingSecurityId)
                    .HasColumnType("numeric(10, 0)")
                    .HasColumnName("underlying_security_id");

                entity.Property(e => e.UnitTradedBondFlag).HasColumnName("unit_traded_bond_flag");

                entity.Property(e => e.UnitTradedBondSize).HasColumnName("unit_traded_bond_size");

                entity.Property(e => e.UseSimpleInterestFlag).HasColumnName("use_simple_interest_flag");

                entity.Property(e => e.UserField1).HasColumnName("user_field_1");

                entity.Property(e => e.UserField10).HasColumnName("user_field_10");

                entity.Property(e => e.UserField11)
                    .HasMaxLength(32)
                    .HasColumnName("user_field_11");

                entity.Property(e => e.UserField12)
                    .HasMaxLength(32)
                    .HasColumnName("user_field_12");

                entity.Property(e => e.UserField13)
                    .HasMaxLength(32)
                    .HasColumnName("user_field_13");

                entity.Property(e => e.UserField14)
                    .HasMaxLength(32)
                    .HasColumnName("user_field_14");

                entity.Property(e => e.UserField15)
                    .HasMaxLength(32)
                    .HasColumnName("user_field_15");

                entity.Property(e => e.UserField16)
                    .HasMaxLength(32)
                    .HasColumnName("user_field_16");

                entity.Property(e => e.UserField2).HasColumnName("user_field_2");

                entity.Property(e => e.UserField3).HasColumnName("user_field_3");

                entity.Property(e => e.UserField4).HasColumnName("user_field_4");

                entity.Property(e => e.UserField5).HasColumnName("user_field_5");

                entity.Property(e => e.UserField6).HasColumnName("user_field_6");

                entity.Property(e => e.UserField7).HasColumnName("user_field_7");

                entity.Property(e => e.UserField8).HasColumnName("user_field_8");

                entity.Property(e => e.UserField9).HasColumnName("user_field_9");

                entity.Property(e => e.UserFlag1).HasColumnName("user_flag_1");

                entity.Property(e => e.UserFlag2).HasColumnName("user_flag_2");

                entity.Property(e => e.UserId1)
                    .HasMaxLength(40)
                    .HasColumnName("user_id_1");

                entity.Property(e => e.UserId10)
                    .HasMaxLength(40)
                    .HasColumnName("user_id_10");

                entity.Property(e => e.UserId11)
                    .HasMaxLength(40)
                    .HasColumnName("user_id_11");

                entity.Property(e => e.UserId12)
                    .HasMaxLength(40)
                    .HasColumnName("user_id_12");

                entity.Property(e => e.UserId13)
                    .HasMaxLength(40)
                    .HasColumnName("user_id_13");

                entity.Property(e => e.UserId14)
                    .HasMaxLength(40)
                    .HasColumnName("user_id_14");

                entity.Property(e => e.UserId15)
                    .HasMaxLength(40)
                    .HasColumnName("user_id_15");

                entity.Property(e => e.UserId16)
                    .HasMaxLength(40)
                    .HasColumnName("user_id_16");

                entity.Property(e => e.UserId2)
                    .HasMaxLength(40)
                    .HasColumnName("user_id_2");

                entity.Property(e => e.UserId3)
                    .HasMaxLength(40)
                    .HasColumnName("user_id_3");

                entity.Property(e => e.UserId4)
                    .HasMaxLength(40)
                    .HasColumnName("user_id_4");

                entity.Property(e => e.UserId5)
                    .HasMaxLength(40)
                    .HasColumnName("user_id_5");

                entity.Property(e => e.UserId6)
                    .HasMaxLength(40)
                    .HasColumnName("user_id_6");

                entity.Property(e => e.UserId7)
                    .HasMaxLength(40)
                    .HasColumnName("user_id_7");

                entity.Property(e => e.UserId8)
                    .HasMaxLength(40)
                    .HasColumnName("user_id_8");

                entity.Property(e => e.UserId9)
                    .HasMaxLength(40)
                    .HasColumnName("user_id_9");

                entity.Property(e => e.VotesPerShare).HasColumnName("votes_per_share");
            });

            modelBuilder.HasSequence<decimal>("seq_placement_read")
                .HasMin(1)
                .HasMax(9999999999)
                .IsCyclic();

            modelBuilder.HasSequence<decimal>("seq_rebal_run")
                .HasMin(1)
                .HasMax(9999999999)
                .IsCyclic();

            modelBuilder.HasSequence<decimal>("seq_send_order_run")
                .HasMin(1)
                .HasMax(9223372036854775807)
                .IsCyclic();
        }
    }
}
