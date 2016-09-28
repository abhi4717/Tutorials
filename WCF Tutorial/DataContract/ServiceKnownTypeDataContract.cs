using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCF_Tutorial.DataContract
{
    [DataContract]
    public class ServiceKnownTypeDataContract
    {
        [DataMember]
        public int VersionNumber { get; set; }
    }

    [DataContract]
    public class BaseServiceKnownTypeDataContract
    {
        [DataMember]
        public string Name { get; set; }
    }
}