using Maqaoplus.Services;
using Microsoft.AspNetCore.Mvc;

namespace Maqaoplus.Controllers
{
    public class TenantManagementController : Controller
    {
        private readonly Dukawaremallservices bl;
        public TenantManagementController(IConfiguration config)
        {
            bl = new Dukawaremallservices(config);
        }
        [HttpGet]
        public IActionResult Systemrentallist()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Addsystemrental()
        {
            return PartialView();
        }
        
        [HttpGet]
        public IActionResult Systemtenantlist()
        {
            return View();
        }
    }
}
