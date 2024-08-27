using Microsoft.AspNetCore.Mvc;

namespace SchoolSystem.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
