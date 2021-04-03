using gibddDBModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.IO;

namespace gibddDBcore
{
    public class gibddDbContext : DbContext
    {
        private static IConfigurationRoot _configuration;
        public DbSet<Driver> Drivers { get; set; }
        public DbSet<Licence> Licences { get; set; }
        public gibddDbContext() : base() { }
        public gibddDbContext(DbContextOptions options)
:              base()
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var builder = new ConfigurationBuilder()
                                .SetBasePath(Directory.GetCurrentDirectory())
                                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

                _configuration = builder.Build();
                var cnstr = _configuration.GetConnectionString("gibddDBManager");
                optionsBuilder.UseSqlServer(cnstr);
            }
        }
        public override int SaveChanges()
        {
            var tracker = ChangeTracker;
            foreach (var entry in tracker.Entries())
            {
                if (entry.Entity is FullAuditModel)
                {
                    var referenceEntity = entry.Entity as FullAuditModel;
                    switch (entry.State)
                    {
                        case EntityState.Added:
                            referenceEntity.CreatedDate = System.DateTime.Now;
                            break;
                        case EntityState.Deleted:
                        case EntityState.Modified:
                            referenceEntity.LastModifiedDate = System.DateTime.Now;
                            break;
                        default:
                            break;
                    }
                }
            }
            return base.SaveChanges();
        }
    }
}
