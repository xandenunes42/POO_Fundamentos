using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO_Fundamentos.Models
{
    public class Professor : Pessoa //Professor herda de Pessoa
    {
        public double Salario { get; set; }
        //Propriedade individual de Professor
        public Professor()
        {

        }

        public override void Apresentar() //override = Sobrescrever(alterar) o metodo pai Apresentar da classe Pessoa
        {
            Console.WriteLine($"Ola ! Me chamo {Nome} e esse eh meu endereco de email para contato {Email}\nMeu salario como professor eh de {Salario.ToString("C")}");
        }
    }
}