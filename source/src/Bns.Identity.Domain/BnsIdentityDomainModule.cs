using Volo.Abp.Domain;
using Volo.Abp.Modularity;

namespace Bns.Identity.Domain
{
    [DependsOn(
        typeof(AbpDddDomainModule)
        )]
    public  class BnsIdentityDomainModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            
        }

        public override void PostConfigureServices(ServiceConfigurationContext context)
        {
            base.PostConfigureServices(context);
        }

    }
}
