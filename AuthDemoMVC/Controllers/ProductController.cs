using Microsoft.AspNetCore.Mvc;

namespace AuthDemoMVC.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult DevelopBranch()
        {
            return View();
        }

        public IActionResult OriginalDevelop()
        {
            return View();
        }

        public IActionResult Test2()
        {
            var name = "Zaw Htut";
            return View();
        }
        
        public IActionResult Test3()
        {
            var name = "Test 3";
            return View();
        }

        public IActionResult Test4()
        {
            return View();
        }
    }
}
