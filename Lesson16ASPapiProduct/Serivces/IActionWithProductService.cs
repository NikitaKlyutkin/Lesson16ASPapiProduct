using Lesson16ASPapiProduct.Models.Domain;
using System.Collections.Generic;

namespace Lesson16ASPapiProduct.Serivces
{
    public interface IActionWithProductService
    {
        public void AddProduct(Product product);

        public List<Product> GetAllProducts();

        public void ReplaceProduct(int idProduct, Product product);
        public decimal SummAllProducts();
    }
}
