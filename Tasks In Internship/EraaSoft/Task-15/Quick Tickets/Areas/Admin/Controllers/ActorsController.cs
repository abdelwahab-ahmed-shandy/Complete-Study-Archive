using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace Quick_Tickets.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ActorsController : Controller
    {


        private readonly IActorRepository actorRepository;
        private readonly IMovieRepository movieRepository;

        public ActorsController(IActorRepository actorRepository, IMovieRepository movieRepository)
        {
            this.actorRepository = actorRepository;
            this.movieRepository = movieRepository;
        }

        public IActionResult Index()
        {
            var viewActor = actorRepository.Get().ToList();
            return View(viewActor);
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Movies = movieRepository.Get().ToList();
            return View(new Actor());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Actor actor, IFormFile file)
        {
            if (ModelState.IsValid)
            {
                if (file != null && file.Length > 0)
                {
                    var fileName = Guid.NewGuid().ToString() + Path.GetExtension(file.FileName);
                    var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\Assats\\Custumer\\ActorProfilePicture", fileName);

                    using (var steam = System.IO.File.Create(filePath))
                    {
                        file.CopyTo(steam);
                    }

                    actor.ProfilePicture = fileName;

                }

                actorRepository.Create(actor);
                actorRepository.Commit();

                return RedirectToAction(nameof(Index));
            }


            ViewBag.Movies = movieRepository.Get().ToList();

            return View(actor);
        }

        [HttpGet]
        public IActionResult Edit(int Id)
        {
            var ActorEdit = actorRepository.GetOne(a => a.Id == Id);

            ViewBag.Movies = movieRepository.Get().ToList();

            if (ActorEdit == null)
            {
                return RedirectToAction("NotFoundPage", "Home");
            }

            return View(ActorEdit);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Actor actor, IFormFile? file)
        {
            if (actor == null)
                return RedirectToAction("NotFoundPage", "Home", new { area = "Customer" });

            var actorInDatabase = actorRepository.GetOne(e => e.Id == actor.Id, tracked: false);

            if (actorInDatabase == null)
                return RedirectToAction("NotFoundPage", "Home", new { area = "Customer" });


            if (file != null && file.Length > 0)
            {
                var uploadsFolder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\Assats\\Custumer\\ActorProfilePicture");

                if (!Directory.Exists(uploadsFolder))
                {
                    Directory.CreateDirectory(uploadsFolder);
                }

                var fileName = $"{Guid.NewGuid()}{Path.GetExtension(file.FileName)}";
                var filePath = Path.Combine(uploadsFolder, fileName);

                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    file.CopyTo(stream);
                }

                if (!string.IsNullOrEmpty(actorInDatabase.ProfilePicture))
                {
                    var oldImagePath = Path.Combine(uploadsFolder, actorInDatabase.ProfilePicture);
                    if (System.IO.File.Exists(oldImagePath))
                    {
                        System.IO.File.Delete(oldImagePath);
                    }
                }

                actorInDatabase.ProfilePicture = fileName;
            }

            actorInDatabase.FirstName = actor.FirstName;
            actorInDatabase.LastName = actor.LastName;
            actorInDatabase.Bio = actor.Bio;
            actorInDatabase.News = actor.News;
            actorInDatabase.Movies = actor.Movies;

            actorRepository.Edit(actorInDatabase);
            actorRepository.Commit();

            return RedirectToAction("Index");
        }

        public IActionResult DeleteImg(int Id)
        {
            var actorDelete = actorRepository.GetOne(a => a.Id == Id);

            if (actorDelete != null)
            {
                var oldPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\Assats\\Custumer\\ActorProfilePicture", actorDelete.ProfilePicture);

                if (System.IO.File.Exists(oldPath))
                {
                    System.IO.File.Delete(oldPath);
                }

                actorDelete.ProfilePicture = null;
                actorRepository.Commit();

                return RedirectToAction("Edit", new { Id });
            }
            return RedirectToAction("NotFoundPage", "Home");
        }

        public IActionResult Delete(int Id)
        {
            var actorDelete = actorRepository.GetOne(a => a.Id == Id);

            if (actorDelete.ProfilePicture != null)
            {
                var oldPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\Assats\\Custumer\\ActorProfilePicture", actorDelete.ProfilePicture);

                if (System.IO.File.Exists(oldPath))
                {
                    System.IO.File.Delete(oldPath);
                }

                actorRepository.Delete(actorDelete);
                actorRepository.Commit();

                return RedirectToAction(nameof(Index));
            }
            return RedirectToAction("NotFoundPage", "Home");
        }
    }
}
