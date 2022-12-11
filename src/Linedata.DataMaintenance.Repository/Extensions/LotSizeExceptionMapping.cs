using Linedata.DataMaintenance.Repository.Models;
using Microsoft.EntityFrameworkCore;

namespace Linedata.DataMaintenance.Repository.Extensions
{
    public static class LotSizeExceptionMapping
    {
        public static void LotSizeExceptionMap(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<LotSizeException>(entity =>
            {
                entity.HasKey(e => e.SecurityId)
                    .HasName("lot_size_exceptions_pk");

                entity.ToTable("lot_size_exceptions");

                entity.Property(e => e.SecurityId)
                    .HasColumnType("numeric(10, 0)")
                    .HasColumnName("security_id");

                entity.Property(e => e.LotSize).HasColumnName("lot_size");
            });
        }
    }
}
