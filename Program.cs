using SimplesConsumoAPI;

API api = new API();

Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Bem vindo ao SearchMovie console");
Console.ResetColor();
Console.WriteLine();
Console.WriteLine("O que você deseja pesquisar?");
Console.WriteLine();
Console.WriteLine("1 - Um filme em específico");
Console.WriteLine("2 - Pesquisar filmes");
Console.WriteLine();

var escolha = Console.ReadLine();

if (escolha == "1")
{
    Console.Clear();

    while (true)
    {
        Console.WriteLine();
        Console.Write("Digite o título do filme: ");

        var title = Console.ReadLine();
        var movie = await api.GetMovie(title);
        Views.MovieView(movie);
    }
}
else if (escolha == "2")
{
    Console.Clear();

    while (true)
    {
        Console.WriteLine();
        Console.Write("Digite um título: ");

        var title = Console.ReadLine();
        var searchResponse = await api.GetSearchResponse(title);
        Views.SearchResponseView(searchResponse);
    }
}
else
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Escreva corretamente!");
    Console.ResetColor();
}