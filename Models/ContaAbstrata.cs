using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO_Fundamentos.Models
{
    public abstract class ContaAbstrata
    {
        protected decimal saldo; //Protegido contra alteracao externas, com excecao de suas filhas

        public abstract void Depositar(decimal valor); //Metodo a ser utilizados por quem herdar a classe abstrata, logo, nao fazemos alteracoes aqui e nem criaremos nenhuma instancia dessa classe

        public void ExibirSaldo()
        {
            Console.WriteLine("Saldo de: " + saldo.ToString("C"));
        }
    }
}