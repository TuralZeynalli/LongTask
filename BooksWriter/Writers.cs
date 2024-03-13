using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BooksWriter
{
   public class  Writers
    {
        public string Name { get; set; }

        public string Surname { get; set; }

        public string Books { get; set; }

        public Writers(string name, string surname, string books)
        {
            Name = name;

            Surname = surname;

            Books = books;
        }

       
    }
}
