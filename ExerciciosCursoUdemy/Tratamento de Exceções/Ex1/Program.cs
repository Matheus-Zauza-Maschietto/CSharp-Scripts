using Ex1.Entities.Exceptions;
using Ex1.Entities;

class Program
{
    public static void Main()
    {
        System.Console.WriteLine("Enter account data: ");
        System.Console.Write("Number: ");
        int number = int.Parse(System.Console.ReadLine());

        System.Console.Write("Holder: ");
        string holder = System.Console.ReadLine();

        System.Console.Write("Initial balance: ");
        double balance = double.Parse(System.Console.ReadLine());

        System.Console.Write("Withdraw limit: ");
        double limite = double.Parse(System.Console.ReadLine());

        Account Acc = new Account(number, holder, balance, limite);

        System.Console.Write("Enter amount for withdraw: ");
        double withdraw = double.Parse(System.Console.ReadLine());

        try{
            Acc.WithDraw(withdraw);
        }
        catch(AccountException e)
        {
            System.Console.WriteLine(e.Message);
        }
    }
}
