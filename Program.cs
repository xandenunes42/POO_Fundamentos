using Models;
using POO_Fundamentos.Models;

QuebraDeLinha();

Console.WriteLine("CONTA CORRENTE");

QuebraDeLinha();

ContaCorrente contaCorrente = new ContaCorrente();
contaCorrente.Depositar(500);
contaCorrente.ExibirSaldo();

QuebraDeLinha();

Console.WriteLine("CONTA POUPANCA");

QuebraDeLinha();

ContaPoupanca contaPoupanca = new ContaPoupanca();
contaPoupanca.Depositar(1500);
contaPoupanca.ExibirSaldo();

QuebraDeLinha();



/*

Pessoa p1 = new Pessoa();
p1.Nome = "Alexandre";
p1.Email = "alexandre.oli.nunes@gmail.com";

QuebraDeLinha();
p1.Apresentar();
QuebraDeLinha();

Aluno aluno= new Aluno(); 
aluno.Nome = "Jose"; //Utilizacao de Heranca
aluno.Email = "Jose2000@gmail.com";
aluno.Nota = 9;
aluno.Apresentar();
QuebraDeLinha();

Professor professor= new Professor();
professor.Nome = "Joao";
professor.Email = "joao@gmail.com";
professor.Salario = 10000;
professor.Apresentar();
QuebraDeLinha();

*/

static void QuebraDeLinha()
{
    Console.WriteLine(new string('-', 120));
}

