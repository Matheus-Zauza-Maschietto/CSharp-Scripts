using System.Globalization;
using Ex1.Entities;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Globalization;
class Program
{
    public static void Main()
    {
        List<Employee> Funcionarios = new List<Employee>(); 
        System.Console.Write("Enter file full path: ");
        string path = System.Console.ReadLine();
        try{
        using(StreamReader sr = File.OpenText(path))
            {
                while(!sr.EndOfStream)
                {
                    string[] line = sr.ReadLine().Split(',');
                    Funcionarios.Add(new Employee(line[0], line[1], double.Parse(line[2], CultureInfo.InvariantCulture)));
                }
            }
        }
        catch(IOException e)
        {
            System.Console.WriteLine(e);
        }
        System.Console.Write("Enter salary: ");
        double salary = double.Parse(System.Console.ReadLine());

        var query = Funcionarios.Where(p => p.Salary > salary).Select(p => p.Email);
        System.Console.WriteLine("Email of people whose salary is more than "+salary);

        foreach(string item in query)
        {
            System.Console.WriteLine(item);
        }

        var SumM = Funcionarios.Where(p => p.Name.ToUpper()[0] == 'M').Sum(p => p.Salary);
        System.Console.Write("Sum of salay people whose name starts with 'M': "+ SumM);
    }
}
