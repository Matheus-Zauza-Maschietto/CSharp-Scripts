using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExerciciosCursoUdemy.entities
{
    public class Employee
    {
        public string Name { get; set; }
        public int Hours { get; set; }
        public double ValuePerHour { get; set; }

        public Employee(string name, int hours, double valuePerHours)
        {
            this.Name = name;
            this.Hours = hours;
            this.ValuePerHour = valuePerHours;
        }
        public virtual double Payment()
        {
            return Hours * ValuePerHour;
        }
    }
}