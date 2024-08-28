using Microsoft.AspNetCore.Mvc;

namespace HanaaMahmoud_Mon_Thurs_4PM_MVC01.Controllers
{
    public class HomeController : Controller
    {
        // Index() called Action 
        //Action Result has many Action Result which return helper methods
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AboutUs()
        {
            return View();
        }
        public IActionResult ContactUs()
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }
    }
}
