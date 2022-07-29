using Volo.Abp.AutoMapper;
using Bns.Identity.Domain;
using Volo.Abp.Modularity;
using Microsoft.Extensions.DependencyInjection;

namespace Bns.Identity.Application
{
    [DependsOn(
        typeof(BnsIdentityDomainModule),
        typeof(AbpAutoMapperModule)
        )]
    public class BnsIdentityApplicationModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAutoMapperObjectMapper<BnsIdentityApplicationModule>();

            Configure<AbpAutoMapperOptions>(options =>
            {
                options.AddProfile<BnsIdentityApplicationModuleAutoMapperProfile>();
            });
        }
    }
}