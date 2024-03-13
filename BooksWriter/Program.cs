using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BooksWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Books

            Services book1 = new Services("Devil", 100, Genre.Romantic, "Tolstoy", 7);

            Services book2 = new Services("Stranger", 92, Genre.Roman, "Albert", 5);
            Services book3 = new Services("Death on the Nile", 156, Genre.Detective, "Agatha", 10);

            List<Books> books = new List<Books> { book1, book2, book3 };

            book1.ShowAuthorNameAndBookName(books);

            book2.ShowPrice(books);

            book1.ShowBooksAndGenre(books);

            #endregion


            #region Authors

            WritersServices writer1 = new WritersServices("Lev", "Tolstoy", "Devil");
            WritersServices writer2 = new WritersServices("Albert", "Camus", "Stranger");
            WritersServices writer3 = new WritersServices("Agatha", "Christie", "Death on the Nile");

            List<Writers> authors = new List<Writers> { writer1, writer2, writer3 };

            writer1.ShowAuthorsBook(authors);

            writer1.ShowAuthorsNameAndSurname(authors);

            Dictionary<Writers, Genre> writers = new Dictionary<Writers, Genre>();

            writers.Add(writer3, Genre.Detective);

            foreach (var genre in writers)
            {

                Console.WriteLine($"{writer3.Name}'s genre is {genre.Value}");
            }

            Dictionary<Genre, int> genres = new Dictionary<Genre, int>();

            foreach (var book in books)
            {
                Console.WriteLine(book.Genre);
            }

            #endregion



        }




    }
}
