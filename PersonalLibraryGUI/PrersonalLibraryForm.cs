///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Solution/Project:  Personal Library GUI
//	File Name:         PrersonalLibraryForm.cs
//	Description:       YOUR DESCRIPTION HERE
//	Course:            CSCI 2210 - Data Structures	
//	Author:           Joshua Trimm, trimmj@etsu.edu
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
    using System.Windows.Forms;

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
        /// Initializes a new instance of the <see cref="PersonalLibraryForm"/> class.
        /// </summary>
        public PersonalLibraryForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// The EmailInput_TextBoxChange.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void EmailInput_TextBoxChange(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// The textBox1_Validating.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="CancelEventArgs"/>.</param>
        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
        }

        /// <summary>
        /// The EmailInput_Leave.
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
        /// The FirstName_Leave.
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
        /// The LastNameInput_Leave.
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
        /// The PhoneNumber_Leave.
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
        /// The AddDashesToNumber_TextChanged.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void AddDashesToNumber_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            string phone = String.Empty;


            if (textBox.Text == String.Empty)
                return;

            char lastCharTyped = textBox.Text.Last();

            if (lastCharTyped == '-')
                return;


            if (lastCharTyped < '0' || lastCharTyped > '9')
            {
                phone = textBox.Text;
                phone = phone.Remove(phone.Length - 1);
                PhoneNumberInput.Text = phone;
            }


            if (textBox.TextLength == 3)
                PhoneNumberInput.Text += "-";

            if (textBox.TextLength == 7)
                PhoneNumberInput.Text += "-";

            if (textBox.TextLength > 12)
            {
                phone = textBox.Text;
                phone = phone.Substring(0, 12);
                PhoneNumberInput.Text = phone;
            }
            PhoneNumberInput.Select(PhoneNumberInput.Text.Length, 0);
        }

        /// <summary>
        /// The ENumber_Leave.
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
        /// The City_Leave.
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
        /// The State_Leave.
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
        /// The Zip_Leave.
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
        /// The Street_Leave.
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

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox2 aboutBox2 = new AboutBox2();
            aboutBox2.Show(this);
        }
    }
}
