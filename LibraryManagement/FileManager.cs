using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagement
{
    public static class FileManager
    {

        public static string TextFromFile { get; set; }
        public static char GlobalDelimiter = '|';
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

        public static void SaveLibrary(PersonalLibrary personalLibrary)
        {
            SaveFileDialog saveFileDialog = SaveFileDialogBox();

            if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }

            StreamWriter streamWriter = null;

            try
            {
                streamWriter = new StreamWriter(new FileStream(saveFileDialog.FileName, FileMode.Create, FileAccess.Write));
                streamWriter.Write(FormateStringToSaveToFile(personalLibrary));
            }
            catch (Exception error)
            {
                Console.WriteLine(error);
            }
            finally
            {
                if(streamWriter != null)
                {
                    streamWriter.Close();
                }
            }
        }

        private static SaveFileDialog SaveFileDialogBox()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.InitialDirectory = $@"{Application.StartupPath}.\.\LibraryData";
            saveFileDialog.Title = "Save Personal Library";
            saveFileDialog.Filter = "text files|*.txt";

            return saveFileDialog;
        }

        private static string FormateStringToSaveToFile(PersonalLibrary personalLibrary)
        {
            var formatedListOfBooks = FormateListOfBooks(personalLibrary.GetBooksList());
            var ownerInfoFormated = FormatLibrarOwnerLine(personalLibrary.LibraryOwner);

            return $"{ownerInfoFormated}\n{formatedListOfBooks}";
        }
        private static string FormateListOfBooks(List<Book> books)
        {
            string pipeDelimiterString = "";
            foreach(var book in books)
            {
                pipeDelimiterString += $"{FormateBookLine(book)}\n";
            }

            return pipeDelimiterString;
        }
        private static string FormateBookLine(Book book)
        {
            return $"{book.Type}|{book.Title}|{book.Author}|{book.Coauthor}|{book.Category}|{book.Price}";
        }
        private static string FormatLibrarOwnerLine(Person person)
        {
            return $"{person.FirstName} {person.LastName}|{person.StreetAddressLineOne} {person.AddressLineTwo}|{person.City}|{person.State}|{person.Zip}|{person.Id}|{person.PhoneNumber}|{person.Email}";
        }
    }
}
