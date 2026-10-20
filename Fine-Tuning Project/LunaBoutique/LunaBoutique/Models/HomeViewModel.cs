namespace LunaBoutique.Models
{
    public class HomeViewModel
    {
        public List<Product> FeaturedProducts { get; set; } = new();
        public List<Product> NewArrivals { get; set; } = new();
        public List<Product> BestSellers { get; set; } = new();
    }
}