using Microsoft.AspNetCore.Mvc;

namespace UdemyCore_Proje.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
