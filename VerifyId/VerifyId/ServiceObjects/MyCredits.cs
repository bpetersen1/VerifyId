
namespace VerifyId.ServiceObjects
{
    public class MyCreditsResult
    {
        public int credits { get; set; }
    }

    public class Credit
    {
        public string Status { get; set; }
        public MyCreditsResult Result { get; set; }
    }
}
