using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using POO_Fundamentos.Models;

namespace Models
{
    public class ContaCorrente : ContaAbstrata
    {
        private decimal taxaDeposito = 0.10m;
        public override void Depositar(decimal valor) //Metodo herdado da classe abstrata
        {
            //Com essa ideia eh possivel ter diferentes tipos de contas(poupanca/corrente/etc), que herdarao de Conta, abtrata. Cada uma com suas regras dentro do metodo
            
            saldo += valor - taxaDeposito; 

            Console.WriteLine($"Valor depositado com sucesso !\nValor da taxa: {taxaDeposito.ToString("C")}");
        }
    }
}