using Microsoft.AspNetCore.Mvc;

namespace UdemyCore_Proje.ViewComponents.Dashboard
{
    public class MessageList : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
