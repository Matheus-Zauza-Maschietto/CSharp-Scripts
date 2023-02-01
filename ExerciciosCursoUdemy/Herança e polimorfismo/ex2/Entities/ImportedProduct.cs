using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ex2.Entities
{
    public class ImportedProduct: Product
    {
        public double CustomsFee { get; set; }
        public ImportedProduct(string name, double price, double customsFee) : base(name, price)
        {
            
        }
    }
}