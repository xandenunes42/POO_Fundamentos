using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using POO_Fundamentos.Models;

namespace POO_Fundamentos.Models
{
    public class Aluno : Pessoa
    {
        public decimal Nota { get; set; }

        public Aluno()
        {
            
        }
    }
}