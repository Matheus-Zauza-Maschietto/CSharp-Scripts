using System;
using ExerciciosCursoUdemy.entities;
using System.Globalization;
class program{
    static void Main(string[] args)
    {
        List<Employee> list = new List<Employee>();
        System.Console.Write("Enter the number of employees: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            System.Console.WriteLine($"Employee #{i} data");
            Console.Write("Outsourced (y/n) ? ");
            char ch = char.Parse(Console.ReadLine());
            System.Console.Write("Name: ");
            string name = Console.ReadLine();
            System.Console.Write("Hours: ");
            int hours = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            System.Console.Write("Value per hour: ");
            double valuePerHours = double.Parse(Console.ReadLine());
            if(ch == 'y'){
                System.Console.Write("Addtional charge: ");
                double AdditionalCharge = double.Parse(System.Console.ReadLine());
                list.Add(new OutSourcedEmployee(name, hours, valuePerHours, AdditionalCharge));
            }
            else{
                list.Add(new Employee(name, hours, valuePerHours));
            }
        }

        System.Console.WriteLine(
        );

        System.Console.WriteLine("PAYMENTS");
        foreach(Employee emp in list)
        {
            System.Console.WriteLine(emp.Name + " - $ "+emp.Payment().ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}



