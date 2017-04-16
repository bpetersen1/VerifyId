namespace VerifyId.ServiceObjects
{
    public class MaritalStatusEnquiry
    {
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string BirthDate { get; set; }
        public string Gender { get; set; }
        public string MaritalStatusDesc { get; set; }
        public string SpouseIDno { get; set; }
        public string SpouseFirstName { get; set; }
        public string SpouseSurName { get; set; }
    }

    public class MaritalStatus
    {
        public string Status { get; set; }
        public MaritalStatusEnquiry Marital_Status_Enquiry { get; set; }
    }
}
