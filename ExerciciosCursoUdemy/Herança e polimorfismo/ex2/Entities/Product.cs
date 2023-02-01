using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ex2.Entities
{
    public class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public Product(string name, double price)
        {
            this.Name = name;
            this.Price = price;
        }
        public virtual string priceTag()
        {
            return $"{this.Name} $ {this.Price}";
        }
    }
}