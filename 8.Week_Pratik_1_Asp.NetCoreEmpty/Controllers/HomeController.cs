using Microsoft.AspNetCore.Mvc;

namespace _8.Week_Pratik_1_Asp.NetCoreEmpty.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        { return View(); }

        public IActionResult About()
        { return View(); }
    }
}
