using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPoo.models
{
    public class ContaCorrente
    {

        public ContaCorrente(int numeroConta, decimal saldoInicial)
        {
            NumeroConta = numeroConta;
            saldo = saldoInicial;
        }


        public int NumeroConta { get; set; }

        private decimal saldo;


        public void Sacar(decimal valor)
        {

            if (saldo >= valor)
            {
                saldo -= valor;
                Console.WriteLine("Saque relizado");
            }
            else
            {
                Console.WriteLine("Valor desejado é maior que o salo disponivel");
            }
        }
        
        public void ExibirSaldo()
        {
            Console.WriteLine($"Seu saldo disponivel é {saldo}");
        }


    }
}