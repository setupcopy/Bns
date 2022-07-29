using Bns.Identity.EntityFrameworkCore.Users;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace Bns.Identity.EntityFrameworkCore
{
    public class BnsIdentityDbContextFactory : IDesignTimeDbContextFactory<UserDbContext>
    {
        public UserDbContext CreateDbContext(string[] args)
        {
            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<UserDbContext>()
                .UseMySql(configuration.GetConnectionString("Default"), ServerVersion.Create(new Version(),
                Pomelo.EntityFrameworkCore.MySql.Infrastructure.ServerType.MySql));

            return new UserDbContext(builder.Options);
        }

        private static IConfigurationRoot BuildConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../Bns.Identity.Dbmigrator/"))
                .AddJsonFile("appsetting.json", optional:false);

            return builder.Build();
        }
    }
}
