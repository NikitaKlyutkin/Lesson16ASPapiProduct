using Lesson16ASPapiProduct.Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_6_Class
{
    internal class Product
    {
        public string _name { get; private set; }
        public int _quantity { get; private set; }
        public decimal _price { get; private set; }

        public TypeProducts _typeProducts;

        public Product(string name, int quantity, decimal price, TypeProducts typeProducts)
        {
            _name = name;
            _quantity = quantity;
            _price = price;
            _typeProducts = typeProducts;
        }
    }

}
