using Bns.Identity.Domain.Users;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace Bns.Identity.EntityFrameworkCore.Users
{
    [ConnectionStringName("Default")]
    public class UserDbContext : AbpDbContext<UserDbContext>, IUserDbContext
    {
        public DbSet<User> Users { get; set; }

        public UserDbContext(DbContextOptions<UserDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ConfigureUser();
        }
    }
}
