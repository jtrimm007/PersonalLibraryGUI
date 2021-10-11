using LibraryManagement.Enumerations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement
{
    public class Book : IEquatable<Book>, IComparable<Book>
    {
        public BookTypes Type { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Coauthor { get; set; }
        public Categories Category { get; set; }
        public decimal Price { get; set; }

        public int CompareTo(Book other)
        {
            return this.Title.CompareTo(other.Title);
        }

        public bool Equals(Book other)
        {
            return this.GetHashCode() == other.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return base.Equals(obj);

            if (!(obj is Book))
                throw new ArgumentException($"{obj} is not a type Book");

            return Equals(obj as Book);
        }

        public override int GetHashCode()
        {
            return Title.GetHashCode() + Author.GetHashCode();
        }
    }
}
