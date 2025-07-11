using Microsoft.AspNetCore.Mvc;
using NuGet.ContentModel;

namespace Quick_Tickets.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class MoviesController : Controller
    {
        private readonly IMovieRepository movieRepository;
        private readonly ICinemaRepository cinemaRepository;
        private readonly ICategoryRepository categoryRepository;

        public MoviesController(IMovieRepository movieRepository, ICategoryRepository categoryRepository, ICinemaRepository cinemaRepository)
        {
            this.movieRepository = movieRepository;
            this.cinemaRepository = cinemaRepository;
            this.categoryRepository = categoryRepository;
        }

        public IActionResult Index()
        {
            var movieView = movieRepository.Get()
                .Include(c => c.Cinema)
                .Include(m => m.Category)
                .ToList();
            return View(movieView);
        }

        // here ::: todo 
        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Cinema = cinemaRepository.Get().ToList();
            ViewBag.Category = categoryRepository.Get().ToList();

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Movie movie, IFormFile file)
        {
            if (ModelState.IsValid)
            {
                if (file != null && file.Length > 0)
                {
                    var fileName = $"{Guid.NewGuid().ToString()}{Path.GetExtension(file.FileName)}";
                    var filePath = $"{Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\Assats\\Custumer\\PhotoMovie", fileName)}";

                    using (var stream = System.IO.File.Create(filePath))
                    {
                        file.CopyTo(stream);
                    }
                    movie.ImgUrl = fileName;
                }

                movieRepository.Create(movie);
                movieRepository.Commit();

                return RedirectToAction(nameof(Index));
            }

            ViewBag.Cinema = cinemaRepository.Get().ToList();
            ViewBag.Category = categoryRepository.Get().ToList();

            return View(movie);

        }









    }
}
