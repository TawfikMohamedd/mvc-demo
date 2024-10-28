using Microsoft.AspNetCore.Mvc;

namespace mvc_demo.controller
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return Redirect("/Home/AboutUs");
        }
        public string AboutUs()
        {
            return "This is Inedx Action";
        }
    }
}
