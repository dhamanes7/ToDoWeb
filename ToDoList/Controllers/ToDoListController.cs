using Microsoft.AspNetCore.Mvc;
using ToDoList.Models;

namespace ToDoList.Controllers
{ 
    public class ToDoListController : Controller
    {
        public int i = 0;
        public IActionResult Index()
        {

            List<Models.ToDoList> toDo = new List<Models.ToDoList>();

            return View("Index", toDo);
        }
        [HttpPost]
        public IActionResult Index(Models.ToDoList ToDoList, String submit, string completed)
        {
            if (submit == "submit")
            {
                ToDoList.Id = i + 1;
                ToDoList.Title = (string)ViewData["name"];
                ToDoList.Completed = "NA";
                ToDoList.IsCompleted = "NA";

                return RedirectToAction("Index");
            }
            else if(completed == "completed")
            {
                
            }
        }
    }
}
