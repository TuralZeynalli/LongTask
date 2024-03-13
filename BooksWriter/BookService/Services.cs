using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace BooksWriter
{
    public class Services : Books
    {

        public Services(string name, int page, Genre genre, string author, int price) : base(name, page, genre, author, price)
        {

        }

        public void ShowAuthorNameAndBookName(List<Books> author)
        {
            foreach (var item in author)
            {
                Console.WriteLine($"{item.Author} - {item.Name}");
            }
        }


        public void ShowMaxPage(List<Books> books)
        {
            int max = 0;

            foreach (var book in books)
            {


                if (book.Page > max)
                {
                    max = book.Page;

                }

            }
            Console.WriteLine(max);
        }

        public void ShowPrice(List<Books> books) 
        {
            foreach (var book in books)
            {
                Console.WriteLine($"{book.Name} price is {book.Price}" );
            }        
        }

        public void ShowBooksAndGenre(List<Books> books)         
        {
            foreach (var book in books)
            {
                Console.WriteLine($"{book.Name} - {book.Genre}");
            }                
        }   
    }
}
