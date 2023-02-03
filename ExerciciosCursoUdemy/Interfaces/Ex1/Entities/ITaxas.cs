using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex1.Entities
{
    public interface ITaxas
    {
        double Tax();
        double MounthTax();
    }
}