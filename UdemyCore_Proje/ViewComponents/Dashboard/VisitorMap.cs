using Microsoft.AspNetCore.Mvc;

namespace UdemyCore_Proje.ViewComponents.Dashboard
{
    public class VisitorMap : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
