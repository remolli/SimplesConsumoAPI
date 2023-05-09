using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplesConsumoAPI
{
    public static class Views
    {
        public static void MovieView(MovieModel movie)
        {
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

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("Poster: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(movie.Poster);

            Console.ResetColor();
        }

        public static void SearchResponseView(SearchResponseModel searchResponse)
        {
            foreach (var movie in searchResponse.Search)
            {
                Console.WriteLine();

                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write("Título: ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(movie.Title);

                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write("Lançado em ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(movie.Year);

                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write("Tipo: ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(movie.Type);

                Console.ResetColor();
                Console.WriteLine();
                Console.WriteLine(new string('-', 20));
            }

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("Total de resultados: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(searchResponse.totalResults);

            Console.ResetColor();
        }
    }
}
