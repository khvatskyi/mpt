using System.Runtime.Serialization;

namespace CustomerService
{
    [DataContract(Namespace = "")]
    public class Customer
    {
        [DataMember]
        public int CustomerId { get; set; }

        [DataMember]
        public string FirstName { get; set; }

        [DataMember]
        public string LastName { get; set; }

        [DataMember]
        public string Address { get; set; }
    }
}
