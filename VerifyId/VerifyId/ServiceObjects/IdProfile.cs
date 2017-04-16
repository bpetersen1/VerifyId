namespace VerifyId.ServiceObjects
{
    public class ProfileVerification
    {
        public string ID_NUMBER { get; set; }
        public string ID_STATUS { get; set; }
        public string FIRSTNAMES { get; set; }
        public string SURNAME { get; set; }
        public string DOB { get; set; }
        public string AGE { get; set; }
        public string GENDER { get; set; }
        public string CITIZENSHIP { get; set; }
        public string DECEASED_STATUS { get; set; }
        public object DECEASED_DATE { get; set; }
    }

    public class IdProfile
    {
        public string Status { get; set; }
        public ProfileVerification Profile_Verification { get; set; }
    }
}
