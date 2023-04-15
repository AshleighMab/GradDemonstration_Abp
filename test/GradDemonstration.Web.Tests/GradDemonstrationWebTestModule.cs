using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using GradDemonstration.EntityFrameworkCore;
using GradDemonstration.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace GradDemonstration.Web.Tests
{
    [DependsOn(
        typeof(GradDemonstrationWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class GradDemonstrationWebTestModule : AbpModule
    {
        public GradDemonstrationWebTestModule(GradDemonstrationEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(GradDemonstrationWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(GradDemonstrationWebMvcModule).Assembly);
        }
    }
}