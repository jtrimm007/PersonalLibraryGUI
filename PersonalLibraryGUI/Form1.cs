using LibraryManagement;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalLibraryGUI
{
    public partial class Form1 : Form
    {
        public Person Person { get; set; } = new Person();
        public Form1()
        {
            InitializeComponent();
        }

        private void EmailInput_TextBoxChange(object sender, EventArgs e)
        {
            //Console.WriteLine($"Object {sender} and EventArgs {e}");
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {

        }

        private void EmailInput_Leave(object sender, EventArgs e)
        {

            TextBox parseToTextBox = sender as TextBox;
            string email = parseToTextBox.Text;

            if (!Person.EmailIsValid(email))
                InvalidLabel.Visible = true;
            else
                InvalidLabel.Visible = false;

        }

        private void FirstName_Leave(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;

            if (textBox.TextLength <= 1)
                InvalidFirstName.Visible = true;
            else
                InvalidFirstName.Visible = false;
        }

        private void LastNameInput_Leave(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;

            if (textBox.TextLength <= 1)
                InvalidLastName.Visible = true;
            else
                InvalidLastName.Visible = false;
        }

        private void PhoneNumber_Leave(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;

            if (textBox.TextLength <= 11 && Person.PhoneIsValid(textBox.Text))
                InvalidPhone.Visible = true;
            else
                InvalidPhone.Visible = false;
        }

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

            if(textBox.TextLength == 7)
                PhoneNumberInput.Text += "-";

            if (textBox.TextLength > 12)
            {
                phone = textBox.Text;
                phone = phone.Substring(0, 12);
                PhoneNumberInput.Text = phone;
            }
            PhoneNumberInput.Select(PhoneNumberInput.Text.Length, 0);

        }

        private void ENumber_Leave(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;

            if (!Person.IdIsValid(textBox.Text))
                InvalidENumber.Visible = true;
            else
                InvalidENumber.Visible = false;

        }

        private void City_Leave(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;


            if (textBox.Text == String.Empty)
                InvalidCity.Visible = true;
            else
                InvalidCity.Visible = false;
        }

        private void State_Leave(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;


            if (textBox.Text == String.Empty)
                InvalidState.Visible = true;
            else
                InvalidState.Visible = false;
        }

        private void Zip_Leave(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;



            if (textBox.Text == String.Empty || !Person.ZipCodeIsValid(textBox.Text))
                InvalidZip.Visible = true;
            else
                InvalidZip.Visible = false;
        }

        private void Street_Leave(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;

            if (textBox.Text == String.Empty)
                InvalidAddress.Visible = true;
            else
                InvalidAddress.Visible = false;
        }
    }
}
