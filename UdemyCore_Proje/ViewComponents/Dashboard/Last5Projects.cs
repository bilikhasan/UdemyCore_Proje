using Microsoft.AspNetCore.Mvc;

namespace UdemyCore_Proje.ViewComponents.Dashboard
{
    public class Last5Projects : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
