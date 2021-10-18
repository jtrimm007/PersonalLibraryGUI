using LibraryManagement;
using LibraryManagement.Enumerations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Book> books = new List<Book>();
            books.Add(new Book { Author = "Josha", Category = Categories.History, Coauthor = "Nathan", Price = 4, Title = "The books title", Type = BookTypes.Digital });
            books.Add(new Book { Author = "Josha", Category = Categories.History, Coauthor = "Nathan", Price = 4, Title = "The books title", Type = BookTypes.Digital });
            books.Add(new Book { Author = "Josha", Category = Categories.History, Coauthor = "Nathan", Price = 4, Title = "The books title", Type = BookTypes.Digital });
            books.Add(new Book { Author = "Josha", Category = Categories.History, Coauthor = "Nathan", Price = 4, Title = "The books title", Type = BookTypes.Digital });
            books.Add(new Book { Author = "Josha", Category = Categories.History, Coauthor = "Nathan", Price = 4, Title = "The books title", Type = BookTypes.Digital });

            PersonalLibrary pl = new PersonalLibrary();
            PersonalLibrary pl2 = new PersonalLibrary();

            pl = pl2 + new Book { Author = "Joshau", Category = Categories.History, Coauthor = "Nathan", Price = 4, Title = "The books title", Type = BookTypes.Digital };
        }
    }
}
