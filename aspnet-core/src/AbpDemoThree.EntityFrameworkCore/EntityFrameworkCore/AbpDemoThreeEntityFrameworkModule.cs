﻿using Abp.EntityFrameworkCore.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Abp.Zero.EntityFrameworkCore;
using AbpDemoThree.EntityFrameworkCore.Seed;

namespace AbpDemoThree.EntityFrameworkCore
{
    [DependsOn(
        typeof(AbpDemoThreeCoreModule), 
        typeof(AbpZeroCoreEntityFrameworkCoreModule))]
    public class AbpDemoThreeEntityFrameworkModule : AbpModule
    {
        /* Used it tests to skip dbcontext registration, in order to use in-memory database of EF Core */
        public bool SkipDbContextRegistration { get; set; }

        public bool SkipDbSeed { get; set; }

        public override void PreInitialize()
        {
            if (!SkipDbContextRegistration)
            {
                Configuration.Modules.AbpEfCore().AddDbContext<AbpDemoThreeDbContext>(options =>
                {
                    if (options.ExistingConnection != null)
                    {
                        AbpDemoThreeDbContextConfigurer.Configure(options.DbContextOptions, options.ExistingConnection);
                    }
                    else
                    {
                        AbpDemoThreeDbContextConfigurer.Configure(options.DbContextOptions, options.ConnectionString);
                    }
                });
            }
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(AbpDemoThreeEntityFrameworkModule).GetAssembly());
        }

        public override void PostInitialize()
        {
            if (!SkipDbSeed)
            {
                SeedHelper.SeedHostDb(IocManager);
            }
        }
    }
}
