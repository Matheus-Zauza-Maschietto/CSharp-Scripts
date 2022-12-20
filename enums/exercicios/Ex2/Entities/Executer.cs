using System.Globalization;
using System.Security.Cryptography;
using System.Globalization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using enums.exercicios.Ex2.Entities;
using enums.exercicios.Ex2.Entities.Enums;

namespace enums.exercicios.Ex2.Entities
{
    public class Executer
    {
        public Executer(){

            System.Console.Write("Enter departament's name: ");
            Departament departament = new Departament(Console.ReadLine());

            System.Console.WriteLine("Enter worker data:");
            System.Console.Write("Name: ");
            string workerName = Console.ReadLine();

            WorkerLevel workerEnum = 0;
            do{
                try{
                    System.Console.Write("Level (Junior/MidLevel/Senior): ");
                    workerEnum = Enum.Parse<WorkerLevel>(Console.ReadLine());
                    System.Console.WriteLine(workerEnum.ToString());
                    break;
                }
                catch{
                    System.Console.WriteLine("Você digitou um valor invalido, tente novamente !");
                }
                
            }while(true);
            
            double salary = 0;
            do{
                try{
                    System.Console.Write("Base Salary: ");
                    salary = double.Parse(Console.ReadLine());
                    break;
                }
                catch{
                    System.Console.WriteLine("Você digitou um valor invalido !");
                }
            }while(salary <= 0);

            Worker worker = new Worker(workerName, salary, workerEnum, departament);

            int contractNumbers = 0;
            do{
                try{
                    System.Console.Write("How many contracts to this worker ?: ");
                    contractNumbers = int.Parse(Console.ReadLine());
                }
                catch{
                    System.Console.WriteLine("Você digitou um valor invalido !");
                }
            }while(contractNumbers <= 0);
           

            for(int contract = 1; contract <= contractNumbers; contract++){
                DateTime date = new DateTime();
                double valuePerHour = 0;
                int duration = 0 ;
                System.Console.WriteLine($"Enter #{contract} contract data: ");
                do{
                    try{
                        System.Console.Write("Date (DD/MM/YYYY): ");
                        date = DateTime.ParseExact(Console.ReadLine(),
                                              "dd/MM/yyyy",
                                              CultureInfo.InvariantCulture);
                        break; 
                    }
                    catch{
                        System.Console.WriteLine("Você digitou um valor invalido");
                        System.Console.WriteLine("Lembre se de seguir o formato DD/MM/YYYY !");
                    }
                }while(date.ToString("dd/MM/yyyy HH:mm:ss") == "01/01/0001 00:00:00");
                do{
                    try{
                        System.Console.Write("Value per hour: ");
                        valuePerHour = Double.Parse(Console.ReadLine());
                    }
                    catch{
                        System.Console.WriteLine("Você digitou um valor invalido");
                    }
                }while(valuePerHour <= 0);
                do{
                    try{
                        System.Console.Write("Duration (Hours): ");
                        duration = int.Parse(Console.ReadLine());
                        break; 
                    }
                    catch{
                        System.Console.WriteLine("Você digitou um valor invalido");
                    }
                }while(duration <= 0);
                
                HourContract newContract = new HourContract(date, valuePerHour, duration);
                worker.AddContract(newContract);
                }
            
            System.Console.WriteLine("Enter month and year to calculate income (MM/YYYY): ");
            DateTime dateIncome = DateTime.ParseExact(Console.ReadLine(), "MM/yyyy", CultureInfo.InvariantCulture);
            System.Console.WriteLine($"Name: {worker.Name}");
            System.Console.WriteLine($"Departament: {worker.Departament.Name}");
            double income = 0;
            foreach(HourContract hContract in worker.ContractList){
                if(hContract.Date.Month == dateIncome.Month && hContract.Date.Year == dateIncome.Date.Year){
                    income += hContract.ValuePerHour*hContract.Hours;
                }
            }
            income += worker.BaseSalary;
            System.Console.Write($"Income for {dateIncome.ToString("MM/yyyy")}: {income}");
        }
    }
}
