using Microsoft.AspNetCore.Mvc;

namespace Quick_Tickets.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CinemasController : Controller
    {
        private readonly ICinemaRepository cinemaRepository;

        public CinemasController(ICinemaRepository cinemaRepository)
        {
            this.cinemaRepository = cinemaRepository;
        }

        public IActionResult Index()
        {
            var cinemasView = cinemaRepository.Get().ToList();

            return View(cinemasView);
        }

        [HttpGet]
        public IActionResult Create()
        {

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Cinema cinema)
        {
            if (ModelState.IsValid)
            {
                cinemaRepository.Create(cinema);
                cinemaRepository.Commit();

                return RedirectToAction(nameof(Index));
            }
            return View(cinema);
        }

        [HttpGet]
        public IActionResult Edit(int Id)
        {
            var cinemaEdit = cinemaRepository.GetOne(c => c.Id == Id);

            if (cinemaEdit == null)
            {
                return RedirectToAction("NotFoundPage", "Home", new { area = "Admin" });
            }

            return View(cinemaEdit);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Cinema cinema)
        {
            if (cinema == null)
            {
                return RedirectToAction("NotFoundPage", "Home", new { area = "Admin" });
            }
            cinemaRepository.Edit(cinema);
            cinemaRepository.Commit();
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Delete(int Id)
        {
            var cinemaDelete = cinemaRepository.GetOne(c => c.Id == Id);

            if (cinemaDelete == null)
            {
                return RedirectToAction("NotFoundPage", "Home", new { area = "Admin" });
            }
            cinemaRepository.Delete(cinemaDelete);
            cinemaRepository.Commit();

            return RedirectToAction(nameof(Index));
        }

    }
}
