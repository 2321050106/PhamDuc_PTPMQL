using Microsoft.AspNetCore.Mvc;

namespace MyApp.Controllers
{
    public class DemoController : Controllers
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}