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
        bool FilterByPrice(Product p)
        {
            return ((p?.Price ?? 0) >= 20);
        }
        //public IActionResult Index()
        //{
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
        //ShoppingCart cart = new ShoppingCart()
        //{
        //    Products = Product.GetProducts()
        //};
        //Product[] productArray =
        //{
        //    new Product{Name="Kayak",Price=275M},
        //    new Product{Name="Likejacket",Price=48.95M},
        //    new Product{Name="Soccer ball",Price=19.50M},
        //    new Product{Name="Likejacket",Price=34.95M}
        //};
        //Func<Product, bool> nameFilter = delegate (Product prod)
        //   {
        //       return prod?.Name?[0] == 'S';
        //   };
        ////decimal nameFilterTotal = productArray.Filter(nameFilter).TotalPrices();
        //decimal nameFilterTotal = productArray.Filter(p=>p?.Name?[0]=='S').TotalPrices();
        ////decimal priceFilterTotal = productArray.Filter(FilterByPrice).TotalPrices();
        //decimal priceFilterTotal = productArray.Filter(p=>(p?.Price??0)>=20).TotalPrices();
        ////decimal priceFilterTotal = cart.TotalPrices();
        ////decimal nameFilterTotal = productArray.FilterByName('S').TotalPrices();
        //decimal arrayTotal = productArray.FilterByPrice(20).TotalPrices();
        //return View("Index",new string[] {
        //    $"Cart Total:{priceFilterTotal:C2}",
        //    $"Name Total:{nameFilterTotal:C2}",
        //    $"Array Total:{arrayTotal:C2}"
        //});

        //5
        //return View(Product.GetProducts().Select(p => p?.Name));
        //}

        //6
        //public ViewResult Index() => View(Product.GetProducts().Select(p=>p?.Name));

        //7
        //public IActionResult Index()
        //{
        //    var names = new[] { "Kayak", "Lifejacket", "Soccer ball" };
        //    return View(names);
        //}

        //8
        //public IActionResult Index()
        //{
        //    var products = new[] {
        //        new { Name = "Kayak", Price = 275M },
        //        new { Name = "Lifejacket", Price = 48.95M },
        //        new { Name = "Soccer ball", Price = 19.50M },
        //        new { Name = "Corner flag", Price = 34.95M }
        //    };
        //    //return View(products.Select(p => p.Name));
        //    return View(products.Select(p=>p.GetType().Name));
        //}
        public async Task<IActionResult> Index()
        {
            long? length = await MyAsyncMethods.GetPageLength();
            return View(new string[] { $"Length: {length}" });
        }
    }
}
