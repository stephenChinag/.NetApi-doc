using Microsoft.AspNetCore.Mvc;
using UserRegistrationApp.Models;

namespace UserRegistrationApp.Controllers
{
    public class UserController : Controller
    {

        private static List<User> users = new List<User>();

        [HttpGet] 
        public IActionResult Register (){
            return View();
        }

        [HttpPost]
        public IActionResult Register(User user) {
            if(ModelState.IsValid){
                users.Add(user);
                return RedirectToAction ("UserList");
            }
            return View(user);
        }
        public IActionResult UserList(){
            return View(users);
        }
    }
}