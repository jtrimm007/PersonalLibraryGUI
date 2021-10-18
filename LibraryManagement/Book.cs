///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Solution/Project:  Personal Library GUI
//	Library Purpose:   To add a layer of abstraction to implement DRY programing principles.
//	File Name:         Book.cs
//	Description:       YOUR DESCRIPTION HERE
//	Course:            CSCI 2210 - Data Structures	
//	Author:           Joshua Trimm, trimmj@etsu.edu
//	Created:           10/16/2021
//	Copyright:         Joshua Trimm, 2021
//
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

namespace LibraryManagement
{
    using LibraryManagement.Enumerations;
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Defines the <see cref="Book" />.
    /// </summary>
    public class Book : IEquatable<Book>, IComparable<Book>
    {
        /// <summary>
        /// Gets or sets the Type.
        /// </summary>
        public BookTypes Type { get; set; }

        /// <summary>
        /// Gets or sets the Title.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the Author.
        /// </summary>
        public string Author { get; set; }

        /// <summary>
        /// Gets or sets the Coauthor.
        /// </summary>
        public string Coauthor { get; set; }

        /// <summary>
        /// Gets or sets the Category.
        /// </summary>
        public Categories Category { get; set; }

        /// <summary>
        /// Gets or sets the Price.
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Book"/> class.
        /// </summary>
        public Book()
        {
        }

        /// <summary>
        /// The CompareTo.
        /// </summary>
        /// <param name="other">The other<see cref="Book"/>.</param>
        /// <returns>The <see cref="int"/>.</returns>
        public int CompareTo(Book other)
        {
            return this.Title.CompareTo(other.Title);
        }

        /// <summary>
        /// The Equals.
        /// </summary>
        /// <param name="other">The other<see cref="Book"/>.</param>
        /// <returns>The <see cref="bool"/>.</returns>
        public bool Equals(Book other)
        {
            return this.Title == other.Title;
        }

        /// <summary>
        /// The Equals.
        /// </summary>
        /// <param name="obj">The obj<see cref="object"/>.</param>
        /// <returns>The <see cref="bool"/>.</returns>
        public override bool Equals(object obj)
        {
            if (obj == null)
                return base.Equals(obj);

            if (!(obj is Book))
                throw new ArgumentException($"{obj} is not a type Book");

            return Equals(obj as Book);
        }

        /// <summary>
        /// The GetHashCode.
        /// </summary>
        /// <returns>The <see cref="int"/>.</returns>
        public override int GetHashCode()
        {
            return Title.GetHashCode() + Author.GetHashCode();
        }

    }
}
