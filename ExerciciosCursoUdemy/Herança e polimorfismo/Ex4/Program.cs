using Ex4.Entities;

class Program
{
    public static void Main()
    {
        List<Pessoa> list = new List<Pessoa>();
        System.Console.Write("Enter the number of tax payers: ");
        int payers = int.Parse(System.Console.ReadLine());
        for(int index = 0; index < payers; index++)
        {
            System.Console.Write("Individual or Company (i/c): ");
            char type = char.Parse(System.Console.ReadLine());

            System.Console.Write("Name: ");
            string name = System.Console.ReadLine();

            System.Console.Write("Anual income: ");
            double income = double.Parse(System.Console.ReadLine());

            if(type == 'c'){
                System.Console.Write("Number os employees");
                int employees = int.Parse(System.Console.ReadLine());
                list.Add(new PessoaJuridica(employees, name, income));
            }
            else{
                System.Console.Write("Health expenditures: ");
                double healtCare = double.Parse(System.Console.ReadLine());
                list.Add(new PessoaFisica(name, income, healtCare));
            }
        }
        System.Console.WriteLine("TAXES PAID");
        foreach(Pessoa item in list){
            System.Console.WriteLine(item.ImpostoDeRenda().ToString());
        }
    }
}
