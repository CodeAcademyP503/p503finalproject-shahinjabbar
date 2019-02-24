using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProviderAPI.Models.Bank;
using ProviderAPI.Models.Entertainment;
using ProviderAPI.Models.E_Wallet;
using ProviderAPI.Models.Internet;
using ProviderAPI.Models.LanguageConfiguration;
using ProviderAPI.Models.Mobile;
using ProviderAPI.Models.Phone;
using ProviderAPI.Models.State;
using ProviderAPI.Models.TV;
using ProviderAPI.Models.Utility;

namespace ProviderAPI.Models.Context
{
    public class APIDBContext : DbContext
    {
        public APIDBContext(DbContextOptions<APIDBContext> dbContextOptions) : base(dbContextOptions)
        {

        }

        public DbSet<Azercell> Azercells { get; set; }

        public DbSet<Nar> Nars { get; set; }

        public DbSet<Bakcell> Bakcells { get; set; }

        public DbSet<Naxtel> Naxtels { get; set; }

        public DbSet<Prefix> Prefix { get; set; }

        public DbSet<AzerIshiq> AzerIshiqs { get; set; }

        public DbSet<AzerSu> AzerSus { get; set; }

        public DbSet<AzeriQaz> AzeriQazes { get; set; }

        public DbSet<UtilityPrefix> UtilityPrefixes { get; set; }

        public DbSet<AccessBank> AccessBanks { get; set; }

        public DbSet<AtaBank> AtaBanks { get; set; }

        public DbSet<AzerTurkBank> AzerTurkBanks { get; set; }

        public DbSet<BankOfBaku> BankOfBakus { get; set; }

        public DbSet<BankRespublika> BankRespublikas { get; set; }

        public DbSet<ExpressBank> ExpressBanks { get; set; }

        public DbSet<XalqBank> XalqBanks { get; set; }

        public DbSet<Irshad> Irshads { get; set; }

        public DbSet<KapitalBank> KapitalBanks { get; set; }

        public DbSet<UniBank> UniBanks { get; set; }

        public DbSet<VN> Vns { get; set; }

        public DbSet<AlfanetTv> AlfanetTvs { get; set; }

        public DbSet<ClipTv> ClipTvs { get; set; }

        public DbSet<Avirtel> Avirtels { get; set; }

        public DbSet<AzerOnline> AzerOnlines { get; set; }

        public DbSet<AzeuroTel> AzeuroTels { get; set; }

        public DbSet<Azincom> Azincoms { get; set; }

        public DbSet<AzeuroTelPhone> AzeuroTelPhones { get; set; }

        public DbSet<Catel> Catels { get; set; }

        public DbSet<DrWeb> DrWebs { get; set; }

        public DbSet<Eset> Esets { get; set; }

        public DbSet<Kaspersky> Kasperskies { get; set; }

        public DbSet<EntertainmentPrefix> EntertainmentPrefixes { get; set; }

        public DbSet<AzerPay> AzerPays { get; set; }

        public DbSet<PortManat> PortManats { get; set; }

        public DbSet<LangConfig> LangConfigs { get; set; }

        public DbSet<StatePrefix> StatePrefixes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Azercell>()
                .Property(x => x.Balance).HasColumnType("decimal(8,2)");


            modelBuilder.Entity<Bakcell>()
                .Property(x => x.Balance).HasColumnType("decimal(8,2)");

            modelBuilder.Entity<Nar>()
                .Property(x => x.Balance).HasColumnType("decimal(8,2)");

            modelBuilder.Entity<Naxtel>()
                .Property(x => x.Balance).HasColumnType("decimal(8,2)");

            modelBuilder.Entity<AzeriQaz>()
                .Property(x => x.Balance).HasColumnType("decimal(8,2)");

            modelBuilder.Entity<AzerIshiq>()
                .Property(x => x.Balance).HasColumnType("decimal(8,2)");

            modelBuilder.Entity<AzerSu>()
                .Property(x => x.Balance).HasColumnType("decimal(8,2)");

            modelBuilder.Entity<AccessBank>()
                .Property(x => x.Balance).HasColumnType("decimal(8,2)");

            modelBuilder.Entity<AtaBank>()
                .Property(x => x.Balance).HasColumnType("decimal(8,2)");

            modelBuilder.Entity<AzerTurkBank>()
                .Property(x => x.Balance).HasColumnType("decimal(8,2)");

            modelBuilder.Entity<BankOfBaku>()
                .Property(x => x.Balance).HasColumnType("decimal(8,2)");

            modelBuilder.Entity<BankRespublika>()
                .Property(x => x.Balance).HasColumnType("decimal(8,2)");

            modelBuilder.Entity<ExpressBank>()
                .Property(x => x.Balance).HasColumnType("decimal(8,2)");


            modelBuilder.Entity<XalqBank>()
                .Property(x => x.Balance).HasColumnType("decimal(8,2)");

            modelBuilder.Entity<Irshad>()
                .Property(x => x.Balance).HasColumnType("decimal(8,2)");

            modelBuilder.Entity<KapitalBank>()
                .Property(x => x.Balance).HasColumnType("decimal(8,2)");

            modelBuilder.Entity<UniBank>()
                .Property(x => x.Balance).HasColumnType("decimal(8,2)");

            modelBuilder.Entity<VN>()
                .Property(x => x.Balance).HasColumnType("decimal(8,2)");

            modelBuilder.Entity<AlfanetTv>()
                .Property(x => x.Balance).HasColumnType("decimal(8,2)");

            modelBuilder.Entity<ClipTv>()
                .Property(x => x.Balance).HasColumnType("decimal(8,2)");

            modelBuilder.Entity<Avirtel>()
                .Property(x => x.Balance).HasColumnType("decimal(8,2)");

            modelBuilder.Entity<AzerOnline>()
                .Property(x => x.Balance).HasColumnType("decimal(8,2)");

            modelBuilder.Entity<AzeuroTel>()
                .Property(x => x.Balance).HasColumnType("decimal(8,2)");

            modelBuilder.Entity<Azincom>()
                .Property(x => x.Balance).HasColumnType("decimal(8,2)");

            modelBuilder.Entity<AzeuroTelPhone>()
                .Property(x => x.Balance).HasColumnType("decimal(8,2)");

            modelBuilder.Entity<Catel>()
                .Property(x => x.Balance).HasColumnType("decimal(8,2)");

            modelBuilder.Entity<DrWeb>()
                .Property(x => x.Balance).HasColumnType("decimal(8,2)");

            modelBuilder.Entity<Eset>()
                .Property(x => x.Balance).HasColumnType("decimal(8,2)");

            modelBuilder.Entity<Kaspersky>()
                .Property(x => x.Balance).HasColumnType("decimal(8,2)");

            modelBuilder.Entity<AzerPay>()
                .Property(x => x.Balance).HasColumnType("decimal(8,2)");

            modelBuilder.Entity<PortManat>()
                .Property(x => x.Balance).HasColumnType("decimal(8,2)");
        }
    }
}
