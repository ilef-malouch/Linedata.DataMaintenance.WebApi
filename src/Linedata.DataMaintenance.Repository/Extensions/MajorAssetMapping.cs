using Linedata.DataMaintenance.Repository.Models;
using Microsoft.EntityFrameworkCore;

namespace Linedata.DataMaintenance.Repository.Extensions
{
    public static class MajorAssetMapping
    {
        public static void MajorAssetMap(this ModelBuilder modelbuilder)
        {
            modelbuilder.Entity<MajorAsset>(entity =>
            {
                entity.ToTable("major_asset");
                entity.Property(e => e.MajorAssetId).HasColumnType("smallint").HasColumnName("major_asset_code");
                entity.Property(e => e.Mnemonic).HasColumnType("nvarchar(8)").HasColumnName("mnemonic");
                entity.Property(e => e.Description).HasColumnType("nvarchar(40)").HasColumnName("description");
            });
        }
    }
}
