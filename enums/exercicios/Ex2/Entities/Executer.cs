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

            WorkerLevel workerEnum;
            do{
                try{
                    System.Console.WriteLine("Level (Junior/MidLevel/Senior): ");
                    workerEnum = Enum.Parse<WorkerLevel>(Console.ReadLine());
                    System.Console.WriteLine(workerEnum);
                    break;
                }
                catch{
                    System.Console.WriteLine("Você digitou um valor invalido, tente novamente !");
                }
                
            }while(true);
            
            while(true){
                try{
                    System.Console.Write("Base Salary: ");
                    double salary = double.Parse(Console.ReadLine());
                    break;
                }
                catch{
                    System.Console.WriteLine("Você digitou um valor invalido !");
                }
            }

            int contractNumbers;
            do{
                try{
                    System.Console.Write("How many contracts to this worker ?: ");
                    contractNumbers = int.Parse(Console.ReadLine());
                    break;
                }
                catch{
                    System.Console.WriteLine("Você digitou um valor invalido !");
                }
            }while(true);
            Worker worker = new Worker();
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
                }while(valuePerHour <= 1);
                do{
                    try{
                        System.Console.Write("Duration (Hours): ");
                        duration = int.Parse(Console.ReadLine());
                        break; 
                    }
                    catch{
                        System.Console.WriteLine("Você digitou um valor invalido");
                    }
                }while(duration <= 1);
                }
            
            
     
        }
    }
}