using Lesson16ASPapiProduct.Models.Domain;
using Lesson16ASPapiProduct.Models;
using System.Collections.Generic;

namespace Lesson16ASPapiProduct.Serivces
{
    public class ActionWithProductService : IActionWithProductService
    {
        private readonly Inventorycs _inventory;
        public ActionWithProductService(Inventorycs inventory)
        {
            _inventory = inventory;
        }


        public void AddProduct(Product product)
        {
            _inventory.products.Add(product);
        }


        public List<Product> GetAllProducts()
        {
            return _inventory.products;
        }

        public void ReplaceProduct(int idProduct, Product product)
        {
            _inventory.products[idProduct] = product;
        }

        public decimal SummAllProducts()
        {
            decimal result = 0;
            foreach (Product product in _inventory.products)
            {
                result += product._price;
            }

            return result;
        }
    }
}
