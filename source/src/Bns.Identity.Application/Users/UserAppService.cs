using Bns.Identity.Application.Contracts.Users;
using Bns.Identity.Domain.RepositoryInterfaces;
using Bns.Identity.Domain.Users;
using Volo.Abp.Application.Services;

namespace Bns.Identity.Application.Users
{
    public class UserAppService : ApplicationService,IUserAppService
    {
        private readonly IUserRepository _userRepository;
        public UserAppService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<UserDto> FindByEmail(string email)
        {
            var user = await _userRepository.FindByEmail(email);

            var userDto = ObjectMapper.Map<User,UserDto>(user);
            return userDto;
        }

        public async Task<UserDto> FindById(Guid id)
        {
            var user = await _userRepository.FindById(id);

            var userDto = ObjectMapper.Map<User, UserDto>(user);
            return userDto;
        }

        public async Task<UserDto> FindByUserName(string userName)
        {
            var user = await _userRepository.FindByUserName(userName);

            var userDto = ObjectMapper.Map<User, UserDto>(user);
            return userDto;
        }

        public async Task<List<UserDto>> GetUserList()
        {
            var user = await _userRepository.GetUserList();

            var userDtoList = ObjectMapper.Map<IEnumerable<User>, IEnumerable<UserDto>>(user);
            return userDtoList.ToList();
        }
    }
}
