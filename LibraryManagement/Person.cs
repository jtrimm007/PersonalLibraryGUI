///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Solution/Project:  Personal Library GUI
//	File Name:         Person.cs
//	Description:       Manager the person object
//	Course:            CSCI 2210 - Data Structures	
//	Author:            Joshua Trimm, trimmj@etsu.edu
//	Created:           10/16/2021
//	Copyright:         Joshua Trimm, 2021
//
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

namespace LibraryManagement
{
    /// <summary>
    /// Defines the <see cref="Person" />. The <see cref="Person"/> class extends the <see cref="RegexLibraryHelper"/> class.
    /// </summary>
    public class Person : RegexLibraryHelper
    {
        /// <summary>
        /// Gets or sets the FirstName.
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets the LastName.
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Gets or sets the StreetAddressLineOne.
        /// </summary>
        public string StreetAddressLineOne { get; set; }

        /// <summary>
        /// Gets or sets the AddressLineTwo.
        /// </summary>
        public string AddressLineTwo { get; set; }

        /// <summary>
        /// Gets or sets the City.
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// Gets or sets the State.
        /// </summary>
        public string State { get; set; }

        /// <summary>
        /// Gets or sets the Zip with regex validation.
        /// </summary>
        public string Zip
        {
            get { return zip; }
            set
            {
                if (ZipCodeIsValid(value))
                {
                    zip = value;
                    return;
                }
                zip = null;
            }
        }

        /// <summary>
        /// Private zip.
        /// </summary>
        private string zip;

        /// <summary>
        /// Gets or sets the Id with regex validation.
        /// </summary>
        public string Id
        {
            get { return id; }
            set
            {
                if (IdIsValid(value))
                {
                    id = value;
                    return;
                }
                id = null;
            }
        }

        /// <summary>
        /// Private id.
        /// </summary>
        private string id;// ETSU ID Number

        /// <summary>
        /// Gets or sets the PhoneNumber with regex validation.
        /// </summary>
        public string PhoneNumber
        {
            get { return phoneNumber; }
            set
            {
                if (PhoneIsValid(value))
                {
                    phoneNumber = value;
                    return;
                }
                phoneNumber = null;
            }
        }

        /// <summary>
        /// Private phoneNumber.
        /// </summary>
        private string phoneNumber;

        /// <summary>
        /// Gets or sets the Email with regex validation.
        /// </summary>
        public string Email
        {
            get { return email; }
            set
            {
                if (EmailIsValid(value))
                {
                    email = value;
                    return;
                }
                email = null;
            }
        }

        /// <summary>
        /// Private email.
        /// </summary>
        private string email;

        /// <summary>
        /// Initializes a new instance of the <see cref="Person"/> class.
        /// </summary>
        public Person()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Person"/> class.
        /// </summary>
        /// <param name="name">The name<see cref="string"/>.</param>
        /// <param name="streetAddress">The streetAddress<see cref="string"/>.</param>
        /// <param name="city">The city<see cref="string"/>.</param>
        /// <param name="state">The state<see cref="string"/>.</param>
        /// <param name="zip">The zip<see cref="string"/>.</param>
        /// <param name="studentId">The studentId<see cref="string"/>.</param>
        /// <param name="phoneNumber">The phoneNumber<see cref="string"/>.</param>
        /// <param name="email">The email<see cref="string"/>.</param>
        public Person(string name, string streetAddress, string city, string state, string zip, string studentId, string phoneNumber, string email)
        {
            this.FirstName = SplitName(name)[0]; // get and set the first name of the library owner
            this.LastName = SplitName(name)[1]; // get and set the last name of the library owner
            this.StreetAddressLineOne = streetAddress;
            this.City = city;
            this.State = state;
            this.Zip = zip;
            this.Id = studentId;
            this.PhoneNumber = phoneNumber;
            this.Email = email;
        }

        /// <summary>
        /// The SplitName method separates the name into first and last.
        /// </summary>
        /// <param name="name">The name<see cref="string"/>.</param>
        /// <returns>The first and last name in a <see cref="string[]"/>. First Name is index 0 and Last Name is index 1.</returns>
        private string[] SplitName(string name)
        {
            if (name != null || name != string.Empty) // make sure the name isn't empty or null before proceeding.
            {
                var split = name.Split(' '); // split the name

                if (split.Length == 2) // if the array is only two in length, there is only a First and Last name present. 
                {
                    return split;
                }

                if (split.Length == 3) // if there was a middle name, get the 0 and index to set the first and last name.
                {
                    var firstAndLastOnly = new string[] { split[0], split[2] };
                    return firstAndLastOnly;
                }

            }

            return null;
        }
    }
}
