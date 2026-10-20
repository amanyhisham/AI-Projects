using Microsoft.AspNetCore.Mvc;

namespace LunaBoutique.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}