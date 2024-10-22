using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using POO_Fundamentos.Models;

namespace POO_Fundamentos.Models
{
    public class ContaPoupanca : ContaAbstrata
    {
        public override void Depositar(decimal valor)
        {
            saldo += valor;

            Console.WriteLine($"Valor depositado com sucesso !");
        }
    }
}