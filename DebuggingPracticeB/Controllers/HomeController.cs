
using Microsoft.AspNetCore.Mvc;

namespace HttpPractice.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult HomeTown(string state, string town)
        {
            string content = "State: " + state + ", City: " + town;
            return Content(content);
        }

        [HttpPost]
        public IActionResult FavoriteBook(string genre, string author, string book)
        {
            string content = "Genre: " + genre + ", Author: " + author + ", Book: " + book;
            return View("FavoriteBook", content);
        }

        [HttpPost]
        public IActionResult Vacation(string location, string activity, string clothing)
        {
            string content = "Location: " + location + ", Activity: " + activity + ", What to wear: " + clothing;
            return View("Vacation", content);
        }

    }

}
