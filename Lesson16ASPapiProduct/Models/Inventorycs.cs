using Lesson16ASPapiProduct.Models.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Lesson16ASPapiProduct.Models
{
    public class Inventorycs
    {
        public List<Product> products = new List<Product>();

        public Inventorycs(string jsonFile)
        {
            string jsonString = File.ReadAllText(jsonFile);
            products = JsonSerializer.Deserialize<List<Product>>(jsonString);
        }

    }
}
