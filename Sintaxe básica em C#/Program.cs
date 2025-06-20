
//Trabalhando com for
/* int numero = 10;


for (int cont = 0; cont <= 10; cont++)
{
    Console.WriteLine($"{numero} * {cont} = {numero*cont}");
} */


//Trabalhando com While

/* int teste = 10;
int contador1 = 0;

while (contador1 <= 10)
{
    Console.WriteLine($"{contador1 + 1}° Execução: {teste} x {contador1} = {teste * contador1}"); 
    contador1++;
} */

using System.Reflection.Metadata;

string opcao;
bool exibir = true;

while (exibir)
{
    Console.Clear();
    Console.WriteLine("Digite a sua opção:");
    Console.WriteLine("1- Cadastrar cliente");
    Console.WriteLine("2- Buscar cliente");
    Console.WriteLine("3- Apagar cliente");
    Console.WriteLine("4- Encerrar");

    opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            Console.WriteLine("Um cadastro de cliente");
            break;

        case "2":
            Console.WriteLine("Busca de cliente");
            break;

        case "3":
            Console.WriteLine("Apagar cliente");
            break;

        case "4":
            Console.WriteLine("Encerrar");
            exibir = false;
            break;

        default:
            Console.WriteLine("Opção ivalida!");
            break;
    }
}

Console.WriteLine("O programa foi encerrado!");