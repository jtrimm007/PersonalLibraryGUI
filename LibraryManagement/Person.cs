///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Solution/Project:  Personal Library GUI
//	Library Purpose:   To add a layer of abstraction to implement DRY programing principles.
//	File Name:         Person.cs
//	Description:       YOUR DESCRIPTION HERE
//	Course:            CSCI 2210 - Data Structures	
//	Author:            Joshua Trimm, trimmj@etsu.edu
//	Created:           10/16/2021
//	Copyright:         Joshua Trimm, 2021
//
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

namespace LibraryManagement
{
    /// <summary>
    /// Defines the <see cref="Person" />.
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
        /// Gets or sets the Zip.
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
        /// Defines the zip.
        /// </summary>
        private string zip;

        /// <summary>
        /// Gets or sets the Id.
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
        /// Defines the id.
        /// </summary>
        private string id;// ETSU ID Number

        /// <summary>
        /// Gets or sets the PhoneNumber.
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
        /// Defines the phoneNumber.
        /// </summary>
        private string phoneNumber;

        /// <summary>
        /// Gets or sets the Email.
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
        /// Defines the email.
        /// </summary>
        private string email;

        /// <summary>
        /// Initializes a new instance of the <see cref="Person"/> class.
        /// </summary>
        public Person()
        {

        }
        public Person(string name, string streetAddress, string city, string state, string zip, string studentId, string phoneNumber, string email)
        {
            this.FirstName = SplitName(name)[0];
            this.LastName = SplitName(name)[1];
            this.StreetAddressLineOne = streetAddress;
            this.City = city;
            this.State = state;
            this.Zip = zip;
            this.Id = studentId;
            this.PhoneNumber = phoneNumber;
            this.Email = email;
        }

        private string[] SplitName(string name)
        {
            if (name != null || name != string.Empty)
            {
                var split = name.Split(' ');

                if(split.Length == 2)
                {
                    return split;
                }

                if(split.Length == 3)
                {
                    var firstAndLastOnly = new string[] {split[0], split[2]};
                    return firstAndLastOnly;
                }

            }

            return null;
        }
    }
}
