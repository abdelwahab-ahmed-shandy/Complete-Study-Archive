using Microsoft.AspNetCore.Mvc;
using Quick_Tickets.Repositories;

namespace Quick_Tickets.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class ActorController : Controller
    {
        private readonly IActorRepository actorRepository;
        private readonly IMovieRepository movieRepository;
        public ActorController(IActorRepository actorRepository, IMovieRepository movieRepository)
        {
            this.actorRepository = actorRepository;
            this.movieRepository = movieRepository;
        }
        public IActionResult Index()
        {
            var viewActor = actorRepository.Get().ToList();
            return View(viewActor);
        }

        public IActionResult MoviesByActor(int id)
        {
            var actor = actorRepository.Get().FirstOrDefault(a => a.Id == id);

            if (actor == null)
            {
                return RedirectToAction("NotFoundPage404", "Home", new { area = "Customer" });
            }

            var movies = movieRepository.Get().Where(m => m.Actors.Any(a => a.Id == id)).ToList();

            var viewModel = new ActorMoviesViewModel
            {
                Actor = actor,
                Movies = movies
            };

            return View(viewModel);
        }
    }
}
