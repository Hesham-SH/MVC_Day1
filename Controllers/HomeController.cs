using Microsoft.AspNetCore.Mvc;
using MVC_Day1.Models;

namespace MVC_Day1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View("HomePage");
        }

        public IActionResult Registration()
        {
            return View("RegisterPage");
        }

        public IActionResult GetAllUsers()
        {
            List<UserModel> users = UserData.GetUsers();
            return View("AttendeesPage",users);

        }
    }
}
