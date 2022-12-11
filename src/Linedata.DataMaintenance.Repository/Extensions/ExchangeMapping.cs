using Linedata.DataMaintenance.Repository.Models;
using Microsoft.EntityFrameworkCore;

namespace Linedata.DataMaintenance.Repository.Extensions
{
    public static class ExchangeMapping
    {
        public static void ExchangeMap(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Exchange>(entity =>
            {
                entity.HasKey(e => e.ExchangeId)
                    .HasName("exchange_pk");

                entity.ToTable("exchange");

                entity.Property(e => e.ExchangeId)
                    .HasColumnType("numeric(10, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("exchange_code");

                entity.Property(e => e.AsofTime).HasColumnName("asof_time");

                entity.Property(e => e.ClientExchangeId)
                    .HasMaxLength(40)
                    .HasColumnName("client_exchange_code");

                entity.Property(e => e.ClosingHour).HasColumnName("closing_hour");

                entity.Property(e => e.ClosingMinute).HasColumnName("closing_minute");

                entity.Property(e => e.CommissionTypeId).HasColumnName("commission_type_code");

                entity.Property(e => e.CountryId)
                    .HasColumnType("numeric(10, 0)")
                    .HasColumnName("country_code");

                entity.Property(e => e.DoNotAudit).HasColumnName("do_not_audit");

                entity.Property(e => e.ExchangeAuditId)
                    .HasColumnType("numeric(10, 0)")
                    .HasColumnName("exchange_audit_id");

                entity.Property(e => e.ExchangeCcpId)
                    .HasColumnType("numeric(10, 0)")
                    .HasColumnName("exchange_ccp_id");

                entity.Property(e => e.ExchangeFeeId).HasColumnName("exchange_fee_code");

                entity.Property(e => e.LastMkt)
                    .HasMaxLength(8)
                    .HasColumnName("last_mkt");

                entity.Property(e => e.Listed).HasColumnName("listed");

                entity.Property(e => e.Mnemonic)
                    .HasMaxLength(8)
                    .HasColumnName("mnemonic");

                entity.Property(e => e.ModifiedBy)
                    .HasColumnType("numeric(10, 0)")
                    .HasColumnName("modified_by");

                entity.Property(e => e.Name)
                    .HasMaxLength(40)
                    .HasColumnName("name");

                entity.Property(e => e.OpeningHour)
                    .HasColumnName("opening_hour")
                    .HasDefaultValueSql("((9))");

                entity.Property(e => e.OpeningMinute)
                    .HasColumnName("opening_minute")
                    .HasDefaultValueSql("((30))");

                entity.Property(e => e.Rounding).HasColumnName("rounding");

                entity.Property(e => e.SourceSystemId)
                    .HasColumnType("numeric(10, 0)")
                    .HasColumnName("source_system_id");

                entity.Property(e => e.TimeZoneId)
                    .HasColumnType("numeric(10, 0)")
                    .HasColumnName("time_zone_code");

                entity.Property(e => e.UserId1)
                    .HasMaxLength(40)
                    .HasColumnName("user_id_1");

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
