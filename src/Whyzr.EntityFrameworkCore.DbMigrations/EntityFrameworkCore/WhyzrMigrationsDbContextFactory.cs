using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Whyzr.EntityFrameworkCore
{
    /* This class is needed for EF Core console commands
     * (like Add-Migration and Update-Database commands) */
    public class WhyzrMigrationsDbContextFactory : IDesignTimeDbContextFactory<WhyzrMigrationsDbContext>
    {
        public WhyzrMigrationsDbContext CreateDbContext(string[] args)
        {
            WhyzrEfCoreEntityExtensionMappings.Configure();

            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<WhyzrMigrationsDbContext>()
                .UseSqlServer(configuration.GetConnectionString("Default"));

            return new WhyzrMigrationsDbContext(builder.Options);
        }

        private static IConfigurationRoot BuildConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../Whyzr.DbMigrator/"))
                .AddJsonFile("appsettings.json", optional: false);

            return builder.Build();
        }
    }
}
