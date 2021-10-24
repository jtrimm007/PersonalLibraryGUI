///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Solution/Project:  Personal Library GUI
//	File Name:         Book.cs
//	Description:       Books can a part of an owners library.
//	Course:            CSCI 2210 - Data Structures	
//	Author:            Joshua Trimm, trimmj@etsu.edu
//	Created:           10/16/2021
//	Copyright:         Joshua Trimm, 2021
//
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

namespace LibraryManagement
{
    using LibraryManagement.Enumerations;
    using System;
    using System.Globalization;

    /// <summary>
    /// <see cref="Book" /> manipulates the book object.
    /// </summary>
    public class Book : IEquatable<Book>, IComparable<Book>
    {
        /// <summary>
        /// Get or set the <see cref="BookTypes"/>
        /// </summary>
        public BookTypes? Type { get; set; }

        /// <summary>
        /// Gets or sets the Title of a <see cref="Book"/>.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the Author of a <see cref="Book"/>.
        /// </summary>
        public string Author { get; set; }

        /// <summary>
        /// Gets or sets the Coauthor of a <see cref="Book"/>.
        /// </summary>
        public string Coauthor { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="Categories"/> of a <see cref="Book"/>.
        /// </summary>
        public Categories? Category { get; set; }

        /// <summary>
        /// Gets or sets the Price of a <see cref="Book"/>.
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Book"/> class. Has no parameters. 
        /// </summary>
        public Book()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Book"/> class.
        /// </summary>
        /// <param name="bookType">The bookType<see cref="string"/>.</param>
        /// <param name="title">The title<see cref="string"/>.</param>
        /// <param name="author">The author<see cref="string"/>.</param>
        /// <param name="coauthor">The coauthor<see cref="string"/>.</param>
        /// <param name="category">The category<see cref="string"/>.</param>
        /// <param name="price">The price<see cref="decimal"/>.</param>
        public Book(string bookType, string title, string author, string coauthor, string category, decimal price)
        {
            this.Type = ParseEnumBookType(bookType);
            this.Title = title;
            this.Author = author;
            this.Coauthor = coauthor;
            this.Category = ParseEnumCategory(category);
            this.Price = price;
        }

        /// <summary>
        /// The CompareTo allows books to be sorted.
        /// </summary>
        /// <param name="other">The <see cref="Book"/> being compared to.</param>
        /// <returns>The <see cref="int"/>.</returns>
        public int CompareTo(Book other)
        {
            return this.Title.CompareTo(other.Title);
        }

        /// <summary>
        /// Check to see if one book is equal to the other based on their titles.
        /// </summary>
        /// <param name="other">The other<see cref="Book"/>.</param>
        /// <returns>The <see cref="bool"/>.</returns>
        public bool Equals(Book other)
        {
            return this.Title == other.Title;
        }

        /// <summary>
        /// Check to see if one book is equal to the other based on their titles.
        /// </summary>
        /// <param name="obj">The obj<see cref="object"/>.</param>
        /// <returns>The <see cref="bool"/>.</returns>
        public override bool Equals(object obj)
        {
            // Check if the object is null
            if (obj == null)
                return base.Equals(obj);

            // If the object isn't a book, throw an exception.
            if (!(obj is Book))
                throw new ArgumentException($"{obj} is not a type Book");

            // return the object as a book.
            return Equals(obj as Book);
        }

        /// <summary>
        /// The ParseEnumBookType gets the Enum BookTypes from a string.
        /// </summary>
        /// <param name="type">The type<see cref="string"/> is the name of an Enum value.</param>
        /// <returns>The <see cref="BookTypes?"/>.</returns>
        public BookTypes? ParseEnumBookType(string type)
        {
            // Ensure that the first letter is upper case. 
            TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;
            type = textInfo.ToTitleCase(type);

            // Declare a holder variable for the out in the TryParse.
            BookTypes bookType;

            // if the TryParse is successful, find out the type of Enum
            if (Enum.TryParse(type, out bookType))
            {
                // Check if the enum type is Digital or Print
                switch (bookType)
                {
                    case BookTypes.Digital:
                        return BookTypes.Digital;
                    case BookTypes.Print:
                        return BookTypes.Print;

                }
            }
            return null; // if it is nether, return null. 
        }

        /// <summary>
        /// The ParseEnumCategory evaluates a string to find it's Enum type for a Books Categories.
        /// </summary>
        /// <param name="category">The category<see cref="string"/>.</param>
        /// <returns>The <see cref="Categories?"/>.</returns>
        public Categories? ParseEnumCategory(string category)
        {
            // Ensure that the first letter is upper case. 
            TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;
            category = textInfo.ToTitleCase(category);

            // Declare a holder variable for the out in the TryParse.
            Categories categoryType;

            // make sure the TryParse is successful, then switch until the Category type is found. 
            if (Enum.TryParse(category, out categoryType))
            {
                switch (categoryType)
                {
                    case Categories.History:
                        return Categories.History;
                    case Categories.Biography:
                        return Categories.Biography;
                    case Categories.Science:
                        return Categories.Science;
                    case Categories.Technology:
                        return Categories.Technology;
                    case Categories.Textbook:
                        return Categories.Textbook;
                    case Categories.Mystery:
                        return Categories.Mystery;
                    case Categories.Comedy:
                        return Categories.Comedy;
                    default:
                        return Categories.Other;

                }
            }
            return null; // return null if it isn't found. 
        }

        /// <summary>
        /// The GetHashCode is override and defined by the Title and Author HashCode.
        /// </summary>
        /// <returns>The <see cref="int"/> HashCode.</returns>
        public override int GetHashCode()
        {
            return Title.GetHashCode() + Author.GetHashCode();
        }
    }
}
