using Lesson16ASPapiProduct.Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_6_Class
{
    public class Product
    {
        public string _name { get; set; }
        public int _quantity { get; set; }
        public decimal _price { get; set; }

        public TypeProducts _typeProducts; // только так отображается 


        public Product() { }

        public Product(string name, int quantity, decimal price, TypeProducts typeProducts)
        {
            _name = name;
            _quantity = quantity;
            _price = price;
            _typeProducts = typeProducts;
        }
    }

}
