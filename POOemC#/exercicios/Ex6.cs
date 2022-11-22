using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// Faça um programa para ler a cotação do dólar, e depois um valor em dólares a ser comprado por
// uma pessoa em reais. Informar quantos reais a pessoa vai pagar pelos dólares, considerando ainda
// que a pessoa terá que pagar 6% de IOF sobre o valor em dólar. Criar uma classe ConversorDeMoeda
// para ser responsável pelos cálculos

namespace POOemC_.exercicios.introducao
{   
    public static class ConversorDeMoeda{
        private static double IOF = 0.06;
        public static double Converter(double cotacao, double qntDolares){
            double conversao = cotacao*qntDolares;
            return conversao+(conversao*IOF);
        }
    }

}