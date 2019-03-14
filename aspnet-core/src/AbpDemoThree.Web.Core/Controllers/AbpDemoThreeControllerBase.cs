using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace AbpDemoThree.Controllers
{
    public abstract class AbpDemoThreeControllerBase: AbpController
    {
        protected AbpDemoThreeControllerBase()
        {
            LocalizationSourceName = AbpDemoThreeConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
