using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LanguageFeatures.Models
{
    public class Product
    {
        /// <summary>
        /// Название продукта
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Цена товар
        /// </summary>
        public decimal? Price { get; set; }
        /// <summary>
        ///Связанный товар
        /// </summary>
        public Product Related { get; set; }
        /// <summary>
        /// Получить товары
        /// </summary>
        /// <returns>Массив товаров</returns>
        public static Product[] GetProducts()
        {
            Product kayak = new Product { Name = "Kayak", Price = 275M };

            Product lifejacket = new Product { Name = "Lifejaket", Price = 48.95M };
            kayak.Related = lifejacket;
            return new Product[] { kayak, lifejacket ,null};
        }
    }
}
