using Bns.Identity.Application.Contracts;
using Microsoft.OpenApi.Models;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Modularity;

namespace Bns.Identity.HttpApi
{
    [DependsOn(
        typeof(BnsIdentityApplicationContractsModule),
        typeof(AbpAspNetCoreMvcModule)
        )]
    public class BnsIdentityHttpApiModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.GetHostingEnvironment();
            ConfigureSwaggerServices(context.Services);
        }

        private void ConfigureSwaggerServices(IServiceCollection services)
        {
            services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("v1", new OpenApiInfo { Title = "Identity API", Version = "v1" });
                options.DocInclusionPredicate((docName, description) => true);
                options.CustomSchemaIds(type => type.FullName);
            });
        }
    }
}
