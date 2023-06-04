namespace UserRegistrationCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to User Validation system");
            UserRegistration userRegistration = new UserRegistration();
            userRegistration.ValidateFirstName();
        }
    }
}