///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Solution/Project:  Personal Library GUI
//	Library Purpose:   To add a layer of abstraction to implement DRY programing principles.
//	File Name:         RegexLibraryHelper.cs
//	Description:       This class is used to help manage the Regex logic.
//	Course:            CSCI 2210 - Data Structures	
//	Author:            Joshua Trimm, trimmj@etsu.edu
//	Created:           10/16/2021
//	Copyright:         Joshua Trimm, 2021
//
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

namespace LibraryManagement
{
    using System.Text.RegularExpressions;

    /// <summary>
    /// The <see cref="RegexLibraryHelper" /> houses all the validation strings for the Regex Match. It is also used to validate the zip code, phone number, student id, and email address.
    /// </summary>
    public class RegexLibraryHelper
    {
        /// <summary>
        /// The regex Zip code pattern.
        /// </summary>
        private readonly string ZipCodeValidationString = @"^\d{5}(-\d{4})?$";

        /// <summary>
        /// The regex ETSU Student Id pattern
        /// </summary>
        private readonly string IdValidationString = @"^[E][0][0]\d{6}$";

        /// <summary>
        /// The regex Phone Number pattern
        /// https://regexlib.com/Search.aspx?k=phone&AspxAutoDetectCookieSupport=1.
        /// </summary>
        private readonly string PhoneNumberValidationString = @"^[2-9]\d{2}-\d{3}-\d{4}$";

        /// <summary>
        /// The regex Email pattern
        /// </summary>
        private readonly string EmailValidationString = @"^[0-9a-zA-Z]([-.\w]*[0-9a-zA-Z_+])*@([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,9}$";

        /// <summary>
        /// Initializes a new instance of the <see cref="RegexLibraryHelper"/> class.
        /// </summary>
        public RegexLibraryHelper()
        {
        }

        /// <summary>
        /// Validates if the zip code is in the correct form.
        /// </summary>
        /// <param name="zip">The zip code <see cref="string"/>.</param>
        /// <returns>True if the match was successful and false if it was not <see cref="bool"/>.</returns>
        public bool ZipCodeIsValid(string zip)
        {
            Regex regex = new Regex(ZipCodeValidationString);
            Match match = regex.Match(zip);

            if (match.Success)
                return true;
            return false;
        }

        /// <summary>
        /// Validates the Student Id.
        /// </summary>
        /// <param name="etsuId">The etsuId<see cref="string"/>.</param>
        /// <returns>Returns true if the validation is successful, false if unsuccessful <see cref="bool"/>.</returns>
        public bool IdIsValid(string etsuId)
        {
            Regex regex = new Regex(IdValidationString);
            Match match = regex.Match(etsuId);

            if (match.Success)
                return true;
            return false;
        }

        /// <summary>
        /// Validates an email address.
        /// </summary>
        /// <param name="email">The email <see cref="string"/>.</param>
        /// <returns>Returns true if valid, false if not valid <see cref="bool"/>.</returns>
        public bool EmailIsValid(string email)
        {
            Regex regex = new Regex(EmailValidationString);
            Match match = regex.Match(email);

            if (match.Success)
                return true;
            return false;
        }

        /// <summary>
        /// Validates a phone number.
        /// </summary>
        /// <param name="phoneNumber">a phone number as a <see cref="string"/>.</param>
        /// <returns>Returns true if valid, false if validation is unsuccessful <see cref="bool"/>.</returns>
        public bool PhoneIsValid(string phoneNumber)
        {
            Regex regex = new Regex(PhoneNumberValidationString);
            Match match = regex.Match(phoneNumber);

            if (match.Success)
                return true;
            return false;
        }
    }
}
