using Microsoft.AspNetCore.Mvc;

namespace WebApplication6.Areas.Manage.Controllers
{
    public class DashboardController : Controller
    {

        [Area("Manage")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
