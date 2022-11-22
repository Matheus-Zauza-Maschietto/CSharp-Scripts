using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// Fazer um programa para ler os dados de duas pessoas, depois mostrar o nome da pessoa mais 
// velha.

namespace POOemC_.exercicios.introducao
{
    public class Pessoa
    {
        public string Nome;
        public int Idade;

        public Pessoa(){
            Console.Write("Digite o nome: ");
            Nome = Console.ReadLine();
            Console.Write("Digite a idade: ");
            Idade = int.Parse(Console.ReadLine());
        }
    }

    public class Ex1{
        public Ex1(){
            Pessoa p1 = new Pessoa();
            Pessoa p2 = new Pessoa();
            if(p1.Idade > p2.Idade){
                Console.WriteLine($"{p1.Nome} é mais velho que {p2.Nome}");
            } 
            else if(p2.Idade > p1.Idade){
                Console.WriteLine($"{p2.Nome} é mais velho que {p1.Nome}");
            }
            else{
                Console.WriteLine($"{p1.Nome} e {p2.Nome} tem a mesma idade");
            } 
        }
    }
}