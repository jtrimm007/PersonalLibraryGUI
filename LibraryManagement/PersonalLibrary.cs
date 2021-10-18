///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Solution/Project:  Personal Library GUI
//	Library Purpose:   To add a layer of abstraction to implement DRY programing principles.
//	File Name:         PersonalLibrary.cs
//	Description:       The Personal Library is used to monitor, edit, and delete items form the collection of books. It also sets a person to the library. 
//	Course:            CSCI 2210 - Data Structures	
//	Author:            Joshua Trimm, trimmj@etsu.edu
//	Created:           10/16/2021
//	Copyright:         Joshua Trimm, 2021
//
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

namespace LibraryManagement
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// <see cref="PersonalLibrary" /> manages a person and their books.
    /// </summary>
    public class PersonalLibrary
    {
        /// <summary>
        /// Private <see cref="List{Book}"/>
        /// </summary>
        private List<Book> Books { get; set; } = new List<Book>();

        /// <summary>
        /// Gets or sets the Library Owner <see cref="Person"/>.
        /// </summary>
        public Person LibraryOwner { get; set; }

        /// <summary>
        /// Gets the number of books in the list.
        /// </summary>
        public int Count
        {
            get { return Books.Count(); }
        }

        /// <summary>
        /// Gets the path of the library save file
        /// </summary>
        public string Path { get; }

        /// <summary>
        /// Gets the file name of the library save file
        /// </summary>
        public string FileName { get; }

        /// <summary>
        /// Sets and gets the save status of a file. 
        /// </summary>
        public bool SaveNeeded { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="PersonalLibrary"/> class.
        /// </summary>
        public PersonalLibrary()
        {
        }

        /// <summary>
        /// Gets or Sets a book in the list based on the index position.
        /// </summary>
        /// <param name="position">index position</param>
        /// <returns>The <see cref="Book"/> if it is found in the list.</returns>
        public Book this[int position]
        {

            get
            {
                if (position < 0)
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

        /// <summary>
        /// Gets or sets a book in the list based on the Key value title. 
        /// </summary>
        /// <param name="title">The Key</param>
        /// <returns>An instance of a <see cref="Book"/></returns>
        public Book this[string title]
        {
            get
            {
                foreach (Book book in Books)
                {
                    if (title == book.Title)
                    {
                        return book;
                    }

                }
                return null;
            }

            set
            {
                foreach (Book book in Books)
                {
                    if (title == book.Title)
                    {
                        Books.Remove(book);
                        Books.Add(value);
                    }
                }
            }
        }
        /// <summary>
        /// Sorts the books in the <see cref="List{Book}"/> is ascending order A-Z. 
        /// </summary>
        /// <returns>The <see cref="List{Book}"/>.</returns>
        public List<Book> SortBooksByTitle()
        {
            Books.Sort();
            return Books;
        }

        /// <summary>
        /// The Edit allows a book to be updated.
        /// </summary>
        /// <param name="book">The <see cref="Book"/> being updated.</param>
        /// <returns>An updated <see cref="List{Book}"/>.</returns>
        public List<Book> Edit(Book book)
        {
            var check = Books.FirstOrDefault(x => x.Title == book.Title);

            if (check != null)
            {
                this[book.Title] = book;
            }

            return Books;
        }

        /// <summary>
        /// RetrieveByAuthor searches for all the books authored or co-authored by the author's name.
        /// </summary>
        /// <param name="author">The author's name <see cref="string"/>.</param>
        /// <returns>A list of all the books associated with the author <see cref="List{Book}"/>.</returns>
        public List<Book> RetrieveByAuthor(string author)
        {
            return (List<Book>)Books.Where(x => x.Author == author || x.Coauthor == author);
        }

        /// <summary>
        /// Adds a book to the library.
        /// </summary>
        /// <param name="library">The library that the book needs to be added to.</param>
        /// <param name="book">The book being added</param>
        /// <returns>The updated <see cref="PersonalLibrary"/> object.</returns>
        public static PersonalLibrary operator +(PersonalLibrary library, Book book)
        {
            library.Books.Add(book);
            return library;
        }

        /// <summary>
        /// Remove a book to the library.
        /// </summary>
        /// <param name="library">The library that the book needs to be removed from.</param>
        /// <param name="book">The book being removed</param>
        /// <returns>The updated <see cref="PersonalLibrary"/> object.</returns>
        public static PersonalLibrary operator -(PersonalLibrary library, Book book)
        {
            library.Books.Remove(book);
            return library;
        }
    }
}
