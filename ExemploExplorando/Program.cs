using ExemploExplorando.models;



Pessoa p1 = new Pessoa();
p1.Nome = "Henrique";
p1.Sobrenome = "Alves";


Pessoa p2 = new Pessoa();
p2.Nome = "João";
p2.Sobrenome = "Pedro";




Curso CursoDeIngles = new Curso();
CursoDeIngles.Nome = "Ingês";
CursoDeIngles.Alunos = new List<Pessoa>();

CursoDeIngles.AdicionrAluno(p1);
CursoDeIngles.AdicionrAluno(p2);
CursoDeIngles.ListarAlunos();












/* p1.Nome = "Henrique";
p1.Sobrenome = "Alves";
p1.Idade = 20   ;
p1.Apresentar(); */