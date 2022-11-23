using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POOemC_.exercicios.intermediario
{
    class ContaBancaria{
        private int _numeroConta;
        public string Titular { get; set; }
        public double Valor { get; set; }

        public ContaBancaria(string titular, int _numero_conta){
            _numeroConta = _numero_conta;
            Titular = titular;
        }
        public ContaBancaria(string titular, int _numero_conta, double valor):this(titular, _numero_conta){
            Valor = valor;
        }

        

    }
}