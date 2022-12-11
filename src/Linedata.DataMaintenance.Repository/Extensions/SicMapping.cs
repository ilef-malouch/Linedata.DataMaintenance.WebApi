using Linedata.DataMaintenance.Repository.Models;
using Microsoft.EntityFrameworkCore;

namespace Linedata.DataMaintenance.Repository.Extensions
{
    public static class SicMapping
    {
        public static void SicMap(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Sic>(entity =>
            {
                entity.HasKey(e => e.SicId)
                    .HasName("sic_pk");

                entity.ToTable("sic");

                entity.Property(e => e.SicId)
                    .HasMaxLength(6)
                    .HasColumnName("sic_code");

                entity.Property(e => e.Deleted).HasColumnName("deleted");

                entity.Property(e => e.ModifiedBy)
                    .HasColumnType("numeric(10, 0)")
                    .HasColumnName("modified_by");

                entity.Property(e => e.ModifiedTime)
                    .HasColumnType("datetime")
                    .HasColumnName("modified_time");

                entity.Property(e => e.SicIdDesc)
                    .HasMaxLength(255)
                    .HasColumnName("sic_code_desc");
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
