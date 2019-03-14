using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using AbpDemoThree.Configuration;

namespace AbpDemoThree.Web.Host.Startup
{
    [DependsOn(
       typeof(AbpDemoThreeWebCoreModule))]
    public class AbpDemoThreeWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public AbpDemoThreeWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(AbpDemoThreeWebHostModule).GetAssembly());
        }
    }
}
