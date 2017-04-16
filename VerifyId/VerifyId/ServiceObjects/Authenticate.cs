namespace VerifyId.ServiceObjects
{
    public class AuthResult
    {
        public string API_KEY { get; set; }
    }

    public class Authenticate
    {
        public string Status { get; set; }
        public AuthResult Result { get; set; }
    }

}
