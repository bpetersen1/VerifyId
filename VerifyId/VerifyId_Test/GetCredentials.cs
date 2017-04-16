using System;
namespace VerifyId_Test
{
    public static class GetCredentials
    {
        public static string Username => ReadEnvironmentVariable("VerifyIdUsername");

        public static string Password => ReadEnvironmentVariable("VerifyIdPassword");

        private static string ReadEnvironmentVariable(string key)
        {
            return Environment.GetEnvironmentVariable(key);
        }
    }

}
