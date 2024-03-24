using Microsoft.AspNetCore.Mvc;

namespace AspMvcRoutingApp.Controllers
{
    [Route("user")]
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return Content("User info"); //View();
        }

        [Route("user_name")]
        public IActionResult Name()
        {
            return Content("User name"); //View();
        }

        [Route("user_age")]
        public IActionResult Age()
        {
            return Content("User age");
        }
    }
}
