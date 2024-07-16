using Microsoft.AspNetCore.Mvc;

namespace learnMVC.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
