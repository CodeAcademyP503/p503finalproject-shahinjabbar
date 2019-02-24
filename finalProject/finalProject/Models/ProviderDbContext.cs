using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace finalProject.Models
{
    public class ProviderDbContext : IdentityDbContext<AppUser>
    {
        public ProviderDbContext(DbContextOptions<ProviderDbContext> dbContextOptions) : base(dbContextOptions)
        {

        }

        public DbSet<TopProvider> TopProviders { get; set; }

        public DbSet<LanguageConfiguration> LanguageConfigurations { get; set; }

        public DbSet<IndexPhoto> IndexPhotos { get; set; }

        public DbSet<FooterInfo> FooterInfos { get; set; }

        public DbSet<CoreProvider> CoreProviders { get; set; }

        public DbSet<GroupProvider> GroupProviders { get; set; }

        public DbSet<ProviderHeaderInfo> ProviderHeaderInfos { get; set; }

        public DbSet<ProviderAdditionalInformation> ProviderAdditionalInformations { get; set; }

        public DbSet<ProviderOption> ProviderOptions { get; set; }

        public DbSet<ProviderCategory> ProviderCategories { get; set; }

        public DbSet<HomeButtonText> HomeButtonTexts { get; set; }

        public DbSet<GroupProviderPageButtonText> GroupProviderPageButtonTexts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<GroupProvider>()
                .Property(p => p.ProviderName)
                .HasDefaultValue(true);
            base.OnModelCreating(modelBuilder);
        }

    }
}
