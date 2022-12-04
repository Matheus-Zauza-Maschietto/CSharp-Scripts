using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VetoremC_.exercicios
{
    public class employer{
        public int Id { get; private set; }     
        public string Name { get; private set; }
        public double Salary { get; private set; } 

        public employer(int id, string name, double salary){
            Id = id;
            Name = name;
            Salary = salary;
        }         

        public void SalaryIncrease(double percentage){
            Salary = Salary+Salary*(percentage/100);
        }
    }
    
    public class listEx1
    {
        public listEx1(){
            Console.Write("How many employees will be registred ?: ");
            int employees = int.Parse(Console.ReadLine());    
            List<employer> EmployeesList = new List<employer>();
            employer employer;
            int id=0;
            string? name = null;
            double salary;
            int cont=0;
            bool unicId = false;
            bool notNullName = false;
            while(cont < employees){
                Console.WriteLine($"Employer #{cont}");

                unicId=false;
                while(unicId==false){
                    Console.Write("Id: ");
                    id = int.Parse(Console.ReadLine());

                    unicId = true;
                    foreach(employer item in EmployeesList){
                        if(item.Id == id){
                            Console.WriteLine("This id already exist, try another one.");
                            unicId = false;
                            break;
                        }
                    }
                }

                notNullName = false;
                while(notNullName==false){
                    Console.Write("Name: ");
                    name = Console.ReadLine();

                    if(name != null && name != ""){
                        notNullName = true;
                    }
                    else{
                        Console.WriteLine("Digite algum valor para o nome do funcionario.");
                    }
                }
                

                Console.Write("Salary: ");
                salary = double.Parse(Console.ReadLine());
                
                employer = new employer(id, name, salary);
                EmployeesList.Add(employer);

                cont++;
            }

            double salaryIncress;
            Console.Write("Enter the employee id that will have salary increase: ");
            id = int.Parse(Console.ReadLine());

            
            if(EmployeesList.FindIndex(item => item.Id == id) != -1){
                Console.WriteLine();
                Console.Write("Enter the percentage: ");
                salaryIncress = double.Parse(Console.ReadLine());
                EmployeesList[EmployeesList.FindIndex(item => item.Id == id)].SalaryIncrease(salaryIncress);
            }
            else{
                Console.WriteLine("This id does not exist.");
            }

            Console.WriteLine("Update list of employees");
            foreach(employer item in EmployeesList){
                Console.WriteLine($"{item.Id} - {item.Name} - {item.Salary}");
            }   
            
            

        }
    }
}