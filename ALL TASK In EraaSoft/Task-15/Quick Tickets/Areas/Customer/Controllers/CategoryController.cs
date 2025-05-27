using Microsoft.AspNetCore.Mvc;
using Quick_Tickets.Repositories.IRepositories;

namespace Quick_Tickets.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class CategoryController : Controller
    {
        private readonly ICategoryRepository categoryRepository;
        private readonly IMovieRepository movieRepository;

        public CategoryController(ICategoryRepository categoryRepository, IMovieRepository movieRepository)
        {
            this.categoryRepository = categoryRepository;
            this.movieRepository = movieRepository;
        }

        public IActionResult Index()
        {
            var categoryView = categoryRepository.Get();

            return View(categoryView);
        }

        public IActionResult MoreCategory(int Id)
        {
            var movieWithCategory = movieRepository.Get().Where(m => m.CategoryId == Id).ToList();
            var Category = categoryRepository.Get().FirstOrDefault(c => c.Id == Id);
            // todo:
            //var movieWithCategory = movieRepository.Get().Where(m => m.CategoryId == Id).ToList();

            if (Category == null)
            {
                return RedirectToAction("NotFoundPage404", "Home", new { area = "Customer" });
            }

            var viewmodel = new CinemaMoviesViewCategory
            {
                Category = Category,
                Movies = movieWithCategory
            };

            return View(viewmodel);

        }
    }
}
