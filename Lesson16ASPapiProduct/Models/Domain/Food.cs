using Lesson16ASPapiProduct.Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_6_Class
{
    public class Food : Product
    {
        public Food(string name, int quantity, decimal price):base(name, quantity, price, TypeProducts.Food)
        {
          
        }
           
    }
}
