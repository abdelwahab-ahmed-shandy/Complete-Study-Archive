using System.Diagnostics;
using Hospital.Models;
using Microsoft.AspNetCore.Mvc;

namespace Hospital.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult BookAnAppointment()
        {
            List<Doctor> doctors = new List<Doctor>
                {
                    new Doctor { Id = 1, Name = "Dr. John Smith", Specialization = "Cardiology", Img = "/assets/image/doctor/doctor1.jpg" },
                    new Doctor { Id = 2, Name = "Dr. Sarah Johnson", Specialization = "Pediatrics", Img = "/assets/image/doctor/doctor2.jpg" },
                    new Doctor { Id = 3, Name = "Dr. Emily Davis", Specialization = "Dermatology", Img = "/assets/image/doctor/doctor4.jpg" },
                    new Doctor { Id = 4, Name = "Dr. Michael Lee", Specialization = "Orthopedics", Img = "/assets/image/doctor/doctor3.jpg" },
                    new Doctor { Id = 5, Name = "Dr. William Clark", Specialization = "Neurology", Img = "/assets/image/doctor/doctor5.jpg" }
                };

            return View(doctors);
        }

        public IActionResult Person()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
