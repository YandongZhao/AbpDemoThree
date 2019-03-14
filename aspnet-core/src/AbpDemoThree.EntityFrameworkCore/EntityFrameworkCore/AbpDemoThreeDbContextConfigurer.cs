using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace AbpDemoThree.EntityFrameworkCore
{
    public static class AbpDemoThreeDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<AbpDemoThreeDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<AbpDemoThreeDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
