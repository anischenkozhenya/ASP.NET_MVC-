using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LanguageFeatures.Models;
using Microsoft.AspNetCore.Mvc;


namespace LanguageFeatures.Controllers
{
    public class HomeController : Controller
    {
        
        public IActionResult Index()
        {
            //1
            //List<string> results = new List<string>();
            //foreach (Product p in Product.GetProducts())
            //{
            //    string name = p?.Name??"<No Name>";
            //    decimal? price = p?.Price??0;
            //    string relatedName = p?.Related?.Name??"<None>";
            //    results.Add($"Name: {name}, Price: {price:C2}, Related: {relatedName}");
            //    //results.Add(string.Format("Name: {0}, Price: {1}, Related: {2}", name, price,relatedName));
            //}
            //return View(results);

            //2
            //return View("Index", new string[] { "Bob", "Joe", "Alice" });

            //3
            //Dictionary<string, Product> products = new Dictionary<string, Product>
            //{
            //    [ "Kayak"]=new Product { Name = "Kayak", Price = 275M },
            //    ["Lifejacket"]=new Product { Name = "Lifejaket", Price = 48.95M }
            //};
            //return View("Index",products.Keys);

            //4
            ShoppingCart cart = new ShoppingCart()
            {
                Products = Product.GetProducts()
            };
            Product[] productArray =
            {
                new Product{Name="Kayak",Price=275M},
                new Product{Name="Likejacket",Price=48.95M},
                new Product{Name="Soccer ball",Price=19.50M},
                new Product{Name="Likejacket",Price=34.95M}
            };
            decimal cartTotal = cart.TotalPrices();
            decimal arrayTotal = productArray.FilterByPrice(20).TotalPrices();
            return View("Index",new string[] {
                $"Cart Total:{cartTotal:C2}",
                $"Array Total:{arrayTotal:C2}"
            });
        }
    }
}
