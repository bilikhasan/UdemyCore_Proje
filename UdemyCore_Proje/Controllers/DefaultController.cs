using Microsoft.AspNetCore.Mvc;

namespace UdemyCore_Proje.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult HeaderPartial()
        {
            return View();
        }

        public IActionResult NavbarPartial()
        {
            return View();
        }
    }
}
