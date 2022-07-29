using Bns.Identity.Domain.Shared;
using Volo.Abp.Modularity;

namespace Bns.Identity.Application.Contracts
{
    [DependsOn(
        typeof(BnsIdentityDomainSharedModule)
        )]
    public class BnsIdentityApplicationContractsModule : AbpModule
    {
    }
}