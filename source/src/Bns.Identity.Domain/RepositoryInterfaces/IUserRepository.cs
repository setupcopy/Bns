using Bns.Identity.Domain.Users;
using Volo.Abp.Domain.Repositories;

namespace Bns.Identity.Domain.RepositoryInterfaces
{
    public interface IUserRepository : IBasicRepository<User,Guid>
    {
        Task<User> FindByUserName(string userName);
        Task<User> FindByEmail(string email);
        Task<User> FindById(Guid id);
        Task<IEnumerable<User>> GetUserList();
    }
}
