using Microsoft.AspNetCore.Mvc;

namespace DemoMVC.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Message = "Xin chào! Đây là ViewBag gửi từ Controller";
            ViewBag.Time = DateTime.Now.ToString("dd/MM/yyyy HH:mm");

            return View();
        }
    }
}
