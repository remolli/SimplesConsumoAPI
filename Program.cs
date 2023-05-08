using SimplesConsumoAPI;

Views views = new Views();

Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Bem vindo ao SearchMovie console");
Console.WriteLine();
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("O que você deseja pesquisar?");
Console.WriteLine();
Console.WriteLine("1 - Um filme em específico");
Console.WriteLine("2 - Pesquisar filmes");
Console.WriteLine();

var escolha = Console.ReadLine();

if (escolha == "1")
{
    Console.Clear();
    views.MovieView();
}
else if(escolha == "2") 
{
    Console.Clear();
    views.SearchResponseView();
}
else
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Escreva corretamente!");
}