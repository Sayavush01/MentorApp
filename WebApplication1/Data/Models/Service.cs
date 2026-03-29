namespace WebApplication1.Data.Models
{
    public class Service
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public ICollection<PricingServices> PricingServices { get; set; } = new List<PricingServices>();
    }
}
