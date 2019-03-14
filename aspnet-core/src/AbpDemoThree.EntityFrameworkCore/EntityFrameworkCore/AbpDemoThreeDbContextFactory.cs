using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using AbpDemoThree.Configuration;
using AbpDemoThree.Web;

namespace AbpDemoThree.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class AbpDemoThreeDbContextFactory : IDesignTimeDbContextFactory<AbpDemoThreeDbContext>
    {
        public AbpDemoThreeDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<AbpDemoThreeDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            AbpDemoThreeDbContextConfigurer.Configure(builder, configuration.GetConnectionString(AbpDemoThreeConsts.ConnectionStringName));

            return new AbpDemoThreeDbContext(builder.Options);
        }
    }
}
