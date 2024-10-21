using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO_Fundamentos.Models
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public string Email { get; set; }

        public Pessoa()
        {
        }
        
        public virtual void Apresentar()
        {
            Console.WriteLine($"Ola me chamo {Nome}, sou da classe Pai e esse eh meu endereco de email para contato {Email}\nO Aluno e o Professor irao sobrescrever essa forma de se presentar");
        }
    }
}