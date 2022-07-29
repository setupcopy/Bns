using AutoMapper;
using Bns.Identity.Application.Contracts.Users;
using Bns.Identity.Domain.Users;

namespace Bns.Identity.Application
{
    public class BnsIdentityApplicationModuleAutoMapperProfile : Profile
    {
        public BnsIdentityApplicationModuleAutoMapperProfile()
        {
            CreateMap<User, UserDto>();
        }
    }
}
