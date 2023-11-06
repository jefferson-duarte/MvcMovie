using Microsoft.AspNetCore.Mvc;
using MvcMovie.Models;

namespace MvcMovie.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            List<string> Students = new List<string>();

            Students.Add("Jefferson");
            Students.Add("Maria");
            Students.Add("Jonas");

            ViewData["students"] = Students;

            return View();
        }

        public IActionResult Student()
        {
            Student student = new() {name="Jefferson", age=20};
            return View(student);
        }
    }
}
