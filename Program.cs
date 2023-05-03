using SimplesConsumoAPI;

API api = new API();

while (true)
{
    Console.Write("Digite o título do filme: ");

    var title = Console.ReadLine();
    var movie = await api.GetMovie(title);

    Console.WriteLine();

    Console.ForegroundColor = ConsoleColor.Magenta;
    Console.Write("Título: ");
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine(movie.Title);

    Console.ForegroundColor = ConsoleColor.Magenta;
    Console.Write("Descrição: ");
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine(movie.Plot);

    Console.ForegroundColor = ConsoleColor.Magenta;
    Console.Write("Released: ");
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine(movie.Year);

    Console.ForegroundColor = ConsoleColor.Magenta;
    Console.Write("Genre: ");
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine(movie.Genre);

    Console.ForegroundColor = ConsoleColor.Magenta;
    Console.Write("Starring: ");
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine(movie.Actors);

    Console.ResetColor();
}