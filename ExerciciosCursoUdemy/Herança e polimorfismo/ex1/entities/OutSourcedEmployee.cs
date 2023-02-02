using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExerciciosCursoUdemy.entities
{
    public class OutSourcedEmployee : Employee
    {
        public double AdditionalCharge { get; set; }


        public OutSourcedEmployee( string name, int hours, double valuePerHours, double additionalCharge): base(name, hours, valuePerHours)
        {
            this.AdditionalCharge = additionalCharge;
        }

        public override double Payment()
        {
            return base.Payment() + 1.1 * AdditionalCharge;
        }
    }
}