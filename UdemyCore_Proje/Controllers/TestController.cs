using Microsoft.AspNetCore.Mvc;

namespace UdemyCore_Proje.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
