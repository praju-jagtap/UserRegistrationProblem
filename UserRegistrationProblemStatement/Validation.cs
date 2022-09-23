﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistrationProblemStatement
{
    internal class Validation
    {
        public const string FIRST_NAME_REGEX = "^[A-Z]{1}[a-zA-Z]{2}$";
        public const string LAST_NAME_REGEX = "^[A-Z]{1}[a-zA-Z]{2}$";
        public const string EMAIL_REGEX = "^[a-z0-9]+[@][a-zA-Z]+[.][a-zA-Z]{2,3}$";
        public const string MOBILE_NUMBER = "^[1-9]{2}[ ][0-9]{10}$";
        public void FirstName(string firstname)               //UC1-In FirstName the First Letter Should Capital and minimum 3 Character
        {
            Regex regex = new Regex(FIRST_NAME_REGEX);
            bool result = regex.IsMatch(firstname);
            Console.WriteLine(result);
        }
        public void LastName(string lastname)               //UC1-In LastName the First Letter Should Capital and minimum 3 Character
        {
            Regex regex = new Regex(LAST_NAME_REGEX);
            bool result = regex.IsMatch(lastname);
            Console.WriteLine(result);
        }
        public void Email(string email)               //UC3 - Email Validation
        {
            Regex regex = new Regex(EMAIL_REGEX);
            bool result = regex.IsMatch(email);
            Console.WriteLine(result);
        }
        public void MobileNumber(string mobileno)               //UC4- Pre define Mobile Format Validation 91 8933663470
        {
            Regex regex = new Regex(MOBILE_NUMBER);
            bool result = regex.IsMatch(mobileno);
            Console.WriteLine(result);
        }
    }
}
