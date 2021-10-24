///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Solution/Project:  Personal Library GUI
//	Library Purpose:   To add a layer of abstraction to implement DRY programing principles.
//	File Name:         FileManager.cs
//	Description:       The FileManager is used to Open, read, and save files. 
//	Course:            CSCI 2210 - Data Structures	
//	Author:            Joshua Trimm, trimmj@etsu.edu
//	Created:           10/24/2021
//	Copyright:         Joshua Trimm, 2021
//
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

namespace LibraryManagement
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Windows.Forms;

    /// <summary>
    /// The <see cref="FileManager" /> is used to Open, read, and save files.
    /// </summary>
    public static class FileManager
    {
        /// <summary>
        /// Gets the TextFromFile. This is just a long string with the delimiters from the text file.
        /// </summary>
        public static string TextFromFile { get; private set; }

        /// <summary>
        /// Defines the GlobalDelimiter.
        /// </summary>
        public static char GlobalDelimiter = '|';

        /// <summary>
        /// Gets the path of the opened file.
        /// </summary>
        public static string OpenedFilePath { get; private set; }

        /// <summary>
        /// The OpenFileAndSaveText prompts the user with an open dialog box. After the user chooses a text file, the text is gathered from the file, saved to a global variable for later use and displayed in the console.
        /// </summary>
        public static void OpenFileAndSetTextToGlobalProperty()
        {
            // Instantiate the dialog box.
            OpenFileDialog openFileDialog = OpenDialogBox();

            // If the user click cancel, close the dialog box
            if (openFileDialog.ShowDialog() == DialogResult.Cancel)
                return;

            // Instantiate a StreamRead for later use
            StreamReader streamReader = null;

            try
            {
                // Get the file chosen from the dialog box
                streamReader = new StreamReader(openFileDialog.FileName);



                // Read the files text to the end and put it in a global static variable
                TextFromFile = streamReader.ReadToEnd();

                // Set the global file path
                OpenedFilePath = openFileDialog.FileName;


            }
            catch (Exception error)
            {
                Console.WriteLine(error); // if something happens display the exception
            }
            finally
            {
                streamReader.Close(); // close the StreamReader
            }
        }

        /// <summary>
        /// The OpenDialogBox opens a open/save dialog box for the user to choose a text file.
        /// </summary>
        /// <returns>A <see cref="OpenFileDialog"/>.</returns>
        private static OpenFileDialog OpenDialogBox()
        {
            // Instantiate a Open/save dialog box and define the initial directory, types of files it can open, and title. 
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = $@"{Application.StartupPath}.\.\LibraryData";
            openFileDialog.Title = "Select a Text File";
            openFileDialog.Filter = "text files|*.txt";
            return openFileDialog;
        }

        /// <summary>
        /// The SaveLibrary method is used to open a save dialog box and save the Personal Library to a text file.
        /// </summary>
        /// <param name="personalLibrary">The personalLibrary<see cref="PersonalLibrary"/>.</param>
        public static void SaveLibrary(PersonalLibrary personalLibrary)
        {
            SaveFileDialog saveFileDialog = SaveFileDialogBox(); // open the Save File Dialog Box

            if (saveFileDialog.ShowDialog() == DialogResult.Cancel) // if the user cancels, close the save window
            {
                return;
            }

            StreamWriter streamWriter = null; // declare a StreamWriter to write the Personal Library information to the file.

            try
            {
                // instantiate the StreamWriter.
                streamWriter = new StreamWriter(new FileStream(saveFileDialog.FileName, FileMode.Create, FileAccess.Write));

                // write the Personal Library data to the file.
                streamWriter.Write(FormateStringToSaveToFile(personalLibrary));
            }
            catch (Exception error)
            {
                Console.WriteLine(error);
            }
            finally
            {
                if (streamWriter != null)
                {
                    // close the StreamWriter after it is finish. 
                    streamWriter.Close();
                }
            }
        }

        /// <summary>
        /// The SaveFileDialogBox method defines the folder location of the Initial Directory. It also creates a new SaveFileDialog object and returns it.
        /// </summary>
        /// <returns>The <see cref="SaveFileDialog"/>.</returns>
        private static SaveFileDialog SaveFileDialogBox()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.InitialDirectory = $@"{Application.StartupPath}.\.\LibraryData";
            saveFileDialog.Title = "Save Personal Library";
            saveFileDialog.Filter = "text files|*.txt";

            return saveFileDialog;
        }

        /// <summary>
        /// The FormateStringToSaveToFile formates a string to save to a text file. It gets the owner delimited data and the list of books delimited data and combines the data to save. 
        /// </summary>
        /// <param name="personalLibrary">The personalLibrary<see cref="PersonalLibrary"/>.</param>
        /// <returns>The <see cref="string"/>.</returns>
        private static string FormateStringToSaveToFile(PersonalLibrary personalLibrary)
        {
            // format the list of books into delimited form.
            var formatedListOfBooks = FormateListOfBooks(personalLibrary.GetBooksList());

            // format the library owners details into delimited form.
            var ownerInfoFormated = FormatLibrarOwnerLine(personalLibrary.LibraryOwner);

            // return the new delimited string representing the Personal Library.
            return $"{ownerInfoFormated}\n{formatedListOfBooks}";
        }

        /// <summary>
        /// The FormateListOfBooks method puts the books into a string that is in delimited form.
        /// </summary>
        /// <param name="books">The books<see cref="List{Book}"/>.</param>
        /// <returns>The <see cref="string"/>.</returns>
        private static string FormateListOfBooks(List<Book> books)
        {
            string pipeDelimiterString = "";
            foreach (var book in books)
            {
                pipeDelimiterString += $"{FormateBookLine(book)}\n";
            }

            return pipeDelimiterString;
        }

        /// <summary>
        /// The FormateBookLine takes the books properties and puts them into delimited form.
        /// </summary>
        /// <param name="book">The book<see cref="Book"/>.</param>
        /// <returns>The <see cref="string"/>.</returns>
        private static string FormateBookLine(Book book)
        {
            return $"{book.Type}|{book.Title}|{book.Author}|{book.Coauthor}|{book.Category}|{book.Price}";
        }

        /// <summary>
        /// The FormatLibrarOwnerLine formats the library's owner's information into a string that is delimited.
        /// </summary>
        /// <param name="person">The person<see cref="Person"/>.</param>
        /// <returns>The <see cref="string"/>.</returns>
        private static string FormatLibrarOwnerLine(Person person)
        {
            return $"{person.FirstName} {person.LastName}|{person.StreetAddressLineOne} {person.AddressLineTwo}|{person.City}|{person.State}|{person.Zip}|{person.Id}|{person.PhoneNumber}|{person.Email}";
        }
    }
}
