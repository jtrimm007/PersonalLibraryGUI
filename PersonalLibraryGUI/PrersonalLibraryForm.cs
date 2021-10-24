///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Solution/Project:  Personal Library GUI
//	File Name:         PrersonalLibraryForm.cs
//	Description:       Manages the Personal Library Form. On this form the user can open, save, and edit their library. 
//	Course:            CSCI 2210 - Data Structures	
//	Author:            Joshua Trimm, trimmj@etsu.edu
//	Created:           10/16/2021
//	Copyright:         Joshua Trimm, 2021
//
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

namespace PersonalLibraryGUI
{
    using LibraryManagement;
    using System;
    using System.ComponentModel;
    using System.Linq;
    using System.Windows;
    using System.Windows.Forms;
    using Application = System.Windows.Forms.Application;
    using MessageBox = System.Windows.Forms.MessageBox;

    /// <summary>
    /// Defines the <see cref="PersonalLibraryForm" />.
    /// </summary>
    public partial class PersonalLibraryForm : Form
    {
        /// <summary>
        /// Gets or sets the Person.
        /// </summary>
        public Person Person { get; set; } = new Person();

        /// <summary>
        /// Gets or sets the PersonalLibrary.
        /// </summary>
        public PersonalLibrary PersonalLibrary { get; set; } = new PersonalLibrary();

        /// <summary>
        /// Initializes a new instance of the <see cref="PersonalLibraryForm"/> class.
        /// </summary>
        public PersonalLibraryForm()
        {
            InitializeComponent();

            // set the status information at the bottom of the form.
            DateTimeStatus.Text = DateTime.Now.ToString();
            SortStatus.Text = "Sort Completed False";
            SaveStatus.Text = $"Saved Needed: {PersonalLibrary.SaveNeeded}";
        }

        /// <summary>
        /// The EmailInput_Leave check the format of the email after the user click out.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void EmailInput_Leave(object sender, EventArgs e)
        {

            TextBox parseToTextBox = sender as TextBox;
            string email = parseToTextBox.Text;

            if (!Person.EmailIsValid(email))
                InvalidLabel.Visible = true;
            else
                InvalidLabel.Visible = false;
        }

        /// <summary>
        /// The FirstName_Leave ensures that the users first name is one charcter or longer.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void FirstName_Leave(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;

            if (textBox.TextLength <= 1)
                InvalidFirstName.Visible = true;
            else
                InvalidFirstName.Visible = false;
        }

        /// <summary>
        /// The LastNameInput_Leave ensures that the users last name is one character or longer.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void LastNameInput_Leave(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;

