using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using UdemyCore_Proje.Areas.Writer.Models;

namespace UdemyCore_Proje.Areas.Writer.Controllers
{
    [AllowAnonymous]
    [Area("Writer")]
    [Route("Writer/[controller]/[action]")]

    public class RegisterController : Controller
    {
        private readonly UserManager<WriterUser> _userManager;
        public RegisterController(UserManager<WriterUser> userManager)
        {
            _userManager = userManager;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(UserRegisterViewModel p)
        {

            WriterUser w = new WriterUser()
            {
                Name = p.Name,                  // soldaki identity (mesela Email) + writeruser (Name,Surname) class ları 
                Surname = p.Surname,            // sağdaki ise UserRegisterViewModel
                Email = p.Mail,
                UserName = p.UserName,
                ImageUrl = p.ImageUrl
            };

            if (p.Password == p.ConfirmPassword)
            {
                var result = await _userManager.CreateAsync(w, p.Password);

                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Login");
                }
                else
                {
                    foreach (var item in result.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }
                }
            }
            return View(p);
        }
    }
}
