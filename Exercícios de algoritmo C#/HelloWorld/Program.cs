// See https://aka.ms/new-console-template for more information
namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is your name?");
            var name = Console.ReadLine();
            var currentDate = DateTime.Now;
            Console.WriteLine($"Hello, {name}, on {currentDate:d} at {currentDate:t}!");
            Console.Write($"{}Press any key to exit...");
            var key = Console.ReadKey(true);
            Console.WriteLine(key.ToString());
        }
    }
}
