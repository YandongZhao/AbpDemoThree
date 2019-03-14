using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using AbpDemoThree.Authorization;

namespace AbpDemoThree
{
    [DependsOn(
        typeof(AbpDemoThreeCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class AbpDemoThreeApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<AbpDemoThreeAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(AbpDemoThreeApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
