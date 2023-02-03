using System.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace Ex1.Entities
{
    public class Contract : IPortions
    {
        public int Number { get; set; }
        public DateTime Date { get; set; }
        public double TotalValue { get; set; }
        List<Installment> Parcelas = new List<Installment>();
        public Contract(int number, DateTime date, double totalValue)
        {
            this.Number = number;
            this.Date = date;
            this.TotalValue = totalValue;
        }

        public void AddPortions(int numberPortions)
        {
            double portion = this.TotalValue/numberPortions;
            for(int index = 1; index <= numberPortions; index++)
            {
                Parcelas.Add(new Installment(Date.AddMonths(index), portion, index));
            }
        }

        public override string ToString()
        {
            StringBuilder Sb = new StringBuilder();
            Sb.AppendLine("Installments: ");
            foreach(Installment item in this.Parcelas)
            {
                Sb.AppendLine(item.ToString());
            }
            return Sb.ToString();
        }
    }
}