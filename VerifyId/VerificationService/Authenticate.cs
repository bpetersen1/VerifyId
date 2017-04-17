using System.Threading.Tasks;
using VerifyId.ServiceObjects;
using RestSharp.Portable;

namespace VerifyId.VerificationService
{
    public class Authenticate
    {
        public async Task<Authentication> Excecute(string emailAddress, string password)
        {
            RestRequest request = new RestRequest("authenticate") { Method = Method.POST };
            request.AddParameter("email_address", emailAddress);
            request.AddParameter("password", password);
            Authentication auth = new Request().Execute<Authentication>(request);
            return auth;
        }
    }
}
