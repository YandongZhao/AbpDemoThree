using Abp.Authorization;
using AbpDemoThree.Authorization.Roles;
using AbpDemoThree.Authorization.Users;

namespace AbpDemoThree.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
