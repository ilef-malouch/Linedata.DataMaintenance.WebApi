using Linedata.DataMaintenance.Repository.Models;
using Microsoft.EntityFrameworkCore;

namespace Linedata.DataMaintenance.Repository.Extensions
{
    public static class MortgageTypeMapping
    {
        public static void MortgageTypeMap(this ModelBuilder modelbuilder)
        {
            modelbuilder.Entity<MortgageType>(entity =>
            {
                entity.ToTable("tba_umb_mortgage_type");
                entity.Property(e => e.MortgageTypeId).HasColumnType("smallint").HasColumnName("tba_umb_mortgage_type_code");
                entity.Property(e => e.MortgageTypeDesc).HasColumnType("nvarchar(60)").HasColumnName("mortgage_type_desc");
                entity.Property(e => e.ProductTypeId).HasColumnType("smallint").HasColumnName("tba_umb_product_type_code");
                entity.Property(e => e.AgencyTypeId).HasColumnType("smallint").HasColumnName("tba_umb_agency_type_code");
                entity.Property(e => e.MaturityTypeId).HasColumnType("smallint").HasColumnName("tba_umb_maturity_type_code");
                entity.Property(e => e.GenericTicker).HasColumnType("nvarchar(40)").HasColumnName("generic_ticker");
                entity.Property(e => e.SettlementClass).HasColumnType("nchar(1)").HasColumnName("settlement_class");
                entity.Property(e => e.DefaultingIssuerId).HasColumnType("numeric(10, 0)").HasColumnName("defaulting_issuer_id");
            });
        }
    }
}
