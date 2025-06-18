using Microsoft.AspNetCore.Mvc;

namespace SiteBianca.Controllers
{
    public class SobreController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
