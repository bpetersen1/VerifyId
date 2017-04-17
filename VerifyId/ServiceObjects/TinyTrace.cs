using System.Collections.Generic;

namespace VerifyId.ServiceObjects
{
    public class Address
    {
        public string ADDR_UPDATE_DATE { get; set; }
        public string ADDR_LINE1 { get; set; }
        public string ADDR_LINE2 { get; set; }
        public object ADDR_LINE3 { get; set; }
        public object ADDR_LINE4 { get; set; }
        public string ADDR_TYPE { get; set; }
        public string ADDR_POSTAL_CODE { get; set; }
    }

    public class Addresses
    {
        public IList<Address> address { get; set; }
    }

    public class Telephone
    {
        public string TEL_UPDATE_DATE { get; set; }
        public string TEL_NUM { get; set; }
        public string TEL_TYPE { get; set; }
    }

    public class Telephones
    {
        public IList<Telephone> telephone { get; set; }
    }

    public class TinyTrace
    {
        public string ID_NUMBER { get; set; }
        public string FORENAME1 { get; set; }
        public string FORENAME2 { get; set; }
        public IList<object> FORENAME3 { get; set; }
        public string SURNAME { get; set; }
        public string DECEASED_FLAG { get; set; }
        public IList<object> DECEASED_DATE { get; set; }
        public IList<object> DECEASED_REASON { get; set; }
        public string DOB { get; set; }
        public string GENDER { get; set; }
        public string VERIFIED_FLAG { get; set; }
        public string VERIFIED_DATE { get; set; }
        public Addresses addresses { get; set; }
        public Telephones telephones { get; set; }
    }

    public class Trace
    {
        public string Status { get; set; }
        public TinyTrace Tiny_Trace { get; set; }
    }
    
}
