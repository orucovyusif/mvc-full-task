using Microsoft.AspNetCore.Mvc;
using WebApplication6.DAL;

namespace WebApplication6.Areas.Manage.Controllers
{
    [Area("Manage")]
    public class ChefController : Controller
    {
        private readonly AppDbContext _context;

        public ChefController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View(_context.Chefs.ToList());
        }
    }
}
