using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using GradDemonstration.Authorization;

namespace GradDemonstration
{
    [DependsOn(
        typeof(GradDemonstrationCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class GradDemonstrationApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<GradDemonstrationAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(GradDemonstrationApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
