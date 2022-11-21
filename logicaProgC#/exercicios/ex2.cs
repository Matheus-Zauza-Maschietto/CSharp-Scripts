using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Globalization;

namespace exercicios.ex2
{
    public class ex2
    {   
        public string nome { get; set; }

        public int quantQuartos { get; set; }

        public double preco { get; set; }

        public string[] lista { get; set; }

        public ex2(){
            Console.WriteLine("Entre com seu nome completo: ");
            nome = Console.ReadLine();
            Console.WriteLine("Quantos quartos tem na sua casa ?");
            quantQuartos = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o preço de um produto: ");
            preco = double.Parse(Console.ReadLine().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Entre seu ultimo nome, idade e altura (mesma linha)");
            lista = Console.ReadLine().split(" ");


            Console.WriteLine(nome);
            Console.WriteLine(quantQuartos);
            Console.WriteLine(preco);
            Console.WriteLine(lista[1]);
            Console.WriteLine(lista[2]);
        }
    }
}