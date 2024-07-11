using Microsoft.AspNetCore.Mvc;

namespace College_Project.Controllers
{
    public class BasketController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
