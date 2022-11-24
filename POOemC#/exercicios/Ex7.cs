using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POOemC_.exercicios.intermediario
{
    class ContaBancaria{
        private int _numeroConta;
        private string _titular;
        public decimal Saldo { get;  private set; }

        public ContaBancaria(string titular, int _numero_conta){
            _numeroConta = _numero_conta;
            Titular = titular;
        }
        public ContaBancaria(string titular, int _numero_conta, double valor):this(titular, _numero_conta){
            Saldo = (decimal)valor;
        }

        public string Titular{
            get{
                return _titular;
            }
            set{
                _titular = value;
            }
        }

        public void Deposito(double valor){
            if(valor > 0){
                Saldo += (decimal)valor;
            }
        }

        public void Saque(double valor){
            if(valor > 0 && valor != 0){
                Saldo -= ((decimal)valor+5);
            }
        }       

        public override string ToString(){
            return $"A conta de numero: {_numeroConta} , do titular {_titular} , possui $ {Saldo} reais de saldo";
        }
    }
    class Ex7{
        public Ex7(){
            ContaBancaria conta;
            Console.Write("Ente com o número da conta: ");
            int nmrConta = int.Parse(Console.ReadLine());
            Console.Write("Entre com o titular da conta: ");
            string? titular = Console.ReadLine();
            Console.Write("Haverá deposito inicial (s/n): ");
            string? deposioInicial = Console.ReadLine();

            if(deposioInicial == "s"){
                Console.Write("Entre com o valor de depósito inicial: ");
                double deposito = int.Parse(Console.ReadLine());
                conta = new ContaBancaria(titular, nmrConta, deposito);
            }
            else{
                conta = new ContaBancaria(titular, nmrConta);    
            }
            string? continuar;
            double valor;
            do{
                

                Console.Write("Ente com um valor para saque: ");
                valor = double.Parse(Console.ReadLine());
                conta.Saque(valor);

                Console.Write("Ente com um valor para deposito: ");
                valor = double.Parse(Console.ReadLine());
                conta.Deposito(valor);

                continuar = "n";
                Console.Write("Deseja sair ? (s/n): ");
                continuar = Console.ReadLine().ToLower();

                Console.WriteLine($" {conta}");
            }while(continuar == "n");

        }
    }
}