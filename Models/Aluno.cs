using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using POO_Fundamentos.Models;

namespace POO_Fundamentos.Models
{
    public class Aluno : Pessoa //Aluno herda de Pessoa
    {
        public decimal Nota { get; set; }
        //Propriedade individual de Aluno
        public Aluno()
        {

        }

        public override void Apresentar() //override = Sobrescrever(alterar) o metodo pai Apresentar da classe Pessoa
        {
            {
                Console.WriteLine($"Ola ! Me chamo {Nome}, sou estudante e esse eh meu endereco de email para contato {Email}\nMinha media como aluno eh {Nota}");
            }
        }
    }
}