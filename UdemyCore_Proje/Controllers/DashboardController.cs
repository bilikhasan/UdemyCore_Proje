using Microsoft.AspNetCore.Mvc;

namespace UdemyCore_Proje.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.v1 = "Dashboard";
            ViewBag.v1 = "İstatistikler";
            ViewBag.v1 = "İstatistik Sayısı";
            return View();
        }
    }
}
