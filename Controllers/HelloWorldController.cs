using Microsoft.AspNetCore.Mvc;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public String Welcome()
        {
            return "This is a welcome method...";
        }

        public string WelcomePersonal(string name, int age)
        {
            return $"Hello {name}. You are {age} years old.";
        }
        public IActionResult Person(string name, int age)
        {
            ViewData["Person"] = name;
            ViewData["Age"] = age;
            return View();
        }
    }
}
