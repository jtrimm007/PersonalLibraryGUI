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
        private List<Book> books { get; set; } = new List<Book>();

        /// <summary>
        /// Gets or sets the Library Owner <see cref="Person"/>.
        /// </summary>
        public Person LibraryOwner { get; set; }

        /// <summary>
        /// Gets the number of books in the list.
        /// </summary>
        public int Count
        {
            get { return books.Count(); }
        }

        /// <summary>
        /// Gets the path of the library save file
        /// </summary>
        public string Path { get { return FileManager.OpenedFilePath; } }

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
                else if (position >= books.Count)
                {
                    throw new ArgumentException($"{position} is greater than or equal to the list count of {books.Count}");
                }
                return books[position];
            }
            set
            {
                books[position] = value;

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
                foreach (Book book in books)
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
                foreach (Book book in books)
                {
                    if (title == book.Title)
                    {
                        books.Remove(book);
                        books.Add(value);
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
            books.Sort();
            return books;
        }

        /// <summary>
        /// The Edit allows a book to be updated.
        /// </summary>
        /// <param name="book">The <see cref="Book"/> being updated.</param>
        /// <returns>An updated <see cref="List{Book}"/>.</returns>
        public List<Book> Edit(Book book)
        {
            var check = books.FirstOrDefault(x => x.Title == book.Title);

            if (check != null)
            {
                this[book.Title] = book;
            }

            return books;
        }

        public List<Book> GetBooksList()
        {
            return books;
        }

        public List<string> GetBooksListOfTitles()
        {
            List<string> booksTitles = new List<string>();
            foreach(var book in books)
            {
                booksTitles.Add(book.Title);
            }

            return booksTitles;
        }

        /// <summary>
        /// RetrieveByAuthor searches for all the books authored or co-authored by the author's name.
        /// </summary>
        /// <param name="author">The author's name <see cref="string"/>.</param>
        /// <returns>A list of all the books associated with the author <see cref="List{Book}"/>.</returns>
        public List<Book> RetrieveByAuthor(string author)
        {
            return (List<Book>)books.Where(x => x.Author == author || x.Coauthor == author);
        }

        /// <summary>
        /// Adds a book to the library.
        /// </summary>
        /// <param name="library">The library that the book needs to be added to.</param>
        /// <param name="book">The book being added</param>
        /// <returns>The updated <see cref="PersonalLibrary"/> object.</returns>
        public static PersonalLibrary operator +(PersonalLibrary library, Book book)
        {
            library.books.Add(book);
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
            library.books.Remove(book);
            return library;
        }
        public void SetOwnerAndBooksList()
        {
            SetOwner();
            PopulateListofBooksFromTextString();

        }
        
        private void SetOwner()
        {
            if (FileManager.TextFromFile != null || FileManager.TextFromFile != String.Empty)
            {
                var split = FileManager.TextFromFile.Split('\n');
                var getOwnerInfo = SplitLibraryOwnerRow(split[0]);

                LibraryOwner = CreateNewPerson(getOwnerInfo);
            }
        }
        private Person CreateNewPerson(string[] ownerInfo)
        {
            return new Person(ownerInfo[0], ownerInfo[1], ownerInfo[2], ownerInfo[3], ownerInfo[4], ownerInfo[5], ownerInfo[6], ownerInfo[7].Replace("\r", ""));
        }
        private string[] SplitLibraryOwnerRow(string ownerString)
        {
            return ownerString.Split(FileManager.GlobalDelimiter);
        }
        private void PopulateListofBooksFromTextString()
        {
            if(FileManager.TextFromFile != null || FileManager.TextFromFile != String.Empty)
            {
                var split = FileManager.TextFromFile.Split('\n');

                // Add the books from the text file to the Books list.
                SetListOfBooks(split);
            }
        }

        private void SetListOfBooks(string[] splitArray)
        {
            //Skip the first row because that is the library owners information.
            for(var i = 1; i < splitArray.Length; i++)
            {
                if (splitArray[i] == String.Empty)
                    return;

                books.Add(CreateBookFromDelimitedRow(splitArray[i]));
            }
        }

        private Book CreateBookFromDelimitedRow(string row)
        {

            var split = row.Split(FileManager.GlobalDelimiter);

            //if (split[5] == "0")
            //    split[5] = "0.00";

            Decimal priceHolder;
            Decimal.TryParse(split[5], out priceHolder);
            return new Book(split[0], split[1], split[2], split[3], split[4], priceHolder);
        }
    }
}
