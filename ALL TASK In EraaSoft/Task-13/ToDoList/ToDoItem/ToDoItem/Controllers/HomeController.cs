using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ToDoItem.Models;

namespace ToDoItem.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        ApplicationDbContext dbContext = new ApplicationDbContext();

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ReadName()
        {
            return View();
        }
        public IActionResult InputUser(string NameTemp)
        {
            TempData["name"] = NameTemp;

            return RedirectToAction("DetilesName");
        }

        public IActionResult DetilesName()
        {
            ViewBag.Name = TempData["name"];


            var todolist = dbContext.toDoLists.ToList();



            return View(todolist);
        }

        public IActionResult CreateToDoList()
        {
            return View();
        }

        public IActionResult SaveDoList(string title, string description, DateTime deadline)
        {
            if (!string.IsNullOrWhiteSpace(title) && !string.IsNullOrWhiteSpace(description))
            {
                var newToDo = new ToDoList()
                {
                    Title = title,
                    Description = description,
                    DeadLine = deadline
                };

                dbContext.toDoLists.Add(newToDo);
                dbContext.SaveChanges();
                TempData["SuccessMessage"] = "The item was created successfully.";
            }
            return RedirectToAction("DetilesName", "Home");
        }

        public IActionResult EditDoList(int id)
        {

            return View(dbContext.toDoLists.Find(id));
        }

        public IActionResult SaveEditDoList(int id, string title, string description, DateTime deadline)
        {
            if (string.IsNullOrWhiteSpace(title) || string.IsNullOrWhiteSpace(description))
            {
                TempData["EditError"] = "Title and description cannot be empty.";
                return RedirectToAction("EditDoList", new { id });
            }

            var EditToDoItem = dbContext.toDoLists.Find(id);
            if (EditToDoItem == null)
            {
                return NotFound();
            }

            EditToDoItem.Title = title;
            EditToDoItem.Description = description;
            EditToDoItem.DeadLine = deadline;

            dbContext.SaveChanges();
            TempData["EditMessage"] = "The item was edited successfully.";

            return RedirectToAction("DetilesName", "Home", new { id });
        }


        public IActionResult DeleteDoList(int id)
        {
            var deletetodo = dbContext.toDoLists.Find(id);

            if (deletetodo != null)
            {
                dbContext.toDoLists.Remove(deletetodo);
                dbContext.SaveChanges();

                TempData["DeleteMessage"] = "Item successfully Delete!?";
            }

            return RedirectToAction("DetilesName", "Home");
        }

        public IActionResult Abdelwahab()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
