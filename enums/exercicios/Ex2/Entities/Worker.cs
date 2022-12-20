using System.Diagnostics.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using enums.exercicios.Ex2.Entities.Enums;

namespace enums.exercicios.Ex2.Entities
{
    public class Worker
    {
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }
        public List<HourContract> ContractList { get; set; } = new List<HourContract>();
        public Departament Departament {get; set;}


        public Worker(string name, double baseSalary, WorkerLevel level, Departament departament)
        {
            Name = name;
            BaseSalary = baseSalary;
            Level = level;
            Departament = departament;
        }

        public void AddContract(HourContract contract)
        {
            ContractList.Add(contract);
        }
        public void Remove(HourContract contract)
        {
            ContractList.Remove(contract);
        }
        public double Income(int year, int month)
        {
            double sum=0;
            foreach(HourContract contract in ContractList)
            {
                if(contract.Date.Year == year && contract.Date.Month == month)
                {
                    sum += contract.TotalValue();
                }
            }
            return sum;
        }

    }
}