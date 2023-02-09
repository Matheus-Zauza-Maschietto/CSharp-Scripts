using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex1.Entities
{
    public class Employee
    {
       public string Name { get; set; }
       public string Email { get; set; }
       public double Salary { get; set; }

       public Employee(string name, string email, double salary)
       {
        this.Name = name;
        this.Email = email;
        this.Salary = salary;
       } 
    }
}