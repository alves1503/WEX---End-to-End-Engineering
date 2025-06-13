// See https://aka.ms/new-console-template for more information
/* Console.WriteLine("Hello, World!");


int a = 10;

int b = 20;

int c = a + b;

c += 10;

Console.WriteLine(c); */


/* 

using System.Runtime.CompilerServices;

int a = Convert.ToInt32("5"); //CASTING COVERSÃO E DE STRING PARA INTEIRO
int b = int.Parse("8");

Console.WriteLine(a);
Console.WriteLine(b);

 */

/* int inteiro = 5;
string d = inteiro.ToString();

Console.WriteLine(d); */

/* 

int a = 5;
double b = a;

Console.WriteLine(b); */




int quantidadeEstoque = 6;
int quantidadeCompra = 0;
bool possVenda = quantidadeEstoque > quantidadeCompra;



Console.WriteLine($"Quantidade em estoque: {quantidadeEstoque}");
Console.WriteLine($"Quantidade em estoque: {quantidadeCompra}");
Console.WriteLine(possVenda);

if (quantidadeCompra == 0)
{
    Console.WriteLine("Venda invalida");
}
else if (quantidadeEstoque > quantidadeCompra)
{
    Console.WriteLine("Venda realizada");
}
else
{
    Console.WriteLine("Desculpe, não temos disponivel no estoque");
}