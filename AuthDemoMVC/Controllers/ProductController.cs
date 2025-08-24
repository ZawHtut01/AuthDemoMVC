using Microsoft.AspNetCore.Mvc;

namespace AuthDemoMVC.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
