using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace RandomNumberService
{
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        [WebGet(UriTemplate = "/Random/")]
        string RandomGen();
        
    }

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
        public string StringValue { get;set; }
    }
}
