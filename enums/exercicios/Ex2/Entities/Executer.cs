using System.Security.Cryptography;
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

            for(int contract = 1; contract <= contractNumbers; contract++){
                DateTime date;
                double valuePerHour;
                int duration;
                Console.WriteLine(date);
                System.Console.WriteLine($"Enter #{contract} contract data: ");
                do{
                    try{
                        System.Console.Write("Date (DD/MM/YYYY): ");
                        date = DateTime.Parse(Console.ReadLine());
                        break; 
                    }
                    catch{
                        System.Console.WriteLine("Você digitou um valor invalido");
                        System.Console.WriteLine("Lembre se de seguir o formato DD/MM/YYYY !");
                    }
                }while(true);
                }
            
            
            //Worker worker = new Worker();
            
        }
    }
}