            if (textBox.TextLength <= 1)
                InvalidLastName.Visible = true;
            else
                InvalidLastName.Visible = false;
        }

        /// <summary>
        /// The PhoneNumber_Leave ensures that the phone number is correctly validated. Displays an error message if it isn't.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void PhoneNumber_Leave(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;

            if (textBox.TextLength <= 11 && Person.PhoneIsValid(textBox.Text))
                InvalidPhone.Visible = true;
            else
                InvalidPhone.Visible = false;
        }

        /// <summary>
        /// The AddDashesToNumber_TextChanged formats the users phone number as they are typing it.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void AddDashesToNumber_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            string phone = String.Empty;

            // if the TextBox is empty, don't do anything
            if (textBox.Text == String.Empty)
                return;

            // get the last typed character
            char lastCharTyped = textBox.Text.Last();

            // if the last character typed was a dash, don't do anything else.
            if (lastCharTyped == '-')
                return;

            // ensure that the last character typed was between 0 and 9. If it wasn't, remove it
            if (lastCharTyped < '0' || lastCharTyped > '9')
            {
                phone = textBox.Text;
                phone = phone.Remove(phone.Length - 1);
                PhoneNumberInput.Text = phone;
            }

            // the third character in the phone string should be a dash.
            if (textBox.TextLength == 3)
                PhoneNumberInput.Text += "-";

            // the seventh character in the phone string should be a dash.
            if (textBox.TextLength == 7)
                PhoneNumberInput.Text += "-";

            // ensure the phone number is the correct length.
            if (textBox.TextLength > 12)
            {
                phone = textBox.Text;
                phone = phone.Substring(0, 12);
                PhoneNumberInput.Text = phone;
            }

            // if the user tries to type after the defined length, remove the extra character.
            PhoneNumberInput.Select(PhoneNumberInput.Text.Length, 0);
        }

        /// <summary>
        /// The ENumber_Leave validates the users id, e.g., ENumber.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void ENumber_Leave(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;

            if (!Person.IdIsValid(textBox.Text))
                InvalidENumber.Visible = true;
            else
                InvalidENumber.Visible = false;
        }

        /// <summary>
        /// The City_Leave validates that the city isn't left blank.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void City_Leave(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;


            if (textBox.Text == String.Empty)
                InvalidCity.Visible = true;
            else
                InvalidCity.Visible = false;
        }

        /// <summary>
        /// The State_Leave validates that the state isn't left blank.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void State_Leave(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;


            if (textBox.Text == String.Empty)
                InvalidState.Visible = true;
            else
                InvalidState.Visible = false;
        }

        /// <summary>
        /// The Zip_Leave validates the zip code.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void Zip_Leave(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;



            if (textBox.Text == String.Empty || !Person.ZipCodeIsValid(textBox.Text))
                InvalidZip.Visible = true;
            else
                InvalidZip.Visible = false;
        }

        /// <summary>
        /// The Street_Leave validates that the street address isn't left blank.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void Street_Leave(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;

            if (textBox.Text == String.Empty)
                InvalidAddress.Visible = true;
            else
                InvalidAddress.Visible = false;
        }

        /// <summary>
        /// The aboutToolStripMenuItem_Click displays the about window.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox2 aboutBox2 = new AboutBox2();
            aboutBox2.Show(this);
        }

        /// <summary>
        /// The updateOwnerToolStripMenuItem_Click navigates the user to the update librar owner window.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void updateOwnerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // if a library isn't loaded in, warn the user
            if (PersonalLibrary.LibraryOwner == null)
            {
                MessageBox.Show($"Please open the library. The owner has not yet been set.", $"{DateTime.Now}", (MessageBoxButtons)MessageBoxButton.OK, MessageBoxIcon.Information);
                return;
            }

            // make the library owner info box visable.
            LibraryOwnerBox.Visible = true;

            //book details sections are inviable.
            BookDetails.Visible = false;

            // set the current library owners information to the input fields. 
            EmailInput.Text = PersonalLibrary.LibraryOwner.Email;
            FirstNameInput.Text = PersonalLibrary.LibraryOwner.FirstName;
            LastNameInput.Text = PersonalLibrary.LibraryOwner.LastName;
            PhoneNumberInput.Text = PersonalLibrary.LibraryOwner.PhoneNumber;
            StreetAddressLineOneInput.Text = PersonalLibrary.LibraryOwner.StreetAddressLineOne;
            AddressLineTwoInput.Text = PersonalLibrary.LibraryOwner.AddressLineTwo;
            CityInput.Text = PersonalLibrary.LibraryOwner.City;
            StateInput.Text = PersonalLibrary.LibraryOwner.State;
            ZipInput.Text = PersonalLibrary.LibraryOwner.Zip;
            UserIdInput.Text = PersonalLibrary.LibraryOwner.Id;
        }

        /// <summary>
        /// The openToolStripMenuItem_Click opens a library from a text file. If a library is already loaded in, remove it and add the newly opened libraries details.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // remove the currect library if one is loaded in
            if (PersonalLibrary != null)
            {
                BooksInLibrary.DataSource = null;
                PersonalLibrary = new PersonalLibrary();
            }

            // Prompt the user to open a new library file.
            FileManager.OpenFileAndSetTextToGlobalProperty();

            // set the library details
            PersonalLibrary.SetOwnerAndBooksList();

            // Display the list of books
            BooksInLibrary.DataSource = PersonalLibrary.GetBooksListOfTitles();

            // Display the library owners information in the bottom box.
            LibraryOwnerNameInput.Text = $"{PersonalLibrary.LibraryOwner.FirstName} {PersonalLibrary.LibraryOwner.LastName}";
            LibraryOwnerPhoneInput.Text = $"{PersonalLibrary.LibraryOwner.PhoneNumber}";
            LibraryOwnerENumberInput.Text = $"{PersonalLibrary.LibraryOwner.Id}";
            LibraryOwnerEmailInput.Text = $"{PersonalLibrary.LibraryOwner.Email}";
            NumberOfBooksStatus.Text = $"Number of Books: {PersonalLibrary.Count}";
        }

        /// <summary>
        /// The BooksInLibrary_Click displays the books details in the Book Details box.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void BooksInLibrary_Click(object sender, EventArgs e)
        {
            // if the event is null, don't do anything.
            if (BooksInLibrary.SelectedIndex == -1 || BooksInLibrary.SelectedItem == null)
                return;

            // get the book by title
            var book = PersonalLibrary[BooksInLibrary.SelectedItem.ToString()];

            // set the fields in the book details box.
            BookType.Text = book.Type.ToString();
            Title.Text = book.Title;
            Author.Text = book.Author;
            Coauthor.Text = book.Coauthor;
            Category.Text = book.Category.ToString();
            Price.Text = book.Price.ToString();
        }

        /// <summary>
        /// The editToolStripMenuItem_Click turns the book detail field readonly to false to allow the user to edit the book.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BookType.ReadOnly = false;
            Author.ReadOnly = false;
            Coauthor.ReadOnly = false;
            Category.ReadOnly = false;
            Price.ReadOnly = false;
            BookDetails.Text = "Edit Book";
            Update.Visible = true;
        }

        /// <summary>
        /// The Update_Click updates the book.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void Update_Click(object sender, EventArgs e)
        {
            // get the book by title
            var book = PersonalLibrary[Title.Text];

            // update the books information
            book.Type = book.ParseEnumBookType(BookType.Text);
            book.Author = Author.Text;
            book.Coauthor = Coauthor.Text;
            book.Price = Decimal.Parse(Price.Text);
            book.Category = book.ParseEnumCategory(Category.Text);

            // Make the fields readonly again.
            BookType.ReadOnly = true;
            Author.ReadOnly = true;
            Coauthor.ReadOnly = true;
            Category.ReadOnly = true;
            Price.ReadOnly = true;
            BookDetails.Text = "Book Details";
            Update.Visible = false;
        }

        /// <summary>
        /// The UpdateOwner_Click updates the library owners information with the user click the update button.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void UpdateOwner_Click(object sender, EventArgs e)
        {
            PersonalLibrary.LibraryOwner.Email = EmailInput.Text;
            PersonalLibrary.LibraryOwner.FirstName = FirstNameInput.Text;
            PersonalLibrary.LibraryOwner.LastName = LastNameInput.Text;
            PersonalLibrary.LibraryOwner.PhoneNumber = PhoneNumberInput.Text;
            PersonalLibrary.LibraryOwner.StreetAddressLineOne = StreetAddressLineOneInput.Text;
            PersonalLibrary.LibraryOwner.AddressLineTwo = AddressLineTwoInput.Text;
            PersonalLibrary.LibraryOwner.City = CityInput.Text;
            PersonalLibrary.LibraryOwner.State = StateInput.Text;
            PersonalLibrary.LibraryOwner.Zip = ZipInput.Text;
            PersonalLibrary.LibraryOwner.Id = UserIdInput.Text;

            // hide the library owner edit section
            LibraryOwnerBox.Visible = false;

            // Display the book details section
            BookDetails.Visible = true;
        }

        /// <summary>
        /// The CancelUpdateOwner_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void CancelUpdateOwner_Click(object sender, EventArgs e)
        {
            LibraryOwnerBox.Visible = false;
            BookDetails.Visible = true;
        }

        /// <summary>
        /// The saveToolStripMenuItem_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileManager.SaveLibrary(PersonalLibrary);
            PersonalLibrary.SaveNeeded = false;
        }

        /// <summary>
        /// The sortToolStripMenuItem_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void sortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var listOfBooks = PersonalLibrary.GetBooksList();

            listOfBooks.Sort();

            BooksInLibrary.DataSource = PersonalLibrary.GetBooksListOfTitles();
            SortStatus.Text = "Sort Completed True";
        }

        /// <summary>
        /// The quiteToolStripMenuItem_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void quiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// The showAllByAuthorToolStripMenuItem_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void showAllByAuthorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (BooksInLibrary.SelectedItem == null)
                return;

            var book = PersonalLibrary[BooksInLibrary.SelectedItem.ToString()];
            var authorBooks = PersonalLibrary.RetrieveByAuthor(book.Author);

            BooksInLibrary.DataSource = null;
            BooksInLibrary.DataSource = PersonalLibrary.GetBooksListOfTitles(authorBooks);
        }

        /// <summary>
        /// The addToolStripMenuItem_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BookType.ReadOnly = false;
            Title.ReadOnly = false;
            Author.ReadOnly = false;
            Coauthor.ReadOnly = false;
            Category.ReadOnly = false;
            Price.ReadOnly = false;
            BookDetails.Text = "Add New Book";
            AddBookButton.Visible = true;
        }

        /// <summary>
        /// The AddBookButton_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void AddBookButton_Click(object sender, EventArgs e)
        {
            Book book = new Book();
            book.Type = book.ParseEnumBookType(BookType.Text);
            book.Author = Author.Text;
            book.Title = Title.Text;
            book.Coauthor = Coauthor.Text;
            book.Price = Decimal.Parse(Price.Text);
            book.Category = book.ParseEnumCategory(Category.Text);

            PersonalLibrary += book;

            BookType.ReadOnly = true;
            Title.ReadOnly = true;
            Author.ReadOnly = true;
            Coauthor.ReadOnly = true;
            Category.ReadOnly = true;
            Price.ReadOnly = true;
            BookDetails.Text = "Book Details";
            AddBookButton.Visible = false;

            BooksInLibrary.DataSource = null;
            BooksInLibrary.DataSource = PersonalLibrary.GetBooksListOfTitles();
        }

        /// <summary>
        /// The removeToolStripMenuItem_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (BooksInLibrary.SelectedItem == null)
                return;

            var book = PersonalLibrary[BooksInLibrary.SelectedItem.ToString()];

            PersonalLibrary -= book;


            BooksInLibrary.DataSource = null;
            BooksInLibrary.DataSource = PersonalLibrary.GetBooksListOfTitles();
            NumberOfBooksStatus.Text = $"Number of Books {PersonalLibrary.Count}";
        }
    }
}
