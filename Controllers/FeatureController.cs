using Microsoft.AspNetCore.Mvc;

namespace Project.Controllers
{
    public class FeatureController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
