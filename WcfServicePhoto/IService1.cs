using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using WcfServicePhoto;

namespace WcfServicePhoto
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        string GetData(int value);

        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);



           [WebGet(UriTemplate = "/GetPackages",
        ResponseFormat = WebMessageFormat.Json)]

        //[OperationContract]
        //tbl[] GetPackages();

         //[WebGet(UriTemplate = "/Create?CustomerName={custName}&CustomerSSN={custSSN}&CustomerEmail={custEmail}&CustomerPhone={custPhone}",
         // ResponseFormat = WebMessageFormat.Json)]
        [OperationContract]
        string CreateCustomer(string custName, string custSSN, string custEmail, string custPhone);

        [WebGet(UriTemplate = "/Update?CustomerID={custID}&CustomerName={custName}&CustomerSSN={custSSN}&CustomerEmail={custEmail}&CustomerPhone={custPhone}",
             ResponseFormat = WebMessageFormat.Json)]
        [OperationContract]
        bool UpdateCustomer(int custID, string custName, string custSSN, string custEmail, string custPhone);

        [WebGet(UriTemplate = "/Read?CustomerID={custID}",
            ResponseFormat = WebMessageFormat.Json)]
        [OperationContract]
        tblCustomer ReadCustomer(int custID);

        [WebGet(UriTemplate = "/Delete?CustomerID={custID}",
            ResponseFormat = WebMessageFormat.Json)]
        [OperationContract]
        bool DeleteCustomer(int custID);

        [WebGet(UriTemplate = "/ReadAll",
            ResponseFormat = WebMessageFormat.Json)]
        [OperationContract]
        tblCustomer[] ReadCustomerList();
    }
}

     
    

    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
