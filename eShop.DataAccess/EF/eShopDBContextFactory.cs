using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShop.DataAccess.EF
{
    internal class eShopDBContextFactory : IDesignTimeDbContextFactory<eShopDBContext>
    {
        public eShopDBContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = configuration.GetConnectionString("eShopSolutionDb");
            var optionsBuilder = new DbContextOptionsBuilder<eShopDBContext>();
            optionsBuilder.UseSqlServer(connectionString);

            return new eShopDBContext(optionsBuilder.Options);
        }
    }
}
