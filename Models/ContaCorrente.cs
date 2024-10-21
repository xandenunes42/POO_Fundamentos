using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Models
{
    public class ContaCorrente
    {
        public string NumeroConta { get; set; }

        private decimal Saldo { get; set; }

        public ContaCorrente(string numeroConta, decimal saldo)
        {
            NumeroConta = numeroConta;
            Saldo = saldo;
        }

        public void Sacar(decimal valor)
        {
            if (valor > Saldo || valor < 0)
            {
                Console.WriteLine($"Nao foi possivel sacar {valor} ! Saldo atual: {Saldo}");
            }
            else
            {
                Saldo = Saldo - valor;
                Console.WriteLine($"Saque efetuado com sucesso!");
            }
        }

        public void ExibirSaldo()
        {
            Console.WriteLine($"Salto atual: {Saldo}");
        }
    }
}