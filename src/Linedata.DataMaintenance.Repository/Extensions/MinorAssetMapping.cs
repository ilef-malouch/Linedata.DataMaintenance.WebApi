using Linedata.DataMaintenance.Repository.Models;
using Microsoft.EntityFrameworkCore;

namespace Linedata.DataMaintenance.Repository.Extensions
{
    public static class MinorAssetMapping
    {
        public static void MinorAssetMap(this ModelBuilder modelbuilder)
        {
            modelbuilder.Entity<MinorAsset>(entity =>
            {
                entity.ToTable("minor_asset");
                entity.Property(e => e.MinorAssetId).HasColumnType("smallint").HasColumnName("minor_asset_code");
                entity.Property(e => e.Mnemonic).HasColumnType("nvarchar(8)").HasColumnName("mnemonic");
                entity.Property(e => e.Description).HasColumnType("nvarchar(40)").HasColumnName("description");
                entity.Property(e => e.PricingFactor).HasColumnType("float").HasColumnName("pricing_factor");
                entity.Property(e => e.IncomeFactor).HasColumnType("float").HasColumnName("income_factor");
            });
        }
    }
}
