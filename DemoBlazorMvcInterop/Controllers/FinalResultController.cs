using Microsoft.AspNetCore.Mvc;

namespace DemoBlazorMvcInterop.Controllers
{
    public class FinalResultController : Controller
    {
        // GET
        public IActionResult Total(int result)
        {
            ViewData["TotalCount"] = result;
            return View();
        }
    }
}