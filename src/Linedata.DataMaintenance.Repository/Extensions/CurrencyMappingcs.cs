using Linedata.DataMaintenance.Repository.Models;
using Microsoft.EntityFrameworkCore;

namespace Linedata.DataMaintenance.Repository.Extensions
{
    public static class CurrencyMappingcs
    {
        public static void CurrencyMap(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Currency>(entity =>
            {
                entity.HasKey(e => e.SecurityId)
                    .HasName("currency_pk");

                entity.ToTable("currency");

                entity.HasIndex(e => e.Mnemonic, "currency_ix0")
                    .IsUnique();

                entity.Property(e => e.SecurityId)
                    .HasColumnType("numeric(10, 0)")
                    .HasColumnName("security_id");

                entity.Property(e => e.AsofTime).HasColumnName("asof_time");

                entity.Property(e => e.Closing).HasColumnName("closing");

                entity.Property(e => e.CurrencyAuditId)
                    .HasColumnType("numeric(10, 0)")
                    .HasColumnName("currency_audit_id");

                entity.Property(e => e.Dated)
                    .HasColumnType("datetime")
                    .HasColumnName("dated");

                entity.Property(e => e.DoNotAudit).HasColumnName("do_not_audit");

                entity.Property(e => e.ExchangeRate).HasColumnName("exchange_rate");

                entity.Property(e => e.InvalidFlag).HasColumnName("invalid_flag");

                entity.Property(e => e.MarketValueRounding)
                    .HasColumnName("market_value_rounding")
                    .HasDefaultValueSql("((2))");

                entity.Property(e => e.Mnemonic)
                    .HasMaxLength(8)
                    .HasColumnName("mnemonic");

                entity.Property(e => e.Opening).HasColumnName("opening");

                entity.Property(e => e.ReviewComment)
                    .HasMaxLength(255)
                    .HasColumnName("review_comment");

                entity.Property(e => e.ReviewerId)
                    .HasColumnType("numeric(10, 0)")
                    .HasColumnName("reviewer_id");

                entity.Property(e => e.SystemCurrency).HasColumnName("system_currency");

                entity.Property(e => e.ValidationDate)
                    .HasColumnType("datetime")
                    .HasColumnName("validation_date");
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
