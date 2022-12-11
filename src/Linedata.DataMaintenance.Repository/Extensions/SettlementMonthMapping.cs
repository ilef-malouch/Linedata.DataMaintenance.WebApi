using Linedata.DataMaintenance.Repository.Models;
using Microsoft.EntityFrameworkCore;

namespace Linedata.DataMaintenance.Repository.Extensions
{
    public static class SettlementMonthMapping
    {
        public static void SettlementMonthMap(this ModelBuilder modelbuilder)
        {
            modelbuilder.Entity<SettlementMonth>(entity =>
            {
                entity.ToTable("tba_umb_settlement_month");
                entity.Property(e => e.SettlementMonthId).HasColumnType("smallint").HasColumnName("tba_umb_settlement_month_code");
                entity.Property(e => e.SettlementMonthDesc).HasColumnType("nvarchar(20)").HasColumnName("settlement_month_desc");
                entity.Property(e => e.SettlementMonthCusipChar).HasColumnType("nchar(1)").HasColumnName("settlement_month_cusip_char");
            });
        }
    }
}
