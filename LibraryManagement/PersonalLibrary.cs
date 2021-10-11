using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement
{
    public class PersonalLibrary
    {
        private List<Book> Books;
        public Person LibraryOwner { get; set; }
        public int Count { get; set; }
        public readonly string Path;
        public bool Saveneeded { get; set; }

        public Book this[int position]
        {
            get
            {
                if(position < 0)
                {
                    throw new ArgumentException($"{position} is less than 0.");
                }
                else if (position >= Books.Count)
                {
                    throw new ArgumentException($"{position} is greater than or equal to the list count of {Books.Count}");
                }
                return Books[position];
            }
            set
            {
                Books[position] = value;

            }
        }

        public Book this[string title]
        {
            get
            {
                foreach(Book book in Books)
                {
                    if(title == book.Title)
                    {
                        return book;
                    }
                    
                }
                return null;
            }
        }
    }
}
