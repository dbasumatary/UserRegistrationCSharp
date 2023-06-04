using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistrationCSharp
{
    public class UserRegistration
    {
        //UC1: User need to input valid first name
        //The first name starts with capital letter and has minimum three characters
        public void ValidateFirstName()
        {
            Console.Write("\nEnter the first name: ");
            string firstName = @"^[A-Z][a-z]{2,}$";
            Regex regexObject = new Regex(firstName);
            string userInput = Console.ReadLine();
            if (regexObject.IsMatch(userInput))
                Console.WriteLine("\n" + userInput + " is a valid first name");
            else
                Console.WriteLine("\nYou've entered an invalid first name. Please try again.");
        }

        //UC2: User need to input valid last name
        public void ValidateLastName()
        {
            Console.Write("\nEnter the last name: ");
            string lastName = @"^[A-Z][a-z]{2,}$";
            Regex regexObject = new Regex(lastName);
            string userInput = Console.ReadLine();
            if (regexObject.IsMatch(userInput))
                Console.WriteLine("\n" + userInput + " is a valid last name");
            else
                Console.WriteLine("\nYou've entered an invalid last name. Please try again.");
        }

        //UC3: User need to input valid email address
        public void ValidateEmail()
        {
            Console.Write("\nEnter the email of user: ");
            string emailName = @"^[a-z][a-zA-Z0-9.+-]{2,}@[a-z0-9]+[.][a-z]{2,3}[.]?[a-z]{0,3}$";
            Regex regexObject = new Regex(emailName);
            string userInput = Console.ReadLine();
            if (regexObject.IsMatch(userInput))
                Console.WriteLine("\n" + userInput + " is a valid email");
            else
                Console.WriteLine("\nYou've entered an invalid email. Please try again.");
        }

        //UC4: Valid Mobile No (country code followed by space and 10-digit number)
        public void ValidateMobile()
        {
            Console.Write("\nEnter the user mobile number: ");
            string phonePattern = @"^(91)[\s][1-9][0-9]{9}$";
            Regex regexObject = new Regex(phonePattern);
            string userInput = Console.ReadLine();
            if (regexObject.IsMatch(userInput))
                Console.WriteLine("\n" + userInput + " is a valid mobile number");
            else
                Console.WriteLine("\nYou've entered an invalid number. Please try again.");
        }

        //UC5: Valid Password (Minimum 8 characters)
        public void ValidatePassword()
        {
            Console.Write("\nEnter the password: ");
            string passwordPattern = @"^[a-zA-Z0-9~!@#$&*-]{8,}$";
            Regex regexObject = new Regex(passwordPattern);
            string userInput = Console.ReadLine();
            if (regexObject.IsMatch(userInput))
                Console.WriteLine("\n" + userInput + " is a valid password");
            else
                Console.WriteLine("\nYou've entered an invalid password. Please try again.");
        }
    }
}
