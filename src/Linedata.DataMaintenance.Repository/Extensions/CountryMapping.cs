using Linedata.DataMaintenance.Repository.Models;
using Microsoft.EntityFrameworkCore;

namespace Linedata.DataMaintenance.Repository.Extensions
{
    public static class CountryMapping
    {
        public static void CountryMap(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Country>(entity =>
             {
                 entity.HasKey(e => e.CountryId)
                     .HasName("country_pk");

                 entity.ToTable("country");

                 entity.HasIndex(e => e.Mnemonic, "country_ix0")
                     .IsUnique();

                 entity.Property(e => e.CountryId)
                     .HasColumnType("numeric(10, 0)")
                     .ValueGeneratedOnAdd()
                     .HasColumnName("country_code");

                 entity.Property(e => e.AsofTime).HasColumnName("asof_time");

                 entity.Property(e => e.CountryAuditId)
                     .HasColumnType("numeric(10, 0)")
                     .HasColumnName("country_audit_id");

                 entity.Property(e => e.DoNotAudit).HasColumnName("do_not_audit");

                 entity.Property(e => e.EmuFlag).HasColumnName("emu_flag");

                 entity.Property(e => e.Mnemonic)
                     .HasMaxLength(8)
                     .HasColumnName("mnemonic");

                 entity.Property(e => e.ModifiedBy)
                     .HasColumnType("numeric(10, 0)")
                     .HasColumnName("modified_by");

                 entity.Property(e => e.Name)
                     .HasMaxLength(40)
                     .HasColumnName("name");

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
