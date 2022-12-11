using System.Collections.Generic;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace CustomerService
{
    [ServiceContract]
    public interface ICustomerService
    {
        [OperationContract]
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Wrapped, UriTemplate = "GetCustomers")]
        List<Customer> GetCustomerList();
    }
}
