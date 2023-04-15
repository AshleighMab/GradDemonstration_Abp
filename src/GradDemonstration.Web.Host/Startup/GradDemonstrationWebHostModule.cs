using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using GradDemonstration.Configuration;

namespace GradDemonstration.Web.Host.Startup
{
    [DependsOn(
       typeof(GradDemonstrationWebCoreModule))]
    public class GradDemonstrationWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public GradDemonstrationWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(GradDemonstrationWebHostModule).GetAssembly());
        }
    }
}
