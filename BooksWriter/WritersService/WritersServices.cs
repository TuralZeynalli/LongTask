using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BooksWriter
{
    class WritersServices : Writers
    {

        public WritersServices(string name, string surname, string books) : base (name, surname, books)
        {

        }

        public void ShowAuthorsBook(List<Writers> books)         
        {
            foreach (var book in books)
            {

                Console.WriteLine(book.Books);
            }        
        }


        public void ShowAuthorsNameAndSurname(List<Writers> namesSurnames) 
        
        {
            foreach (var author in namesSurnames)
            {
                Console.WriteLine($"{author.Name} {author.Surname}");
            }
        
        }





    }
}
