using Microsoft.AspNetCore.Mvc;

namespace UdemyCore_Proje.Controllers
{
    public class ErrorPageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
