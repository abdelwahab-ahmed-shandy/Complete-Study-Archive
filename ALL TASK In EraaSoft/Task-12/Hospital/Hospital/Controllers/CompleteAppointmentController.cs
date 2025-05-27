namespace Hospital.Controllers
{
    public class CompleteAppointmentController : Controller
    {
        //public IActionResult Index()
        //{


        //    return View();
        //}

        public IActionResult CompleteAppointment(int id)
        {
            List<Doctor> doctors = new List<Doctor>
                {
                    new Doctor { Id = 1, Name = "Dr. John Smith", Specialization = "Cardiology", Img = "/assets/image/doctor/doctor1.jpg" },
                    new Doctor { Id = 2, Name = "Dr. Sarah Johnson", Specialization = "Pediatrics", Img = "/assets/image/doctor/doctor2.jpg" },
                    new Doctor { Id = 3, Name = "Dr. Emily Davis", Specialization = "Dermatology", Img = "/assets/image/doctor/doctor4.jpg" },
                    new Doctor { Id = 4, Name = "Dr. Michael Lee", Specialization = "Orthopedics", Img = "/assets/image/doctor/doctor3.jpg" },
                    new Doctor { Id = 5, Name = "Dr. William Clark", Specialization = "Neurology", Img = "/assets/image/doctor/doctor5.jpg" }
            };

            Models.Doctor selectedDoctor = null;
            foreach (var doctor in doctors)
            {
                if (doctor.Id == id)
                {
                    selectedDoctor = doctor;
                    break;
                }
            }

            if (selectedDoctor != null)
            {
                ViewBag.DoctorName = selectedDoctor.Name;
            }



            return View();
        }
    }
}
