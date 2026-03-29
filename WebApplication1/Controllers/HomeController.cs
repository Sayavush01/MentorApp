using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Data;
using WebApplication1.ViewModels;

namespace WebApplication1.Controllers
{
    public class HomeController(MentorAppDbContext context) : Controller
    {
        public async Task<IActionResult> Index()
        {
            var slider = await context.Sliders.FirstOrDefaultAsync();

            var homeVm = new HomeVm
            {
                Slider = slider!
            };

            return View(homeVm);
        }
    }
}