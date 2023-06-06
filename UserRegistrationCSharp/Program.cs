namespace UserRegistrationCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to User Validation system");
            UserRegistration userRegistration = new UserRegistration();
            userRegistration.ValidateFirstName();
            userRegistration.ValidateLastName();
            userRegistration.ValidateEmail("abc.100@abc.com.au");
            userRegistration.ValidateMobile();
            userRegistration.ValidatePassword();
        }
    }
}