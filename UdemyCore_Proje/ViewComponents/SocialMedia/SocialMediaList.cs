using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace UdemyCore_Proje.ViewComponents.SocialMedia
{
    public class SocialMediaList :ViewComponent
    {
        SocialMediaManager socialMedia = new SocialMediaManager(new EfSocialMediaDal());
        public IViewComponentResult Invoke()
        {
            var values = socialMedia.TGetList();
            return View(values);
        }
    }
}
