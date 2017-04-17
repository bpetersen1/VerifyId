using System;
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
        }

        [TestMethod]
        public async Task TestValidLogin()
        {
            
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            var key = new VerifyId.VerificationService.Authenticate();
            string apiKey = await key.Excecute(_username, _password);
            Assert.IsTrue(!string.IsNullOrEmpty(apiKey));
        }
    }
}
