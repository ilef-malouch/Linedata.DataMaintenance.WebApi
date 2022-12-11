using Linedata.DataMaintenance.Repository.Extensions;
using Microsoft.EntityFrameworkCore;

namespace Linedata.DataMaintenance.Repository.Models
{
    public partial class DataContext : DbContext
    {
        public DataContext()
        {}

        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {}

        public DbSet<Security> Securities { get; set; } = null!;
        public DbSet<MinorAsset> MinorAssets { get; set; } = null!;
        public DbSet<MajorAsset> MajorAssets { get; set; } = null!;
        public DbSet<SettlementMonth> SettlementMonths { get; set; } = null!;
        public DbSet<MortgageType> Mortgages { get; set; } = null!;
        public DbSet<Issuer> Issuers { get; set; } = null!;
        public DbSet<Country> Countries { get; set; } = null!;
        public DbSet<Exchange> Exchanges { get; set; } = null!;
        public DbSet<LotSizeException> LotSizeExceptions { get; set; } = null!; 
        public DbSet<CmplSecurityType> CmplSecurityTypes { get; set; } = null!;
        public DbSet<Currency> Currencies { get; set; } = null!;
        public DbSet<EntityForm> EntityForms { get; set; } = null!;
        public DbSet<LegalForm> LegalForms { get; set; } = null!;
        public DbSet<Sic> Sics { get; set; } = null!;
        public DbSet<Counterparty> Counterparty { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                // To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=.\\MSSQLSERVER01;Database=mkt8100;Trusted_Connection=True;timeout=180");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.SecurityMap();
            modelBuilder.MinorAssetMap();
            modelBuilder.MajorAssetMap();
            modelBuilder.SettlementMonthMap();
            modelBuilder.MortgageTypeMap();
            modelBuilder.IssuertMap();
            modelBuilder.CountryMap();
            modelBuilder.ExchangeMap();
            modelBuilder.LotSizeExceptionMap();
            modelBuilder.CmplSecurityTypeMap();
            modelBuilder.CurrencyMap();
            modelBuilder.EntityFormMap();
            modelBuilder.LegalFormMap();
            modelBuilder.SicMap();
            modelBuilder.CounterpartyMap();

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }

}
