namespace Bns.Identity.Application.Contracts.Users
{
    public interface IUserAppService
    {
        Task<UserDto> FindByUserName(string userName);
        Task<UserDto> FindByEmail(string email);
        Task<UserDto> FindById(Guid id);
        Task<List<UserDto>> GetUserList();
    }
}
