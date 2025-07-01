using System.Globalization;
using ExemploExplorando.models;

string dataString = "2022-13-17 18:00";




bool sucesso = DateTime.TryParseExact(dataString, "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime data);

if (sucesso)
{
    Console.WriteLine($"Conversão com sucesso da data {data}");
}
else
{
    Console.WriteLine($"{dataString} não é uma data valida");
}





















/* Pessoa p1 = new Pessoa("Henrique", "Alves");


Pessoa p2 = new Pessoa("Ana", "Maria");


double porcentagem = .3421;

Console.WriteLine(porcentagem.ToString("P"));



Curso CursoDeIngles = new Curso();
CursoDeIngles.Nome = "Ingês";
CursoDeIngles.Alunos = new List<Pessoa>();

CursoDeIngles.AdicionrAluno(p1);
CursoDeIngles.AdicionrAluno(p2);
CursoDeIngles.ListarAlunos();

int numero = 123456;

Console.WriteLine(numero.ToString("##-##-##"));






 */





/* p1.Nome = "Henrique";
p1.Sobrenome = "Alves";
p1.Idade = 20   ;
p1.Apresentar(); */