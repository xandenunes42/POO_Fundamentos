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
        
        public void Apresentar()
        {
            Console.WriteLine($"Ola me chamo {Nome} e esse eh meu endereco de email {Email}");
        }
    }
}