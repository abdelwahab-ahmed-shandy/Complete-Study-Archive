using Microsoft.AspNetCore.Mvc;

namespace Quick_Tickets.Areas.Admin.Controllers
{
    public class HomeController : Controller
    {
        [Area("Admin")]
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult NotFoundPage()
        {
            return View();
        }

        public IActionResult Abdelwahab()
        {
            return View();
        }
    }
}
