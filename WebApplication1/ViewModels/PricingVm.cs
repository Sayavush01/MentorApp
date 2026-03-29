using WebApplication1.Data.Models;

namespace WebApplication1.ViewModels
{
    public class PricingVm
    {
        public List<Service> Services { get; set; } = new List<Service>();
         public List<Pricing> Pricings { get; set; } = new List<Pricing>();
    }
}
