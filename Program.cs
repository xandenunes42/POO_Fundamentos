using Models;
using POO_Fundamentos.Models;

//ContaCorrente c1 = new ContaCorrente("12345", 1000);

//c1.Sacar(1500);
//c1.ExibirSaldo();

Pessoa p1 = new Pessoa();
p1.Nome = "Alexandre";
p1.Email = "alexandre.oli.nunes@gmail.com";

p1.Apresentar();

Aluno aluno= new Aluno();
aluno.Nome = "Jose";
aluno.Email = "Jose2000@gmail.com";
aluno.Nota = 9;
aluno.Apresentar();

Professor professor= new Professor();
professor.Nome = "Joao";
professor.Email = "joao@gmail.com";
professor.Salario = 10000;
professor.Apresentar();