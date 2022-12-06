using MiNET;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection.PortableExecutable;
using Lesson16ASPapiProduct.Models;

namespace Lesson_6_Class
{
    internal class Initializator
    {

        internal Inventorycs Initialize()
        {
            Inventorycs inventory = new Inventorycs();
            inventory.products = new List<Product>();
            Food apple = new Food(12, "Apple", 20, 12.2m);
            Food orange = new Food(14, "Orange", 10, 9.2m);
            Chemical washingPowder = new Chemical("No", "Washing powder(for machine)", 13, 20.3m);
            Chemical washingblender = new Chemical("No", "Washing Blender", 12, 12.3m);
            Machinery washingMachine = new Machinery("Yes", "Washing machine", 3, 100.2m);
            Machinery BlenderMachine = new Machinery("Yes", "Blender machine", 3, 120.2m);

            inventory.AddProduct(apple);
            inventory.AddProduct(orange);
            inventory.AddProduct(washingPowder);
            inventory.AddProduct(washingMachine);
            inventory.AddProduct(washingblender);
            inventory.AddProduct(BlenderMachine);
            return inventory;
        }
    }
}
