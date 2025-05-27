using Microsoft.AspNetCore.Mvc;
using Quick_Tickets.Models.ViewModels;
using Quick_Tickets.Repositories.IRepositories;

namespace Quick_Tickets.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class CinemaController : Controller
    {
        private readonly ICinemaRepository cinemaRepository;
        private readonly IMovieRepository movieRepository;
        public CinemaController(ICinemaRepository cinemaRepository, IMovieRepository movieRepository)
        {
            this.cinemaRepository = cinemaRepository;
            this.movieRepository = movieRepository;
        }
        public IActionResult Index()
        {
            var GetAllCinema = cinemaRepository.Get().ToList();
            return View(GetAllCinema);
        }

        public IActionResult MoreMovieWithCinema(int Id)
        {
            var cinema = cinemaRepository.Get().FirstOrDefault(c => c.Id == Id);
            var moviesInCinema = movieRepository.Get().Where(m => m.CinemaId == Id).ToList();

            if (cinema == null)
            {
                return RedirectToAction("NotFoundPage404", "Home", new { area = "Customer" });
            }


            var viewModel = new CinemaMoviesViewModel
            {
                Cinema = cinema,
                Movies = moviesInCinema
            };

            return View(viewModel);
        }

    }
}
