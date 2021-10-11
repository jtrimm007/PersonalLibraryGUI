using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LibraryManagement
{
    public class RegexLibraryHelper
    {

        private readonly string ZipCodeValidationString = @"^\d{5}(-\d{4})?$";
        private readonly string IdValidationString = @"^[E][0][0]\d{6}$";
        /// <summary>
        /// https://regexlib.com/Search.aspx?k=phone&AspxAutoDetectCookieSupport=1
        /// </summary>
        private readonly string PhoneNumberValidationString = @"^[2-9]\d{2}-\d{3}-\d{4}$";


        private readonly string EmailValidationString = @"^[0-9a-zA-Z]([-.\w]*[0-9a-zA-Z_+])*@([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,9}$";
        public bool ZipCodeIsValid(string zip)
        {
            Regex regex = new Regex(ZipCodeValidationString);
            Match match = regex.Match(zip);

            if (match.Success)
                return true;
            return false;
        }
        public bool IdIsValid(string etsuId)
        {
            Regex regex = new Regex(IdValidationString);
            Match match = regex.Match(etsuId);

            if (match.Success)
                return true;
            return false;
        }
        public bool EmailIsValid(string email)
        {
            Regex regex = new Regex(EmailValidationString);
            Match match = regex.Match(email);

            if (match.Success)
                return true;
            return false;
        }

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
