using Bns.Identity.Domain.Users;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Bns.Identity.EntityFrameworkCore.Users
{
    public interface IUserDbContext : IEfCoreDbContext
    {
        DbSet<User> Users { get; }
    }
}
