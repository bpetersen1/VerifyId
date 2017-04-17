using System.Threading.Tasks;
using VerifyId.ServiceObjects;
using VerifyId.Common;
using RestSharp.Portable;

namespace VerifyId.VerificationService
{
    public class Authenticate
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="emailAddress"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public Authentication Excecute(string emailAddress, string password)
        {
            RestRequest request = new RestRequest(VerifyIdConfig.Authenticate) { Method = Method.POST };
            request.AddParameter("email_address", emailAddress);
            request.AddParameter("password", password);
            Authentication auth = new Request().Execute<Authentication>(request);
            return auth;
        }
    }
}
