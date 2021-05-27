using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SessionCalculator.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            HttpContext.Session.SetInt32("Increment", 0);

            return View();
        }


        [HttpPost]
        public IActionResult Index(string click)
        {
            int increment = HttpContext.Session.GetInt32("Increment").Value;

            if (click == "Increment")
            {
                increment++;
            }
            else
            {
                if (increment > 0)
                {
                    increment--;
                }
                else
                {
                    ViewBag.Message = "The value cannot be negative";
                }
            }
            HttpContext.Session.SetInt32("Increment", increment);

            return View();
        }

       
    }
}
