using RestSharp.Portable;
using VerifyId.ServiceObjects;
using VerifyId.Common;

namespace VerifyId.VerificationService
{
    public class MyCredits
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="apiKey"></param>
        /// <returns></returns>
        public Credit GetAvailableCredits(string apiKey)
        {
            RestRequest request = new RestRequest(VerifyIdConfig.MyCredits) { Method = Method.GET };
            request.AddQueryParameter("api_key", apiKey);
            return new Request().Execute<Credit>(request);
        }
    }
}
