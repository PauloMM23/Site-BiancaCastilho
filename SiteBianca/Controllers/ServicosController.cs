using Microsoft.AspNetCore.Mvc;

namespace SiteBianca.Controllers
{
    public class ServicosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
