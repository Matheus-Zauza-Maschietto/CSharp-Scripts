using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace enums.exercicios.Ex2.Correcao.entities
{
    public class HourContract
    {
        public DateTime Date { get; set; }
        public double ValuePerHour { get; set; }
        public int Hours { get; set; }
        public HourContract(DateTime date, double valuePerHour, int hours)
        {
            this.Date = date;
            this.ValuePerHour = valuePerHour;
            this.Hours = hours;
        }
        
        public double TotalValue(){
            return this.Hours*this.ValuePerHour;
        }
    }
}