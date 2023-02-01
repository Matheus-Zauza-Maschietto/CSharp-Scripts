using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ex2.Entities
{
    public class UsedProduct: Product
    {
        public DateTime Date { get; set; }

        public UsedProduct(string name, double price, DateTime date): base(name, price)
        {
            this.Date = date;
        }
        public override string priceTag()
        {
            return $"{this.Name} (used) $ {this.Price}  (Manufacture date: ({this.Date.ToString("dd/MM/yyyy")}))";
        }
    }
}