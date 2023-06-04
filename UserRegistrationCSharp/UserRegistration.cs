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
    }
}
