using Lesson_6_Class;
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

        public TypeProducts T { get; private set; }

        public void AddProduct(Product product)
        {
            _inventory.products.Add(product);
        }

        public void AddSomeProducts(List<Product> products)
        {
            foreach (Product product in products)
            {
                _inventory.products.Add(product);
            }
        }

        public List<Product> GetAllProducts()
        {
            return _inventory.products;
        }

        public void ReplaceProduct(int idProduct, Product product)
        {
            _inventory.products[idProduct] = product;
        }

        public List<T> SortByType<T>() where T : Product
        {
            var resultSortedList = new List<T>();
            
            foreach (var product in _inventory.products)
            {
                var castedProduct = product as T;
                if (castedProduct != null)
                    resultSortedList.Add(castedProduct);
            }

            return resultSortedList;
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

        public decimal SummProductsOnType(TypeProducts type)
        {
            decimal result = 0;
            foreach (Product product in _inventory.products)
            {
                if (product._typeProducts == type)
                {
                    result += product._price;
                }
            }

            return result;
        }
    }
}
