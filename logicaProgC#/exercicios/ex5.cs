using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// Um Posto de combustíveis deseja determinar qual de seus produtos tem a preferência de seus clientes. Escreva 
// um algoritmo para ler o tipo de combustível abastecido (codificado da seguinte forma: 1.Álcool 2.Gasolina 3.Diesel 
// 4.Fim). Caso o usuário informe um código inválido (fora da faixa de 1 a 4) deve ser solicitado um novo código (até 
// que seja válido). O programa será encerrado quando o código informado for o número 4. Deve ser escrito a 
// mensagem: "MUITO OBRIGADO" e a quantidade de clientes que abasteceram cada tipo de combustível, conforme 
// exemplo.

namespace exercicios.ex5
{
    public class ex5
    {
        int Alcool=0;
        int Gasolina=0;
        int Diesel=0;
        string Escolha;
        public ex5(){
            do{
                Console.WriteLine("Qual produto você prefere (1-alcool/2-gasolina/3-diesel/4-sair)");
                Escolha = Console.ReadLine();
                if(Escolha=="1"){
                    Alcool++;
                }
                else if(Escolha=="2"){
                    Gasolina++;
                }
                else if(Escolha=="3"){
                    Diesel++;
                }
            }while(Escolha != "4");
            Console.WriteLine($"alcool: {Alcool}");
            Console.WriteLine($"gasolina: {Gasolina}");
            Console.WriteLine($"diese: {Diesel}");
        }
    }
}