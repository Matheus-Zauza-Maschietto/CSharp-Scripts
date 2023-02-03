using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex1.Entities
{
    public class Installment : ITaxas
    {
        public DateTime DueDate { get; set; }
        public double Amount { get; set; }
        public double Portion { get; set; }
        public Installment(DateTime dueDate, double amount, int actualPortion)
        {
            this.DueDate = dueDate;
            this.Amount = amount;
            this.Portion = actualPortion;
        }


        public double Tax()
        {
            return (this.Amount+MounthTax())*0.02;
        }

        public double MounthTax()
        {
            return this.Amount*(0.01*this.Portion);
        }

        public override string ToString()
        {
            return $"{this.DueDate.ToString("dd/MM/yyyy")} - {this.Amount+Tax()+MounthTax()}";
        }
    }
}