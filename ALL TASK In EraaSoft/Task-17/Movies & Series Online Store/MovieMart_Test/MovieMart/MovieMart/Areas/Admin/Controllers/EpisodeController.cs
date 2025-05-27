using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MovieMart.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin,SuberAdmin")]
    public class EpisodeController : Controller
    {
        private readonly IEpisodeRepository _episodeRepository;
        private readonly ISeasonRepository _seasonRepository;
        public EpisodeController(IEpisodeRepository episodeRepository, ISeasonRepository seasonRepository)
        {
            this._episodeRepository = episodeRepository;
            this._seasonRepository = seasonRepository;
        }
        public IActionResult Index()
        {
            var episode = _episodeRepository.Get()
                .Include(e => e.Season)
                .ToList();
            return View(episode);
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Seasons = new SelectList(_seasonRepository.Get(), "Id", "Title");
            return View(new Episode());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Episode episode)
        {
            if (ModelState.IsValid)
            {
                _episodeRepository.Create(episode);
                _episodeRepository.SaveDB();

                // Set the success message in TempData
                TempData["notifiction"] = "The Episode was created successfully!";
                TempData["MessageType"] = "success";

                return RedirectToAction("Index");
            }
            return View(episode);
        }

        [HttpGet]
        public IActionResult Edit(int Id)
        {
            var episode = _episodeRepository.GetOne(e => e.Id == Id);
            if (episode != null)
            {
                ViewBag.Seasons = new SelectList(_seasonRepository.Get(), "Id", "Title", episode.SeasonId);
                return View(episode);
            }
            return RedirectToAction("NotFound", "Home");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Episode episode)
        {
            if (episode != null && ModelState.IsValid)
            {
                _episodeRepository.Edit(episode);
                _episodeRepository.SaveDB();

                // Set the success message in TempData
                TempData["notifiction"] = "Edit Episode Successfully!";
                TempData["MessageType"] = "Success";

                return RedirectToAction("Index");

            }

            return View(episode);
        }

        public IActionResult Delete(int Id)
        {
            var episode = _episodeRepository.GetOne(e => e.Id == Id);

            if (episode != null)
            {
                _episodeRepository.Delete(episode);
                _episodeRepository.SaveDB();

                // Set the success message in TempData
                TempData["notifiction"] = "Episode Deleted Successfully!";
                TempData["MessageType"] = "Success";

                return RedirectToAction(nameof(Index));
            }
            return RedirectToAction("NotFound", "Home");

        }
    }
}
