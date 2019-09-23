using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LanguageFeatures.Models
{
    public class Product
    {
        public Product(bool stock=true)
        {
            InStock = stock;
        }
        /// <summary>
        /// Название продукта
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Категория товара
        /// </summary>
        public string Category { get; set; } = "Watersports";
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
        public bool InStock { get; } = true;
        public bool NameBeginsWithS => Name?[0] == 'S';
        public static Product[] GetProducts()
        {
            Product kayak = new Product
            {
                Name = "Kayak",
                Category ="Water Craft",
                Price = 275M
            };
            Product lifejacket = new Product(false)
            {
                Name = "Lifejaket",
                Price = 48.95M
            };
            kayak.Related = lifejacket;
            return new Product[] { kayak, lifejacket ,null};
        }
    }
}
