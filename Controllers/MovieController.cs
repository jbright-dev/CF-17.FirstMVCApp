using Microsoft.AspNetCore.Mvc;

namespace CF_17.FirstMVCApp.Controllers
{
    public class MovieController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
