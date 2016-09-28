using System.Runtime.Serialization;

namespace WCF_Tutorial.DataContract
{
    [DataContract(Namespace = "MyNamespace")]
    public class NamespaceDataContract
    {
        [DataMember]
        public int VersionNumber { get; set; }
    }
}