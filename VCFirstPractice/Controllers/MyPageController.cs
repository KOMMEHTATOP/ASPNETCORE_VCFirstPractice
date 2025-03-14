using Microsoft.AspNetCore.Mvc;

namespace VCFirstPractice.Controllers
{
    public class MyPageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
