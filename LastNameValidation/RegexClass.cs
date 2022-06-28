using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegestration
{
    internal class RegexClass
    {

        //public Regex FirstNameRegex = new Regex(@"^[A-Z]{1}[A-Za-z]{3,}?$");
        //public void ValidateFirstNameRegex(string FirstName)
        //{
        //    Console.WriteLine("\nFirstName:" + FirstName);
        //    if (FirstNameRegex.IsMatch(FirstName))
        //    {
        //        Console.WriteLine("valide");
        //    }
        //    else
        //    {
        //        Console.WriteLine("not valid");
        //    }

        //}
        public Regex LastNameRegex = new Regex(@"^[A-Z]{1}[A-Za-z]{3,}?$");
        public void ValidateLastNameRegex(string LastName)
        {
            Console.WriteLine("\nLastName:" + LastName);
            if (LastNameRegex.IsMatch(LastName))
            {
                Console.WriteLine("valide");
            }
            else
            {
                Console.WriteLine("not valid");
            }


        }
        //public Regex EmailAddressRegex = new Regex(@"^[a-zA-Z0-9]+([._+-][a-zA-Z0-9]+)*@[a-zA-Z0-9]+.[a-zA-Z]{2,4}([.][a-zA-Z]{2,})?$");
        //public void ValidateEmailAddressRegex(string EmailAddress)
        //{
        //    Console.WriteLine("\nemail address:" + EmailAddress);
        //    if (EmailAddressRegex.IsMatch(EmailAddress))
        //    {
        //        Console.WriteLine("valide");
        //    }
        //    else
        //    {
        //        Console.WriteLine("not valid");
        //    }


        //}
        //public Regex PhoneNumberRegex = new Regex(@"^(91){1}[ ]+[0-9]{10}$"); //@"^[0-9]{2,3}\s[1-9][0-9]{9}$"  //[0-9]{2}[ ]?[6-9][0-9]{9}
        //public void ValidatePhoneNumberRegex(string PhoneNumber)
        //{
        //    Console.WriteLine("\nphonenumber:" + PhoneNumber);
        //    if (PhoneNumberRegex.IsMatch(PhoneNumber))
        //    {
        //        Console.WriteLine("valide");
        //    }
        //    else
        //    {
        //        Console.WriteLine("not valid");
        //    }


        //}
        //public Regex PasswordRegex = new Regex(@"^[A-Za-z]{8,}[A-Z]{1,}[0-9]{1,}[-~!@#$%^*()_+{}:|?`;',]{1,}$");
        //public void ValidatePasswordRegex(string Password)
        //{
        //    Console.WriteLine("\nPassword:" + Password);
        //    if (PasswordRegex.IsMatch(Password))
        //    {
        //        Console.WriteLine("valide");
        //    }
        //    else
        //    {
        //        Console.WriteLine("not valid");
        //    }


        //}
    }
}
