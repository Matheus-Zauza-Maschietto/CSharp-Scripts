using System;
using Ex1.Entities;

class Program
{
    public static void Main()
    {
        System.Console.WriteLine("Enter contract data: ");
        System.Console.Write("Number: ");
        int number = int.Parse(System.Console.ReadLine());

        System.Console.Write("Date(dd/mm/yyyy)");
        DateTime date = DateTime.Parse(System.Console.ReadLine());

        System.Console.Write("Contract value: ");
        double value = double.Parse(System.Console.ReadLine());

        System.Console.Write("Enter Number of installments: ");
        int installments = int.Parse(System.Console.ReadLine());

        Contract contrato = new Contract(number, date, value);
        contrato.AddPortions(installments);
        
        System.Console.WriteLine(contrato);

    }
}