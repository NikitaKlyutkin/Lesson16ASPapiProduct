using Lesson16ASPapiProduct.Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_6_Class
{
    internal class Chemical :Product
    {

        public Chemical(string name, int quantity, decimal price) : base(name, quantity, price, TypeProducts.Chemicals)
        {

        }

    }
}
