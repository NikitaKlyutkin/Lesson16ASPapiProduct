using Lesson_6_Class;
using Lesson16ASPapiProduct.Models.Domain;
using System.Collections.Generic;

namespace Lesson16ASPapiProduct.Serivces
{
    public interface IActionWithProductService
    {
        public void AddProduct(Product product);


        public void AddSomeProducts(List<Product> products);


        public List<Product> GetAllProducts();

        public void ReplaceProduct(int idProduct, Product product);
        public decimal SummAllProducts();

        public decimal SummProductsOnType(TypeProducts type);
    }
}
