
using Linedata.DataMaintenance.Repository.Models;
using Microsoft.EntityFrameworkCore;

namespace Linedata.DataMaintenance.Repository.Extensions
{
    public static class EntityFormMapping
    {
        public static void EntityFormMap(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EntityForm>(entity =>
            {
                entity.HasKey(e => e.EntityFormId)
                    .HasName("entity_form_pk");

                entity.ToTable("entity_form");

                entity.Property(e => e.EntityFormId)
                    .ValueGeneratedNever()
                    .HasColumnName("entity_form_code");

                entity.Property(e => e.Description)
                    .HasMaxLength(40)
                    .HasColumnName("description");

                entity.Property(e => e.Mnemonic)
                    .HasMaxLength(20)
                    .HasColumnName("mnemonic");
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
