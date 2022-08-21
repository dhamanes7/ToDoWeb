using Microsoft.AspNetCore.Mvc;
using ToDoList.Models;

namespace ToDoList.Controllers
{
    public class ToDoListController : Controller
    {
        public IActionResult Index()
        {

            List<Models.ToDoList> toDo = new List<Models.ToDoList>();

            return View("Index", toDo);
        }
        [HttpPost]
        public IActionResult Index(Models.ToDoList ToDoList, String submit, string edit)
        {

            return View("Index");
        }
    }
}
