using Microsoft.AspNetCore.Mvc;

namespace Fpt.Controllers
{
    public class HomeController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
