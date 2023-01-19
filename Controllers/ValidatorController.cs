using Microsoft.AspNetCore.Mvc;
using MVC_Day1.Models;

namespace MVC_Day1.Controllers
{
    public class ValidatorController : Controller
    {
        public IActionResult Handler(UserModel User)
        {
            if (User.willattend == "on")
            {
                AddUser(User);
                return View("ThankYou");
            }
            else
                return View("SeeYouLater");
        }


        public void AddUser(UserModel User)
        {
           UserData.AddUser(User);
        }

    }
}
