using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Yeli_il_Mvc.DAL;
using Yeli_il_Mvc.Models;

namespace Yeli_il_Mvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
           _context = context;
        }
        public async Task<IActionResult> Index()
        {
            List<Slide> slides = await _context.Slides.OrderBy(o=>o.Order).Take(3).ToListAsync();


            return View(slides);
        }

    }
}
