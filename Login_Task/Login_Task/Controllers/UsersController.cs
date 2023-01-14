using Microsoft.AspNetCore.Mvc;

namespace Login_Task.Controllers
{
    public class UsersController : Controller
        
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
