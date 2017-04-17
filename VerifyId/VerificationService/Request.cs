using System.Net;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RestSharp.Portable;
using RestSharp.Portable.HttpClient;


namespace VerifyId.VerificationService
{
    public class Request
    {
        public T Execute<T>(IRestRequest request) where T : class
        {
            IRestClient client = new RestClient(Common.VerifyIdConfig.VerifyIdBaseUrl);
            request.AddHeader("Accept", "application/json");
            Task<IRestResponse> response = client.Execute(request);
            var requestObject = JsonConvert.DeserializeObject<T>(response.Result.Content);
            return requestObject;
        }
    }
}
