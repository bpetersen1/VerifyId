using System;
using System.Net;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace VerifyId_Test
{
    [TestClass]
    public class MyCreditsTest
    {
        public MyCreditsTest()
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
        }
        [TestMethod]
        public async Task TestResponseForMyCredits()
        {
            var service = new VerifyId.VerificationService.Authenticate();
            var apikey = await service.Excecute(GetCredentials.Username, GetCredentials.Password);
            var mycredit = new VerifyId.VerificationService.MyCredits();
            var result = mycredit.GetAvailableCredits(apikey.Result.API_KEY);
            Assert.IsTrue(result.Result.credits > 1);
        }
    }
}
