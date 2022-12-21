using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using enums.exercicios.Ex2.Correcao.entities.Enums;

namespace enums.exercicios.Ex2.Correcao.entities
{
    public class Worker
    {
        public string Name { get; set; }
        public Level Level { get; set; }
        public double BaseSalary { get; set; }
        public Departament Departament { get; set; }
        public List<HourContract> Contracts { get; set; } = new List<HourContract>();
        public Worker(string name, Level level, double baseSalary, Departament departament)
        {
            this.Name = name;
            this.Level = level;
            this.BaseSalary = baseSalary;
            this.Departament = departament;
        }
        public void AddContract(HourContract contract)
        {
            this.Contracts.Add(contract);
        }
        public void RemoveContract(HourContract contract)
        {
            this.Contracts.Remove(contract);
        }


    }
}