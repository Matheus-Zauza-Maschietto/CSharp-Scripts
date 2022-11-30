using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VetoremC_.exercicios
{
    public class locatario{
        public string Nome { get; set; }
        public string Email { get; set; }
        public int QuartoAlugado { get; set; }

        public locatario(string nome, string email, int quartoAlugado){
            Nome = nome;
            Email = email;
            QuartoAlugado = quartoAlugado;
        }
    }
    public class exVetores
    {
        public exVetores(){
            locatario[]? quartos = new locatario[10];
            System.Console.Write("Quantos quartos serão alugados ?");
            int quantidade = int.Parse(Console.ReadLine());

            for(int quarto=0; quarto < quantidade; quarto++){
                Console.WriteLine($"Quarto #{quarto}");
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("E-mail: ");
                string email = Console.ReadLine();
                Console.Write("Quarto desejado: ");
                int quartoEscolhido = int.Parse(Console.ReadLine());

                quartos[quartoEscolhido] = new locatario(nome, email, quartoEscolhido);
            }

            Console.WriteLine("Os quartos escolhidos foram:");
            for(int i = 0; i < 10; i++){
                if(quartos[i] != null){
                    Console.WriteLine(quartos[i].QuartoAlugado);
                }
            }
        }
    }
}