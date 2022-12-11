using Linedata.DataMaintenance.Repository.Models;
using Microsoft.EntityFrameworkCore;

namespace Linedata.DataMaintenance.Repository.Extensions
{
    public static class CmplSecurityTypeMapping
    {
        public static void CmplSecurityTypeMap(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CmplSecurityType>(entity =>
            {
                entity.ToTable("cmpl_security_type");

                entity.Property(e => e.CmplSecurityTypeId)
                    .HasColumnType("numeric(10, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("cmpl_security_type_id");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("numeric(10, 0)")
                    .HasColumnName("created_by");

                entity.Property(e => e.CreatedTime)
                    .HasColumnType("datetime")
                    .HasColumnName("created_time");

                entity.Property(e => e.Deleted).HasColumnName("deleted");

                entity.Property(e => e.Mnemonic)
                    .HasMaxLength(12)
                    .HasColumnName("mnemonic");

                entity.Property(e => e.ModifiedBy)
                    .HasColumnType("numeric(10, 0)")
                    .HasColumnName("modified_by");

                entity.Property(e => e.ModifiedTime)
                    .HasColumnType("datetime")
                    .HasColumnName("modified_time");

                entity.Property(e => e.Name)
                    .HasMaxLength(40)
                    .HasColumnName("name");

                entity.Property(e => e.StandardType).HasColumnName("standard_type");
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
