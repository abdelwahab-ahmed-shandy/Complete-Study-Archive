using Microsoft.AspNetCore.Mvc;

namespace Quick_Tickets.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoriesController : Controller
    {
        private readonly ICategoryRepository categoryRepository;

        public CategoriesController(ICategoryRepository categoryRepository)
        {
            this.categoryRepository = categoryRepository;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var categoryView = categoryRepository.Get();

            return View(categoryView);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Category category)
        {
            if (ModelState.IsValid)
            {
                categoryRepository.Create(category);

                categoryRepository.Commit();

                return RedirectToAction(nameof(Index));
            }

            return View(category);
        }

        [HttpGet]
        public IActionResult Edit(int Id)
        {
            var categoryEdit = categoryRepository.GetOne(c => c.Id == Id);

            if (categoryEdit == null)
            {
                return RedirectToAction("NotFoundPage", "Home", new { area = "Admin" });
            }

            return View(categoryEdit);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Category category)
        {
            if (category == null || !ModelState.IsValid)
            {
                return RedirectToAction("NotFoundPage", "Home", new { area = "Admin" });
            }

            categoryRepository.Edit(category);
            categoryRepository.Commit();

            return RedirectToAction(nameof(Index));
        }

        public IActionResult Delete(int Id)
        {
            var categoryDelete = categoryRepository.GetOne(c => c.Id == Id);

            if (categoryDelete == null)
            {
                return RedirectToAction("NotFoundPage", "Home", new { area = "Admin" });
            }
            categoryRepository.Delete(categoryDelete);
            categoryRepository.Commit();

            return RedirectToAction(nameof(Index));
        }

    }
}
