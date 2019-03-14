using Microsoft.AspNetCore.Antiforgery;
using AbpDemoThree.Controllers;

namespace AbpDemoThree.Web.Host.Controllers
{
    public class AntiForgeryController : AbpDemoThreeControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}
