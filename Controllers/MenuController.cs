using Microsoft.AspNetCore.Mvc;

namespace WebApplication6.Controllers
{
    public class MenuController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
