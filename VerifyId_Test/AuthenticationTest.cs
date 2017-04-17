using System.Net;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace VerifyId_Test
{
    [TestClass]
    public class AuthenticationTest
    {
        private readonly string _username;
        private readonly string _password;

        public AuthenticationTest()
        {
            _password = GetCredentials.Password;
            _username =  GetCredentials.Username;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
        }

        [TestMethod]
        public void TestValidLogin()
        {
            var key = new VerifyId.VerificationService.Authenticate();
            var apiKey = key.Excecute(_username, _password);
            Assert.IsTrue(!string.IsNullOrEmpty(apiKey.Result.API_KEY));
        }

        [TestMethod]
        public  void TestInvalidLogin()
        {
            var key = new VerifyId.VerificationService.Authenticate();
            var apiKey =  key.Excecute("WrongUsername", "WrongPassword");
            Assert.IsTrue(apiKey.Status.Equals("Failure"));
        }
    }
}
