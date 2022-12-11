
using Linedata.DataMaintenance.Repository.Models;
using Microsoft.EntityFrameworkCore;

namespace Linedata.DataMaintenance.Repository.Extensions
{
    public static class CounterpartyMapping
    {
        public static void CounterpartyMap(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Counterparty>(entity =>
            {
                entity.HasKey(e => e.CounterpartyId)
                    .HasName("counterparty_pk")
                    .IsClustered(false);

                entity.ToTable("counterparty");

                entity.Property(e => e.CounterpartyId)
                    .HasColumnType("numeric(10, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("counterparty_id");

                entity.Property(e => e.ClientCounterpartyId)
                    .HasMaxLength(40)
                    .HasColumnName("client_counterparty_id");

                entity.Property(e => e.Deleted).HasColumnName("deleted");

                entity.Property(e => e.Mnemonic)
                    .HasMaxLength(20)
                    .HasColumnName("mnemonic");

                entity.Property(e => e.Name)
                    .HasMaxLength(40)
                    .HasColumnName("name");

                entity.Property(e => e.SourceSystemId).HasColumnName("source_system_id");
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
