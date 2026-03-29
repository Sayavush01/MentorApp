using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Data;
using WebApplication1.ViewModels;

namespace WebApplication1.Controllers
{
    public class PricingController(MentorAppDbContext context) : Controller
    {
        public IActionResult Index()
        {
            var pricings = context.Pricings.Include(p => p.PricingServices).ThenInclude(ps => ps.Service).ToList();


            var services = context.Services.ToList();

            PricingVm pricingVm = new PricingVm
            {
                Pricings = pricings,
                Services = services
            };
            return View(pricingVm);
        }
    }
}
