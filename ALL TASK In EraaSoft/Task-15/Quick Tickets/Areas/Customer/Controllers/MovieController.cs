using Microsoft.AspNetCore.Mvc;
using Quick_Tickets.Repositories.IRepositories;

namespace Quick_Tickets.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class MovieController : Controller
    {
        private readonly IMovieRepository movieRepository;

        public MovieController(IMovieRepository movieRepository)
        {
            this.movieRepository = movieRepository;
        }

        public IActionResult Index()
        {

            var viewMovies = movieRepository.Get();

            return View(viewMovies);

        }

        public IActionResult Details(int Id)
        {
            var MovieDetails = movieRepository.Get().FirstOrDefault(m => m.Id == Id);

            if (MovieDetails == null)
            {
                return RedirectToAction("NotFoundPage404", "Home", new { area = "Customer" });
            }
            return View(MovieDetails);
        }
    }
}
