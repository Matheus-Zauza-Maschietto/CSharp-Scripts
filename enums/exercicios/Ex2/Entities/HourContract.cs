using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace enums.exercicios.Ex2.Entities
{
    public class HourContract
    {
        public DateTime Date { get; set; }
        public double ValuePerHour { get; set; }
        public int Hours { get; set; }
        public HourContract(DateTime date, double ValuePerHour, int hours)
        {
            Date = date;
            ValuePerHour = ValuePerHour;
            Hours = hours;
        }
        public Double TotalValue(){
            return Hours*ValuePerHour;
        }

    }
}