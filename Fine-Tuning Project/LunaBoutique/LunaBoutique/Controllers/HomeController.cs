using LunaBoutique.Models;
using Microsoft.AspNetCore.Mvc;

namespace LunaBoutique.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var model = new HomeViewModel
            {
                FeaturedProducts = GetProducts().Where(p => p.IsFeatured).ToList(),
                NewArrivals = GetProducts().Where(p => p.IsNew).ToList(),
                BestSellers = GetProducts().Take(4).ToList()
            };
            return View(model);
        }

        private List<Product> GetProducts()
        {
            return new List<Product>
            {
                new Product { Id=1, Name="Rose Soirée Dress", Price=1200, Category="Dresses", IsFeatured=true, IsNew=true, Rating=4.8, ImageUrl="/images/dress1.jpg" },
                new Product { Id=2, Name="Elegant Evening Dress", Price=950, Category="Dresses", IsFeatured=true, IsNew=true, Rating=4.9, ImageUrl="/images/dress.jpg" },
                new Product { Id=3, Name="Floral Midi Dress", Price=1400, Category="Dresses", IsFeatured=false, IsNew=true, Rating=4.7, ImageUrl="/images/dress-withpepole.jpg" },
                new Product { Id=4, Name="Ivory Ruffle Blouse", Price=450, Category="Tops", IsFeatured=true, IsNew=false, Rating=4.5, ImageUrl="/images/blouza.jpg" },
                new Product { Id=5, Name="Classic White Tee", Price=320, Category="Tops", IsFeatured=false, IsNew=true, Rating=4.4, ImageUrl="/images/tshirt-withpepole.jpg" },
                new Product { Id=6, Name="Pleated Midi Skirt", Price=680, Category="Skirts", IsFeatured=true, IsNew=true, Rating=4.7, ImageUrl="/images/skirt.jpg" },
                new Product { Id=7, Name="Luxury Fur Coat", Price=2800, Category="Coats", IsFeatured=true, IsNew=false, Rating=4.9, ImageUrl="/images/coat.jpg" },
                new Product { Id=8, Name="Winter Coat", Price=2200, Category="Coats", IsFeatured=false, IsNew=true, Rating=4.6, ImageUrl="/images/coat-withpeople.jpg" },
                new Product { Id=9, Name="Tailored Trousers", Price=780, Category="Trousers", IsFeatured=true, IsNew=true, Rating=4.5, ImageUrl="/images/trouser-withpeople.jpg" },
                new Product { Id=10, Name="Gold Hoop Earrings", Price=550, Category="Accessories", IsFeatured=true, IsNew=true, Rating=4.8, ImageUrl="/images/acessory.jpg" },
                new Product { Id=11, Name="Jewellery Set", Price=420, Category="Accessories", IsFeatured=false, IsNew=true, Rating=4.6, ImageUrl="/images/assosiy2.jpg" },
                new Product { Id=12, Name="Black Heels", Price=890, Category="Shoes", IsFeatured=true, IsNew=true, Rating=4.7, ImageUrl="/images/shoose.jpg" },
                new Product { Id=13, Name="Makeup Kit Vol.1", Price=650, Category="Beauty", IsFeatured=false, IsNew=true, Rating=4.5, ImageUrl="/images/make_up1.jpg" },
                new Product { Id=14, Name="Makeup Kit Vol.2", Price=720, Category="Beauty", IsFeatured=true, IsNew=false, Rating=4.8, ImageUrl="/images/makeup_2.jpg" }
            };
        }
    }
}