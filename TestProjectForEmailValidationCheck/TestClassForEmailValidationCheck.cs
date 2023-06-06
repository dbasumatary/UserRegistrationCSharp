using UserRegistrationCSharp;

namespace TestProjectForEmailValidationCheck
{
    [TestClass]
    public class TestClassForEmailValidationCheck
    {
        UserRegistration userRegistration;
        
        [TestInitialize]
        public void Setup()
        {
            userRegistration = new UserRegistration();
        }

        [TestMethod]
        [DataRow("abc@yahoo.com", true)]
        [DataRow("abc-100@yahoo.com", true)]
        [DataRow("abc.100@yahoo.com", true)]
        [DataRow("abc111@abc.com", true)]
        [DataRow("abc-100@abc.net", true)]
        [DataRow("abc.100@abc.com.au", true)]
        [DataRow("abc@1.com", true)]
        [DataRow("abc@gmail.com.com", true)]
        [DataRow("abc+100@gmail.com", true)]
        [DataRow("abc", false)]
        [DataRow("abc@.com.my", false)]
        [DataRow("abc123@gmail.a", false)]
        [DataRow("abc123@.com", false)]
        [DataRow("abc123@.com.com", false)]
        [DataRow(".abc@abc.com", false)]
        [DataRow("abc()*@gmail.com", false)]
        [DataRow("abc@%*.com", false)]
        [DataRow("abc..2002@gmail.com", false)]
        [DataRow("abc.@gmail.com", false)]
        [DataRow("abc@abc@gmail.com", false)]
        [DataRow("abc@gmail.com.1a", false)]
        [DataRow("abc@gmail.com.aa.au", false)]

        public void GivenEmailInput_ReturnsIfItIsValidOrNot(string email, bool expected)
        {
            bool result = userRegistration.ValidateEmail(email);
            Assert.AreEqual(expected,result);
        }
    }
}