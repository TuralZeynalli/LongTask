using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BooksWriter
{
  public class Books
    {
        public string Name { get; set; }

        public int Page { get; set; }

        public Genre Genre { get; set; }

        public string Author { get; set; }

        public double Price { get; set; }

        public Books(string name, int page, Genre genre, string author, double price)
        {

            Name = name;

            Page = page;

            Genre = genre;

            Author = author;

            Price = price;

        }
    }
}
