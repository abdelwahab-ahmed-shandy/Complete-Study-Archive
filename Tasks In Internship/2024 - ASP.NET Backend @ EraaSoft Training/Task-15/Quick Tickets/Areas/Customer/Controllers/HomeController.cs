using Microsoft.AspNetCore.Mvc;
using Quick_Tickets.Repositories.IRepositories;

namespace Quick_Tickets.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class HomeController : Controller
    {

        private readonly IMovieRepository movieRepository;
        private readonly ICategoryRepository categoryRepository;

        public HomeController(IMovieRepository movieRepository, ICategoryRepository categoryRepository)
        {
            this.movieRepository = movieRepository;
            this.categoryRepository = categoryRepository;
        }

        // todo: here View in Home (Movie And Category)
        public IActionResult Index()
        {
            var viewMoviesAndCategory = movieRepository.Get().Include(m => m.Category).ToList();

            return View(viewMoviesAndCategory);
        }

        public IActionResult NotFoundPage404()
        {

            return View();
        }
    }
}
