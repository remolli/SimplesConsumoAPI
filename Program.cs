using SimplesConsumoAPI;

MovieAPI movieAPI = new MovieAPI();

while (true)
{
    Console.Write("Digite um titulo de filme: ");

    var title = Console.ReadLine();
    var movie = await movieAPI.Integracao(title);

    Console.WriteLine();
    Console.ForegroundColor = ConsoleColor.Magenta;
    Console.Write("Título: ");
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine(movie.Title);
    Console.ForegroundColor = ConsoleColor.Magenta;
    Console.Write("Descrição: ");
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine(movie.Plot);
    Console.ResetColor();
}