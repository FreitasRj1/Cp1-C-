using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace ProvaEFCore.App.Data
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
    {
        public AppDbContext CreateDbContext(string[] args)
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false)
                .Build();

            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
            var conn = config.GetConnectionString("DefaultConnection");
            optionsBuilder.UseOracle(conn);

            return new AppDbContext(optionsBuilder.Options);
        }
    }
}
