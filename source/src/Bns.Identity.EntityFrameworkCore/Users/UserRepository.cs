using Bns.Identity.Domain.RepositoryInterfaces;
using Bns.Identity.Domain.Users;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Bns.Identity.EntityFrameworkCore.Users
{
    public class UserRepository : EfCoreRepository<IUserDbContext, User, Guid>, IUserRepository
    {
        public UserRepository(IDbContextProvider<IUserDbContext> dbContextProvide):base(dbContextProvide)
        {

        }

        public async Task<User> FindByEmail(string email)
        {           
            return await (await GetDbSetAsync()).Where(u => u.Email == email).FirstOrDefaultAsync();
        }

        public async Task<User> FindById(Guid id)
        {
            return await (await GetDbSetAsync()).Where(u => u.Id == id).FirstOrDefaultAsync();
        }

        public async Task<User> FindByUserName(string userName)
        {
            return await (await GetDbSetAsync()).Where(u => u.UserName == userName).FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<User>> GetUserList()
        {
            return await (await GetDbSetAsync()).ToListAsync();
        }
    }
}
