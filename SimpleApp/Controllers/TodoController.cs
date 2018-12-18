using Microsoft.AspNetCore.Mvc;

namespace SimpleApp.Controllers
{
    public class TodoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
