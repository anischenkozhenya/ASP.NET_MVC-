using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using WorkingWithVisualStudio.Controllers;
using WorkingWithVisualStudio.Models;
using Microsoft.AspNetCore.Mvc;
namespace WorkingWithVisualStudio.Tests
{
    public class HomeControllerTests
    {
        public class ModelCompleteFakeRepository : IRepository
        {
            public IEnumerable<Product> Products { get; set; }
            public void AddProduct(Product p)
            {

            }
            [Theory]
            [InlineData(275, 48.95, 19.50, 24.95)]
            [InlineData(5, 48.95, 19.50, 24.95)]
            public void IndexActionIsComplete(decimal price1, decimal price2, decimal price3, decimal price4)
            {
                var controller = new HomeController();
                controller.Repository = new ModelCompleteFakeRepository
                {
                    Products = new Product[]
                    {
                        new Product { Name = "P1", Price = price1 },
                        new Product { Name = "P2", Price = price2 },
                        new Product { Name = "P3", Price = price3 },
                        new Product { Name = "P4", Price = price4 }
                    }
                };

                var model = (controller.Index() as ViewResult)?.ViewData.Model as IEnumerable<Product>;
                Assert.Equal(controller.Repository.Products, model,
                    Comparer.Get<Product>((p1, p2) => p1.Name == p2.Name && p1.Price == p2.Price));
            }
            public class ModelCompleteFakeRepositoryPriceUnder50 : IRepository
            {
                public IEnumerable<Product> Products { get; }
                = new Product[]
                {

                new Product{Name="P1",Price=5M},
                new Product{Name="P2",Price=48.95M},
                new Product{Name="P3",Price=19.50M},
                new Product{Name="P4",Price=34.95M}
                };
                public void AddProduct(Product p)
                {

                }
                [Fact]
                public void IndexModelCompleteFakeRepositoryPriceUnder50()
                {
                    var controller = new HomeController();
                    controller.Repository = new ModelCompleteFakeRepositoryPriceUnder50();
                    var model = (controller.Index() as ViewResult)?.ViewData.Model as IEnumerable<Product>;
                    Assert.Equal(controller.Repository.Products, model,
                        Comparer.Get<Product>((p1, p2) => p1.Name == p2.Name && p1.Price == p2.Price));
                }
            }
        }
    }
}