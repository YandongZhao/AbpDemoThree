using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using AbpDemoThree.Authorization.Roles;
using AbpDemoThree.Authorization.Users;
using AbpDemoThree.MultiTenancy;

namespace AbpDemoThree.EntityFrameworkCore
{
    public class AbpDemoThreeDbContext : AbpZeroDbContext<Tenant, Role, User, AbpDemoThreeDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public AbpDemoThreeDbContext(DbContextOptions<AbpDemoThreeDbContext> options)
            : base(options)
        {
        }
    }
}
