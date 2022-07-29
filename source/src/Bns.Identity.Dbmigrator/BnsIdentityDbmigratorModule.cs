using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace Bns.Identity.Dbmigrator
{
    [DependsOn(
    typeof(AbpAutofacModule)
    )]
    public class BnsIdentityDbmigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            base.ConfigureServices(context);
        }
    }
}
