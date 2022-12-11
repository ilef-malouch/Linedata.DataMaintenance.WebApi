using Linedata.DataMaintenance.Repository.Models;
using Microsoft.EntityFrameworkCore;

namespace Linedata.DataMaintenance.Repository.Extensions
{
    public static class IssuerMapping
    {
        public static void IssuertMap(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Issuer>(entity =>
            {
                entity.ToTable("issuer");

                entity.HasIndex(e => new { e.IssuerName, e.IssuerId }, "issuer_ix0");

                entity.HasIndex(e => e.CounterpartyId, "issuer_ix1");

                entity.HasIndex(e => new { e.ShortName, e.IssuerId }, "issuer_ix2");

                entity.Property(e => e.IssuerId)
                    .HasColumnType("numeric(10, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("issuer_id");

                entity.Property(e => e.AddressCountry)
                    .HasColumnType("numeric(10, 0)")
                    .HasColumnName("address_country");

                entity.Property(e => e.AsofTime).HasColumnName("asof_time");

                entity.Property(e => e.City)
                    .HasMaxLength(40)
                    .HasColumnName("city");

                entity.Property(e => e.ClientIssuerId)
                    .HasMaxLength(40)
                    .HasColumnName("client_issuer_id");

                entity.Property(e => e.CounterpartyId)
                    .HasColumnType("numeric(10, 0)")
                    .HasColumnName("counterparty_id");

                entity.Property(e => e.CountryId)
                    .HasColumnType("numeric(10, 0)")
                    .HasColumnName("country_code");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("numeric(10, 0)")
                    .HasColumnName("created_by");

                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasColumnName("created_time");

                entity.Property(e => e.Deleted).HasColumnName("deleted");

                entity.Property(e => e.Department)
                    .HasMaxLength(40)
                    .HasColumnName("department");

                entity.Property(e => e.DoNotAudit).HasColumnName("do_not_audit");

                entity.Property(e => e.DomicileCountryId)
                    .HasColumnType("numeric(10, 0)")
                    .HasColumnName("domicile_country_code");

                entity.Property(e => e.EntityClip)
                    .HasMaxLength(6)
                    .HasColumnName("entity_clip");

                entity.Property(e => e.EntityFormId).HasColumnName("entity_form_code");

                entity.Property(e => e.InactiveFlag).HasColumnName("inactive_flag");

                entity.Property(e => e.IncCountryId)
                    .HasColumnType("numeric(10, 0)")
                    .HasColumnName("inc_country_code");

                entity.Property(e => e.InceptionDate)
                    .HasColumnType("datetime")
                    .HasColumnName("inception_date");

                entity.Property(e => e.IssuerAuditId)
                    .HasColumnType("numeric(10, 0)")
                    .HasColumnName("issuer_audit_id");

                entity.Property(e => e.IssuerName)
                    .HasMaxLength(255)
                    .HasColumnName("issuer_name");

                entity.Property(e => e.LegalFormId).HasColumnName("legal_form_code");

                entity.Property(e => e.ModifiedBy)
                    .HasColumnType("numeric(10, 0)")
                    .HasColumnName("modified_by");

                entity.Property(e => e.ModifiedTime)
                    .HasColumnType("datetime")
                    .HasColumnName("modified_time");

                entity.Property(e => e.PhoneIndex)
                    .HasColumnType("numeric(10, 0)")
                    .HasColumnName("phone_index")
                    .HasDefaultValueSql("((-1))");

                entity.Property(e => e.PostalId)
                    .HasMaxLength(10)
                    .HasColumnName("postal_code");

                entity.Property(e => e.RiskCountryId)
                    .HasColumnType("numeric(10, 0)")
                    .HasColumnName("risk_country_code");

                entity.Property(e => e.ShortName)
                    .HasMaxLength(255)
                    .HasColumnName("short_name");

                entity.Property(e => e.SicId)
                    .HasMaxLength(6)
                    .HasColumnName("sic_code");

                entity.Property(e => e.SourceSystemId).HasColumnName("source_system_id");

                entity.Property(e => e.State)
                    .HasMaxLength(6)
                    .HasColumnName("state")
                    .IsFixedLength();

                entity.Property(e => e.Street)
                    .HasMaxLength(40)
                    .HasColumnName("street");

                entity.Property(e => e.TotalEquityOutstanding).HasColumnName("total_equity_outstanding");

                entity.Property(e => e.TotalLoansOutstanding).HasColumnName("total_loans_outstanding");

                entity.Property(e => e.TotalMarketCapitalization).HasColumnName("total_market_capitalization");

                entity.Property(e => e.TotalMmktOutstanding).HasColumnName("total_mmkt_outstanding");

                entity.Property(e => e.TotalNonVotingShares).HasColumnName("total_non_voting_shares");

                entity.Property(e => e.TotalParentVotingShares).HasColumnName("total_parent_voting_shares");

                entity.Property(e => e.TotalPrincipalOutstanding).HasColumnName("total_principal_outstanding");

                entity.Property(e => e.TotalVotingShares).HasColumnName("total_voting_shares");

                entity.Property(e => e.UltimateParentIssuerId)
                    .HasColumnType("numeric(10, 0)")
                    .HasColumnName("ultimate_parent_issuer_id");

                entity.Property(e => e.UserField1)
                    .HasMaxLength(32)
                    .HasColumnName("user_field_1");

                entity.Property(e => e.UserField10)
                    .HasMaxLength(32)
                    .HasColumnName("user_field_10");

                entity.Property(e => e.UserField11)
                    .HasMaxLength(32)
                    .HasColumnName("user_field_11");

                entity.Property(e => e.UserField12)
                    .HasMaxLength(32)
                    .HasColumnName("user_field_12");

                entity.Property(e => e.UserField13).HasColumnName("user_field_13");

                entity.Property(e => e.UserField14).HasColumnName("user_field_14");

                entity.Property(e => e.UserField15).HasColumnName("user_field_15");

                entity.Property(e => e.UserField16).HasColumnName("user_field_16");

                entity.Property(e => e.UserField2)
                    .HasMaxLength(32)
                    .HasColumnName("user_field_2");

                entity.Property(e => e.UserField3)
                    .HasMaxLength(32)
                    .HasColumnName("user_field_3");

                entity.Property(e => e.UserField4)
                    .HasMaxLength(32)
                    .HasColumnName("user_field_4");

                entity.Property(e => e.UserField5).HasColumnName("user_field_5");

                entity.Property(e => e.UserField6).HasColumnName("user_field_6");

                entity.Property(e => e.UserField7).HasColumnName("user_field_7");

                entity.Property(e => e.UserField8).HasColumnName("user_field_8");

                entity.Property(e => e.UserField9)
                    .HasMaxLength(32)
                    .HasColumnName("user_field_9");

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
   
